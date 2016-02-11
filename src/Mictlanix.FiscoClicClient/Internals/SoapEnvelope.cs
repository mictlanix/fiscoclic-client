//
// SoapEnvelope.cs
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
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Mictlanix.FiscoClic.Client.Internals
{
	[Serializable]
	[XmlType ("Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
	[XmlRoot ("Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
	internal partial class SoapEnvelope
	{
		object[] bodyField;

		[XmlArray ("Body")]
		[XmlArrayItem (typeof(TimbraCFDIXML), Namespace = "http://srv.soap.factura.sit.mx.com")]
		[XmlArrayItem (typeof(TimbraCFDIXMLResponse), Namespace = "http://srv.soap.factura.sit.mx.com")]
		[XmlArrayItem (typeof(CancelaCFDI), Namespace = "http://srv.soap.factura.sit.mx.com")]
		[XmlArrayItem (typeof(CancelaCFDIResponse), Namespace = "http://srv.soap.factura.sit.mx.com")]
		[XmlArrayItem (typeof(SoapFault), Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
		public object[] Body {
			get {
				return this.bodyField;
			}
			set {
				this.bodyField = value;
			}
		}

		XmlSerializerNamespaces xmlns;

		[XmlNamespaceDeclarations]
		public XmlSerializerNamespaces Xmlns {
			get {
				if (xmlns == null) {
					xmlns = new XmlSerializerNamespaces (new XmlQualifiedName[] {
						new XmlQualifiedName ("s", "http://schemas.xmlsoap.org/soap/envelope/"),
						new XmlQualifiedName ("srv", "http://srv.soap.factura.sit.mx.com")
					});
				}
				
				return xmlns;
			}
			set { xmlns = value; }
		}

		public MemoryStream ToXmlStream ()
		{
			return Utils.SerializeToXmlStream (this, Xmlns);
		}

		public byte[] ToXmlBytes ()
		{
			using (var ms = ToXmlStream ()) {
				return ms.ToArray ();
			}
		}

		public string ToXmlString ()
		{
			using (var ms = ToXmlStream ()) {
				return Encoding.UTF8.GetString (ms.ToArray ());
			}
		}

		public static SoapEnvelope FromXml (string xml)
		{
			using (var ms = new MemoryStream (Encoding.UTF8.GetBytes (xml))) {
				return FromXml (ms);
			}
		}

		public static SoapEnvelope FromXml (Stream xml)
		{
			return Utils.DeserializeFromXmlStream<SoapEnvelope> (xml);
		}
	}
}
