//
// RequestTimbradoCFD.cs
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
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Mictlanix.FiscoClic.Client.Internals
{
	[Serializable]
	[XmlType("FiscoClicException", Namespace="http://srv.soap.factura.sit.mx.com")]
	[XmlRoot("FiscoClicException", Namespace="http://srv.soap.factura.sit.mx.com", IsNullable=false)]
	public partial class FiscoClicException
	{
		private string code;
		private string message;
		private string field_name;
		private string service_name;

		[XmlElement("codigo", Namespace="http://srv.soap.factura.sit.mx.com", Form=XmlSchemaForm.Unqualified)]
		public string Code {
			get {
				return this.code;
			}
			set {
				this.code = value;
			}
		}

		[XmlElement("message", Namespace="http://srv.soap.factura.sit.mx.com", Form=XmlSchemaForm.Unqualified)]
		public string Message {
			get {
				return this.message;
			}
			set {
				this.message = value;
			}
		}

		[XmlElement("campo", Namespace="http://srv.soap.factura.sit.mx.com", Form=XmlSchemaForm.Unqualified)]
		public string FieldName {
			get {
				return this.field_name;
			}
			set {
				this.field_name = value;
			}
		}

		[XmlElement("servicio", Namespace="http://srv.soap.factura.sit.mx.com", Form=XmlSchemaForm.Unqualified)]
		public string ServiceName {
			get {
				return this.service_name;
			}
			set {
				this.service_name = value;
			}
		}

		XmlSerializerNamespaces xmlns;

		[XmlNamespaceDeclarations]
		public XmlSerializerNamespaces Xmlns {
			get {
				if (xmlns == null) {
					xmlns = new XmlSerializerNamespaces (new XmlQualifiedName[] {
						new XmlQualifiedName("srv", "http://srv.soap.factura.sit.mx.com")
					});
				}
				
				return xmlns;
			}
			set { xmlns = value; }
		}
	}
}
