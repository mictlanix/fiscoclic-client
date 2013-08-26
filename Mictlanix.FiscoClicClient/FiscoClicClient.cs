//
// FiscoClicClient.cs
//
// Author:
//       Eddy Zavaleta <eddy@mictlanix.com>
//
// Copyright (c) 2013 Eddy Zavaleta, Mictlanix, and contributors.
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
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Xml;
using Mictlanix.FiscoClic.Client.Internals;
using Mictlanix.CFDv32;

namespace Mictlanix.FiscoClic.Client
{
	public class FiscoClicClient
	{
		public static string PRODUCTION_URL = @"https://www.fiscoclic.mx/factura/WSEntityServices/timbre/TimbraWS";
		private static readonly BasicHttpBinding binding = new BasicHttpBinding (BasicHttpSecurityMode.Transport) {
			MaxBufferPoolSize = int.MaxValue,
			MaxReceivedMessageSize = int.MaxValue,
			ReaderQuotas = new XmlDictionaryReaderQuotas
			{
				MaxDepth = int.MaxValue,
				MaxStringContentLength = int.MaxValue,
				MaxArrayLength = int.MaxValue,
				MaxBytesPerRead = int.MaxValue,
				MaxNameTableCharCount = int.MaxValue,
			}
		};

		private string url;

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

		protected string Username { get; set; }
		protected string Password { get; set; }
		protected BasicHttpBinding Binding { get { return binding; } }
		protected EndpointAddress Address { get; private set; }
		public string Url {
			get { return url;}
			set {
				if (url == value)
					return;

				url = value;
				Address = new EndpointAddress (url);
			}
		}

		public TimbreFiscalDigital Stamp (Comprobante cfd)
		{
			string tfd_str;

			//try {
				var ws = new cfdiServiceInterfaceClient (Binding, Address);
				//tfd_str = ws.timbraCFDIXML (cfd.ToXmlString (), Username, Password);
				tfd_str = ws.timbraCFDIXMLTest (cfd.ToXmlString (), Username, Password);
				ws.Close ();
			//} catch(FaultException<FiscoClicException> ex) {
			//	throw new FiscoClicException (ex.Detail.Code, ex.Reason.ToString ());
			//} catch (Exception ex) {
			//	throw new FiscoClicException (ex.Message);
			//}

			if (string.IsNullOrEmpty (tfd_str)) {
				throw new FiscoClicException ("Bad response format.");
			}

			var tfd = TimbreFiscalDigital.FromXml (tfd_str);

			if (tfd == null) {
				throw new FiscoClicException ("Bad response format.");
			}

			return new TimbreFiscalDigital {
				UUID = tfd.UUID,
				FechaTimbrado = tfd.FechaTimbrado,
				selloCFD = tfd.selloCFD,
				noCertificadoSAT = tfd.noCertificadoSAT,
				selloSAT = tfd.selloSAT
			};
		}
	}
}
