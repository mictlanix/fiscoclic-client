//
// FiscoClicClient.cs
//
// Author:
//       Eddy Zavaleta <eddy@mictlanix.com>
//
// Copyright (c) 2013-2016 Eddy Zavaleta, Mictlanix, and contributors.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using Mictlanix.FiscoClic.Client.Internals;
using Mictlanix.CFDv32;

namespace Mictlanix.FiscoClic.Client
{
	public class FiscoClicClient
	{
		public static string PRODUCTION_URL = @"https://www.fiscoclic.mx/factura/WSEntityServices/timbre/TimbraWS";

		public FiscoClicClient (string username, string password) : this (username, password, PRODUCTION_URL)
		{
		}

		public FiscoClicClient (string username, string password, string url)
		{
			Username = username;
			Password = password;
			Url = url;

			ServicePointManager.ServerCertificateValidationCallback = 
				(object sp, X509Certificate c, X509Chain r, SslPolicyErrors e) => true;
		}

		public string Username { get; protected set; }
		public string Password { get; protected set; }
		public string Url { get; protected set; }

		public TimbreFiscalDigital Stamp (Comprobante cfd)
		{
			return Stamp (cfd.ToXmlString ());
		}

		public TimbreFiscalDigital Stamp (string xml)
		{
			var env = CreateEnvelope (xml);
			string response = TryRequest (env);

			if (response.Length == 0) {
				throw new FiscoClicClientException ("Bad response format.");
			}

			var doc = SoapEnvelope.FromXml (response);

			if (doc.Body.Length == 0) {
				throw new FiscoClicClientException ("Bad response format.");
			}

			if (doc.Body[0] is TimbraCFDIXMLResponse) {
				var res = doc.Body[0] as TimbraCFDIXMLResponse;
				var tfd = TimbreFiscalDigital.FromXml (res.Return);

				return new TimbreFiscalDigital {
					UUID = tfd.UUID,
					FechaTimbrado = tfd.FechaTimbrado,
					selloCFD = tfd.selloCFD,
					noCertificadoSAT = tfd.noCertificadoSAT,
					selloSAT = tfd.selloSAT
				};
			}

			if (doc.Body[0] is SoapFault) {
				var fault = doc.Body[0] as SoapFault;
				throw new FiscoClicClientException (fault.FaultString, fault.Detail.Exception);
			}

			return null;
		}
		
		public bool Cancel (string issuer, string uuid)
		{
			var env = CreateEnvelope (issuer, uuid);
			string response = TryRequest (env);

			if (response.Length == 0) {
				throw new FiscoClicClientException ("Bad response format.");
			}

			var doc = SoapEnvelope.FromXml (response);

			if (doc.Body.Length == 0) {
				throw new FiscoClicClientException ("Bad response format.");
			}

			if (doc.Body[0] is CancelaCFDIResponse) {
				var res = doc.Body[0] as CancelaCFDIResponse;
				return Convert.ToBoolean (res.Return);
			}

			if (doc.Body[0] is SoapFault) {
				var fault = doc.Body[0] as SoapFault;
				throw new FiscoClicClientException (fault.FaultString, fault.Detail.Exception);
			}

			return false;
		}

		SoapEnvelope CreateEnvelope (string xml)
		{
			var request = new SoapEnvelope {
				Body = new TimbraCFDIXML[] {
					new TimbraCFDIXML {
						cfdi = xml,
						user = Username,
						pass = Password
					}
				}
			};

			return request;
		}

		SoapEnvelope CreateEnvelope (string issuer, string uuid)
		{
			var request = new SoapEnvelope {
				Body = new CancelaCFDI[] {
					new CancelaCFDI {
						uuid = uuid,
						rfcEmisor = issuer,
						user = Username,
						pass = Password
					}
				}
			};

			return request;
		}

		string TryRequest (SoapEnvelope env)
		{
			var bytes = env.ToXmlBytes ();
			string response = string.Empty;

#if DEBUG
			System.Diagnostics.Debug.WriteLine (env.ToXmlString ());
#endif

			try {
				response = DoPostRequest (Url, bytes);
			} catch(WebException ex) {
#if DEBUG
				System.Diagnostics.Debug.WriteLine (ex);
#endif
				var hwr = ex.Response as HttpWebResponse;
				if (hwr != null && hwr.StatusCode == HttpStatusCode.InternalServerError) {
					using (var sr = new StreamReader(hwr.GetResponseStream())) {
						response = sr.ReadToEnd ();
					}
				}
			}

#if DEBUG
			System.Diagnostics.Debug.WriteLine (response);
#endif

			return response;
		}

		string DoPostRequest (string url, byte[] data)
		{
			var req = (HttpWebRequest)WebRequest.Create(url);
			req.ContentType = "text/xml; charset=utf-8";
			req.Method = "POST";
			req.ContentLength = data.Length;

			using(var stream = req.GetRequestStream ()) {
				stream.Write (data, 0, data.Length);
			}

			using(var resp = req.GetResponse ()) {
				using(var stream = resp.GetResponseStream ()) {
					using(var sr = new StreamReader (stream, Encoding.UTF8)) {
						return sr.ReadToEnd ();
					}
				}
			}
		}

	}
}
