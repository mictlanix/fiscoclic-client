#if !DEBUG
namespace Mictlanix.FiscoClic.Client.Internals {
	internal class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write11_Envelope(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteEmptyTag(@"Envelope", @"http://schemas.xmlsoap.org/soap/envelope/");
                return;
            }
            TopLevelElement();
            Write9_SoapEnvelope(@"Envelope", @"http://schemas.xmlsoap.org/soap/envelope/", ((global::Mictlanix.FiscoClic.Client.Internals.SoapEnvelope)o), false, false);
        }

        public void Write12_Fault(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteEmptyTag(@"Fault", @"http://schemas.xmlsoap.org/soap/envelope/");
                return;
            }
            TopLevelElement();
            Write8_SoapFault(@"Fault", @"http://schemas.xmlsoap.org/soap/envelope/", ((global::Mictlanix.FiscoClic.Client.Internals.SoapFault)o), false, false);
        }

        public void Write13_SoapFaultDetail(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"SoapFaultDetail", @"");
                return;
            }
            TopLevelElement();
            Write10_SoapFaultDetail(@"SoapFaultDetail", @"", ((global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail)o), true, false);
        }

        public void Write14_timbraCFDIXML(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"timbraCFDIXML", @"http://srv.soap.factura.sit.mx.com");
                return;
            }
            TopLevelElement();
            Write2_TimbraCFDIXML(@"timbraCFDIXML", @"http://srv.soap.factura.sit.mx.com", ((global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML)o), true, false);
        }

        public void Write15_timbraCFDIXMLResponse(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"timbraCFDIXMLResponse", @"http://srv.soap.factura.sit.mx.com");
                return;
            }
            TopLevelElement();
            Write3_TimbraCFDIXMLResponse(@"timbraCFDIXMLResponse", @"http://srv.soap.factura.sit.mx.com", ((global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse)o), true, false);
        }

        public void Write16_FiscoClicException(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteEmptyTag(@"FiscoClicException", @"http://srv.soap.factura.sit.mx.com");
                return;
            }
            TopLevelElement();
            Write6_FiscoClicException(@"FiscoClicException", @"http://srv.soap.factura.sit.mx.com", ((global::Mictlanix.FiscoClic.Client.Internals.FiscoClicException)o), false, false);
        }

        public void Write17_cancelaCFDI(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"cancelaCFDI", @"http://srv.soap.factura.sit.mx.com");
                return;
            }
            TopLevelElement();
            Write4_CancelaCFDI(@"cancelaCFDI", @"http://srv.soap.factura.sit.mx.com", ((global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDI)o), true, false);
        }

        public void Write18_cancelaCFDIResponse(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"cancelaCFDIResponse", @"http://srv.soap.factura.sit.mx.com");
                return;
            }
            TopLevelElement();
            Write5_CancelaCFDIResponse(@"cancelaCFDIResponse", @"http://srv.soap.factura.sit.mx.com", ((global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse)o), true, false);
        }

        void Write5_CancelaCFDIResponse(string n, string ns, global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Xmlns);
            if (needType) WriteXsiType(@"cancelaCFDIResponse", @"http://srv.soap.factura.sit.mx.com");
            WriteElementString(@"return", @"", ((global::System.String)o.@Return));
            WriteEndElement(o);
        }

        void Write4_CancelaCFDI(string n, string ns, global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDI o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDI)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Xmlns);
            if (needType) WriteXsiType(@"cancelaCFDI", @"http://srv.soap.factura.sit.mx.com");
            WriteElementString(@"uuid", @"http://srv.soap.factura.sit.mx.com", ((global::System.String)o.@uuid));
            WriteElementString(@"rfcEmisor", @"http://srv.soap.factura.sit.mx.com", ((global::System.String)o.@rfcEmisor));
            WriteElementString(@"user", @"http://srv.soap.factura.sit.mx.com", ((global::System.String)o.@user));
            WriteElementString(@"pass", @"http://srv.soap.factura.sit.mx.com", ((global::System.String)o.@pass));
            WriteEndElement(o);
        }

        void Write6_FiscoClicException(string n, string ns, global::Mictlanix.FiscoClic.Client.Internals.FiscoClicException o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Mictlanix.FiscoClic.Client.Internals.FiscoClicException)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Xmlns);
            if (needType) WriteXsiType(@"FiscoClicException", @"http://srv.soap.factura.sit.mx.com");
            WriteElementString(@"codigo", @"", ((global::System.String)o.@Code));
            WriteElementString(@"message", @"", ((global::System.String)o.@Message));
            WriteElementString(@"campo", @"", ((global::System.String)o.@FieldName));
            WriteElementString(@"servicio", @"", ((global::System.String)o.@ServiceName));
            WriteEndElement(o);
        }

        void Write3_TimbraCFDIXMLResponse(string n, string ns, global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Xmlns);
            if (needType) WriteXsiType(@"timbraCFDIXMLResponse", @"http://srv.soap.factura.sit.mx.com");
            WriteElementString(@"return", @"", ((global::System.String)o.@Return));
            WriteEndElement(o);
        }

        void Write2_TimbraCFDIXML(string n, string ns, global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Xmlns);
            if (needType) WriteXsiType(@"timbraCFDIXML", @"http://srv.soap.factura.sit.mx.com");
            WriteElementString(@"cfdi", @"http://srv.soap.factura.sit.mx.com", ((global::System.String)o.@cfdi));
            WriteElementString(@"user", @"http://srv.soap.factura.sit.mx.com", ((global::System.String)o.@user));
            WriteElementString(@"pass", @"http://srv.soap.factura.sit.mx.com", ((global::System.String)o.@pass));
            WriteEndElement(o);
        }

        void Write10_SoapFaultDetail(string n, string ns, global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"SoapFaultDetail", @"");
            Write6_FiscoClicException(@"FiscoClicException", @"http://srv.soap.factura.sit.mx.com", ((global::Mictlanix.FiscoClic.Client.Internals.FiscoClicException)o.@Exception), false, false);
            WriteEndElement(o);
        }

        void Write8_SoapFault(string n, string ns, global::Mictlanix.FiscoClic.Client.Internals.SoapFault o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Mictlanix.FiscoClic.Client.Internals.SoapFault)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Xmlns);
            if (needType) WriteXsiType(@"Fault", @"http://schemas.xmlsoap.org/soap/envelope/");
            WriteElementString(@"faultcode", @"", ((global::System.String)o.@FaultCode));
            WriteElementString(@"faultstring", @"", ((global::System.String)o.@FaultString));
            Write7_SoapFaultDetail(@"detail", @"", ((global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail)o.@Detail), false, false);
            WriteEndElement(o);
        }

        void Write7_SoapFaultDetail(string n, string ns, global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"SoapFaultDetail", @"http://schemas.xmlsoap.org/soap/envelope/");
            Write6_FiscoClicException(@"FiscoClicException", @"http://srv.soap.factura.sit.mx.com", ((global::Mictlanix.FiscoClic.Client.Internals.FiscoClicException)o.@Exception), false, false);
            WriteEndElement(o);
        }

        void Write9_SoapEnvelope(string n, string ns, global::Mictlanix.FiscoClic.Client.Internals.SoapEnvelope o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Mictlanix.FiscoClic.Client.Internals.SoapEnvelope)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.@Xmlns);
            if (needType) WriteXsiType(@"Envelope", @"http://schemas.xmlsoap.org/soap/envelope/");
            {
                global::System.Object[] a = (global::System.Object[])((global::System.Object[])o.@Body);
                if (a != null){
                    WriteStartElement(@"Body", @"http://schemas.xmlsoap.org/soap/envelope/", null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Object ai = (global::System.Object)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::Mictlanix.FiscoClic.Client.Internals.SoapFault) {
                                Write8_SoapFault(@"Fault", @"http://schemas.xmlsoap.org/soap/envelope/", ((global::Mictlanix.FiscoClic.Client.Internals.SoapFault)ai), true, false);
                            }
                            else if (ai is global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse) {
                                Write3_TimbraCFDIXMLResponse(@"timbraCFDIXMLResponse", @"http://srv.soap.factura.sit.mx.com", ((global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse)ai), true, false);
                            }
                            else if (ai is global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML) {
                                Write2_TimbraCFDIXML(@"timbraCFDIXML", @"http://srv.soap.factura.sit.mx.com", ((global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML)ai), true, false);
                            }
                            else if (ai is global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse) {
                                Write5_CancelaCFDIResponse(@"cancelaCFDIResponse", @"http://srv.soap.factura.sit.mx.com", ((global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse)ai), true, false);
                            }
                            else if (ai is global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDI) {
                                Write4_CancelaCFDI(@"cancelaCFDI", @"http://srv.soap.factura.sit.mx.com", ((global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDI)ai), true, false);
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

	internal class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read11_Envelope() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_Envelope && (object) Reader.NamespaceURI == (object)id2_Item)) {
                    o = Read9_SoapEnvelope(false, true);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, @"http://schemas.xmlsoap.org/soap/envelope/:Envelope");
            }
            return (object)o;
        }

        public object Read12_Fault() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id3_Fault && (object) Reader.NamespaceURI == (object)id2_Item)) {
                    o = Read8_SoapFault(false, true);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, @"http://schemas.xmlsoap.org/soap/envelope/:Fault");
            }
            return (object)o;
        }

        public object Read13_SoapFaultDetail() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id4_SoapFaultDetail && (object) Reader.NamespaceURI == (object)id5_Item)) {
                    o = Read10_SoapFaultDetail(true, true);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, @":SoapFaultDetail");
            }
            return (object)o;
        }

        public object Read14_timbraCFDIXML() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id6_timbraCFDIXML && (object) Reader.NamespaceURI == (object)id7_Item)) {
                    o = Read2_TimbraCFDIXML(true, true);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, @"http://srv.soap.factura.sit.mx.com:timbraCFDIXML");
            }
            return (object)o;
        }

        public object Read15_timbraCFDIXMLResponse() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id8_timbraCFDIXMLResponse && (object) Reader.NamespaceURI == (object)id7_Item)) {
                    o = Read3_TimbraCFDIXMLResponse(true, true);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, @"http://srv.soap.factura.sit.mx.com:timbraCFDIXMLResponse");
            }
            return (object)o;
        }

        public object Read16_FiscoClicException() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id9_FiscoClicException && (object) Reader.NamespaceURI == (object)id7_Item)) {
                    o = Read6_FiscoClicException(false, true);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, @"http://srv.soap.factura.sit.mx.com:FiscoClicException");
            }
            return (object)o;
        }

        public object Read17_cancelaCFDI() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id10_cancelaCFDI && (object) Reader.NamespaceURI == (object)id7_Item)) {
                    o = Read4_CancelaCFDI(true, true);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, @"http://srv.soap.factura.sit.mx.com:cancelaCFDI");
            }
            return (object)o;
        }

        public object Read18_cancelaCFDIResponse() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id11_cancelaCFDIResponse && (object) Reader.NamespaceURI == (object)id7_Item)) {
                    o = Read5_CancelaCFDIResponse(true, true);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, @"http://srv.soap.factura.sit.mx.com:cancelaCFDIResponse");
            }
            return (object)o;
        }

        global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse Read5_CancelaCFDIResponse(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_cancelaCFDIResponse && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse o;
            o = new global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Xmlns == null) o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id12_return && (object) Reader.NamespaceURI == (object)id5_Item)) {
                        {
                            o.@Return = Reader.ReadElementString();
                        }
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)o, @":return");
                    }
                }
                else {
                    UnknownNode((object)o, @":return");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            ReadEndElement();
            return o;
        }

        global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDI Read4_CancelaCFDI(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_cancelaCFDI && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDI o;
            o = new global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDI();
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Xmlns == null) o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations1 = 0;
            int readerCount1 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id13_uuid && (object) Reader.NamespaceURI == (object)id7_Item)) {
                        {
                            o.@uuid = Reader.ReadElementString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id14_rfcEmisor && (object) Reader.NamespaceURI == (object)id7_Item)) {
                        {
                            o.@rfcEmisor = Reader.ReadElementString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id15_user && (object) Reader.NamespaceURI == (object)id7_Item)) {
                        {
                            o.@user = Reader.ReadElementString();
                        }
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id16_pass && (object) Reader.NamespaceURI == (object)id7_Item)) {
                        {
                            o.@pass = Reader.ReadElementString();
                        }
                        paramsRead[3] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://srv.soap.factura.sit.mx.com:uuid, http://srv.soap.factura.sit.mx.com:rfcEmisor, http://srv.soap.factura.sit.mx.com:user, http://srv.soap.factura.sit.mx.com:pass");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://srv.soap.factura.sit.mx.com:uuid, http://srv.soap.factura.sit.mx.com:rfcEmisor, http://srv.soap.factura.sit.mx.com:user, http://srv.soap.factura.sit.mx.com:pass");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations1, ref readerCount1);
            }
            ReadEndElement();
            return o;
        }

        global::Mictlanix.FiscoClic.Client.Internals.FiscoClicException Read6_FiscoClicException(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_FiscoClicException && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::Mictlanix.FiscoClic.Client.Internals.FiscoClicException o;
            o = new global::Mictlanix.FiscoClic.Client.Internals.FiscoClicException();
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Xmlns == null) o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations2 = 0;
            int readerCount2 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id17_codigo && (object) Reader.NamespaceURI == (object)id5_Item)) {
                        {
                            o.@Code = Reader.ReadElementString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id18_message && (object) Reader.NamespaceURI == (object)id5_Item)) {
                        {
                            o.@Message = Reader.ReadElementString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id19_campo && (object) Reader.NamespaceURI == (object)id5_Item)) {
                        {
                            o.@FieldName = Reader.ReadElementString();
                        }
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id20_servicio && (object) Reader.NamespaceURI == (object)id5_Item)) {
                        {
                            o.@ServiceName = Reader.ReadElementString();
                        }
                        paramsRead[3] = true;
                    }
                    else {
                        UnknownNode((object)o, @":codigo, :message, :campo, :servicio");
                    }
                }
                else {
                    UnknownNode((object)o, @":codigo, :message, :campo, :servicio");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations2, ref readerCount2);
            }
            ReadEndElement();
            return o;
        }

        global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse Read3_TimbraCFDIXMLResponse(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_timbraCFDIXMLResponse && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse o;
            o = new global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Xmlns == null) o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations3 = 0;
            int readerCount3 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id12_return && (object) Reader.NamespaceURI == (object)id5_Item)) {
                        {
                            o.@Return = Reader.ReadElementString();
                        }
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)o, @":return");
                    }
                }
                else {
                    UnknownNode((object)o, @":return");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations3, ref readerCount3);
            }
            ReadEndElement();
            return o;
        }

        global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML Read2_TimbraCFDIXML(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_timbraCFDIXML && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id7_Item)) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML o;
            o = new global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Xmlns == null) o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations4 = 0;
            int readerCount4 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id21_cfdi && (object) Reader.NamespaceURI == (object)id7_Item)) {
                        {
                            o.@cfdi = Reader.ReadElementString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id15_user && (object) Reader.NamespaceURI == (object)id7_Item)) {
                        {
                            o.@user = Reader.ReadElementString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id16_pass && (object) Reader.NamespaceURI == (object)id7_Item)) {
                        {
                            o.@pass = Reader.ReadElementString();
                        }
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://srv.soap.factura.sit.mx.com:cfdi, http://srv.soap.factura.sit.mx.com:user, http://srv.soap.factura.sit.mx.com:pass");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://srv.soap.factura.sit.mx.com:cfdi, http://srv.soap.factura.sit.mx.com:user, http://srv.soap.factura.sit.mx.com:pass");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations4, ref readerCount4);
            }
            ReadEndElement();
            return o;
        }

        global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail Read10_SoapFaultDetail(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_SoapFaultDetail && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id5_Item)) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail o;
            o = new global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations5 = 0;
            int readerCount5 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id9_FiscoClicException && (object) Reader.NamespaceURI == (object)id7_Item)) {
                        o.@Exception = Read6_FiscoClicException(false, true);
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://srv.soap.factura.sit.mx.com:FiscoClicException");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://srv.soap.factura.sit.mx.com:FiscoClicException");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations5, ref readerCount5);
            }
            ReadEndElement();
            return o;
        }

        global::Mictlanix.FiscoClic.Client.Internals.SoapFault Read8_SoapFault(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_Fault && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::Mictlanix.FiscoClic.Client.Internals.SoapFault o;
            o = new global::Mictlanix.FiscoClic.Client.Internals.SoapFault();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Xmlns == null) o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations6 = 0;
            int readerCount6 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id22_faultcode && (object) Reader.NamespaceURI == (object)id5_Item)) {
                        {
                            o.@FaultCode = Reader.ReadElementString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id23_faultstring && (object) Reader.NamespaceURI == (object)id5_Item)) {
                        {
                            o.@FaultString = Reader.ReadElementString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id24_detail && (object) Reader.NamespaceURI == (object)id5_Item)) {
                        o.@Detail = Read7_SoapFaultDetail(false, true);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @":faultcode, :faultstring, :detail");
                    }
                }
                else {
                    UnknownNode((object)o, @":faultcode, :faultstring, :detail");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations6, ref readerCount6);
            }
            ReadEndElement();
            return o;
        }

        global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail Read7_SoapFaultDetail(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_SoapFaultDetail && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail o;
            o = new global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations7 = 0;
            int readerCount7 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id9_FiscoClicException && (object) Reader.NamespaceURI == (object)id7_Item)) {
                        o.@Exception = Read6_FiscoClicException(false, true);
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)o, @"http://srv.soap.factura.sit.mx.com:FiscoClicException");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://srv.soap.factura.sit.mx.com:FiscoClicException");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations7, ref readerCount7);
            }
            ReadEndElement();
            return o;
        }

        global::Mictlanix.FiscoClic.Client.Internals.SoapEnvelope Read9_SoapEnvelope(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_Envelope && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::Mictlanix.FiscoClic.Client.Internals.SoapEnvelope o;
            o = new global::Mictlanix.FiscoClic.Client.Internals.SoapEnvelope();
//            global::System.Object[] a_0 = null;
//            int ca_0 = 0;
//            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (IsXmlnsAttribute(Reader.Name)) {
                    if (o.@Xmlns == null) o.@Xmlns = new global::System.Xml.Serialization.XmlSerializerNamespaces();
                    ((global::System.Xml.Serialization.XmlSerializerNamespaces)o.@Xmlns).Add(Reader.Name.Length == 5 ? "" : Reader.LocalName, Reader.Value);
                }
                else {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations8 = 0;
            int readerCount8 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (((object) Reader.LocalName == (object)id25_Body && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        if (!ReadNull()) {
                            global::System.Object[] a_0_0 = null;
                            int ca_0_0 = 0;
                            if ((Reader.IsEmptyElement)) {
                                Reader.Skip();
                            }
                            else {
                                Reader.ReadStartElement();
                                Reader.MoveToContent();
                                int whileIterations9 = 0;
                                int readerCount9 = ReaderCount;
                                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                        if (((object) Reader.LocalName == (object)id3_Fault && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                            a_0_0 = (global::System.Object[])EnsureArrayIndex(a_0_0, ca_0_0, typeof(global::System.Object));a_0_0[ca_0_0++] = Read8_SoapFault(true, true);
                                        }
                                        else if (((object) Reader.LocalName == (object)id8_timbraCFDIXMLResponse && (object) Reader.NamespaceURI == (object)id7_Item)) {
                                            a_0_0 = (global::System.Object[])EnsureArrayIndex(a_0_0, ca_0_0, typeof(global::System.Object));a_0_0[ca_0_0++] = Read3_TimbraCFDIXMLResponse(true, true);
                                        }
                                        else if (((object) Reader.LocalName == (object)id6_timbraCFDIXML && (object) Reader.NamespaceURI == (object)id7_Item)) {
                                            a_0_0 = (global::System.Object[])EnsureArrayIndex(a_0_0, ca_0_0, typeof(global::System.Object));a_0_0[ca_0_0++] = Read2_TimbraCFDIXML(true, true);
                                        }
                                        else if (((object) Reader.LocalName == (object)id11_cancelaCFDIResponse && (object) Reader.NamespaceURI == (object)id7_Item)) {
                                            a_0_0 = (global::System.Object[])EnsureArrayIndex(a_0_0, ca_0_0, typeof(global::System.Object));a_0_0[ca_0_0++] = Read5_CancelaCFDIResponse(true, true);
                                        }
                                        else if (((object) Reader.LocalName == (object)id10_cancelaCFDI && (object) Reader.NamespaceURI == (object)id7_Item)) {
                                            a_0_0 = (global::System.Object[])EnsureArrayIndex(a_0_0, ca_0_0, typeof(global::System.Object));a_0_0[ca_0_0++] = Read4_CancelaCFDI(true, true);
                                        }
                                        else {
                                            UnknownNode(null, @"http://schemas.xmlsoap.org/soap/envelope/:Fault, http://srv.soap.factura.sit.mx.com:timbraCFDIXMLResponse, http://srv.soap.factura.sit.mx.com:timbraCFDIXML, http://srv.soap.factura.sit.mx.com:cancelaCFDIResponse, http://srv.soap.factura.sit.mx.com:cancelaCFDI");
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @"http://schemas.xmlsoap.org/soap/envelope/:Fault, http://srv.soap.factura.sit.mx.com:timbraCFDIXMLResponse, http://srv.soap.factura.sit.mx.com:timbraCFDIXML, http://srv.soap.factura.sit.mx.com:cancelaCFDIResponse, http://srv.soap.factura.sit.mx.com:cancelaCFDI");
                                    }
                                    Reader.MoveToContent();
                                    CheckReaderCount(ref whileIterations9, ref readerCount9);
                                }
                            ReadEndElement();
                            }
                            o.@Body = (global::System.Object[])ShrinkArray(a_0_0, ca_0_0, typeof(global::System.Object), false);
                        }
                    }
                    else {
                        UnknownNode((object)o, @"http://schemas.xmlsoap.org/soap/envelope/:Body");
                    }
                }
                else {
                    UnknownNode((object)o, @"http://schemas.xmlsoap.org/soap/envelope/:Body");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations8, ref readerCount8);
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id3_Fault;
        string id23_faultstring;
        string id24_detail;
        string id10_cancelaCFDI;
        string id19_campo;
        string id6_timbraCFDIXML;
        string id17_codigo;
        string id16_pass;
        string id7_Item;
        string id1_Envelope;
        string id25_Body;
        string id14_rfcEmisor;
        string id13_uuid;
        string id12_return;
        string id20_servicio;
        string id18_message;
        string id8_timbraCFDIXMLResponse;
        string id11_cancelaCFDIResponse;
        string id5_Item;
        string id21_cfdi;
        string id9_FiscoClicException;
        string id22_faultcode;
        string id15_user;
        string id4_SoapFaultDetail;
        string id2_Item;

        protected override void InitIDs() {
            id3_Fault = Reader.NameTable.Add(@"Fault");
            id23_faultstring = Reader.NameTable.Add(@"faultstring");
            id24_detail = Reader.NameTable.Add(@"detail");
            id10_cancelaCFDI = Reader.NameTable.Add(@"cancelaCFDI");
            id19_campo = Reader.NameTable.Add(@"campo");
            id6_timbraCFDIXML = Reader.NameTable.Add(@"timbraCFDIXML");
            id17_codigo = Reader.NameTable.Add(@"codigo");
            id16_pass = Reader.NameTable.Add(@"pass");
            id7_Item = Reader.NameTable.Add(@"http://srv.soap.factura.sit.mx.com");
            id1_Envelope = Reader.NameTable.Add(@"Envelope");
            id25_Body = Reader.NameTable.Add(@"Body");
            id14_rfcEmisor = Reader.NameTable.Add(@"rfcEmisor");
            id13_uuid = Reader.NameTable.Add(@"uuid");
            id12_return = Reader.NameTable.Add(@"return");
            id20_servicio = Reader.NameTable.Add(@"servicio");
            id18_message = Reader.NameTable.Add(@"message");
            id8_timbraCFDIXMLResponse = Reader.NameTable.Add(@"timbraCFDIXMLResponse");
            id11_cancelaCFDIResponse = Reader.NameTable.Add(@"cancelaCFDIResponse");
            id5_Item = Reader.NameTable.Add(@"");
            id21_cfdi = Reader.NameTable.Add(@"cfdi");
            id9_FiscoClicException = Reader.NameTable.Add(@"FiscoClicException");
            id22_faultcode = Reader.NameTable.Add(@"faultcode");
            id15_user = Reader.NameTable.Add(@"user");
            id4_SoapFaultDetail = Reader.NameTable.Add(@"SoapFaultDetail");
            id2_Item = Reader.NameTable.Add(@"http://schemas.xmlsoap.org/soap/envelope/");
        }
    }

	internal abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

	internal sealed class SoapEnvelopeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Envelope", @"http://schemas.xmlsoap.org/soap/envelope/");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write11_Envelope(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read11_Envelope();
        }
    }

	internal sealed class SoapFaultSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Fault", @"http://schemas.xmlsoap.org/soap/envelope/");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write12_Fault(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read12_Fault();
        }
    }

	internal sealed class SoapFaultDetailSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"SoapFaultDetail", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write13_SoapFaultDetail(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read13_SoapFaultDetail();
        }
    }

	internal sealed class TimbraCFDIXMLSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"timbraCFDIXML", @"http://srv.soap.factura.sit.mx.com");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write14_timbraCFDIXML(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read14_timbraCFDIXML();
        }
    }

	internal sealed class TimbraCFDIXMLResponseSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"timbraCFDIXMLResponse", @"http://srv.soap.factura.sit.mx.com");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write15_timbraCFDIXMLResponse(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read15_timbraCFDIXMLResponse();
        }
    }

	internal sealed class FiscoClicExceptionSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"FiscoClicException", @"http://srv.soap.factura.sit.mx.com");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write16_FiscoClicException(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read16_FiscoClicException();
        }
    }

	internal sealed class CancelaCFDISerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"cancelaCFDI", @"http://srv.soap.factura.sit.mx.com");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write17_cancelaCFDI(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read17_cancelaCFDI();
        }
    }

	internal sealed class CancelaCFDIResponseSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"cancelaCFDIResponse", @"http://srv.soap.factura.sit.mx.com");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write18_cancelaCFDIResponse(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read18_cancelaCFDIResponse();
        }
    }

	internal class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System.Collections.Hashtable readMethods = null;
        public override System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.SoapEnvelope:http://schemas.xmlsoap.org/soap/envelope/:Envelope:False:"] = @"Read11_Envelope";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.SoapFault:http://schemas.xmlsoap.org/soap/envelope/:Fault:False:"] = @"Read12_Fault";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail::"] = @"Read13_SoapFaultDetail";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML:http://srv.soap.factura.sit.mx.com:timbraCFDIXML:False:"] = @"Read14_timbraCFDIXML";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse:http://srv.soap.factura.sit.mx.com:timbraCFDIXMLResponse:False:"] = @"Read15_timbraCFDIXMLResponse";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.FiscoClicException:http://srv.soap.factura.sit.mx.com:FiscoClicException:False:"] = @"Read16_FiscoClicException";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.CancelaCFDI:http://srv.soap.factura.sit.mx.com:cancelaCFDI:False:"] = @"Read17_cancelaCFDI";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse:http://srv.soap.factura.sit.mx.com:cancelaCFDIResponse:False:"] = @"Read18_cancelaCFDIResponse";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.Hashtable writeMethods = null;
        public override System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.SoapEnvelope:http://schemas.xmlsoap.org/soap/envelope/:Envelope:False:"] = @"Write11_Envelope";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.SoapFault:http://schemas.xmlsoap.org/soap/envelope/:Fault:False:"] = @"Write12_Fault";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail::"] = @"Write13_SoapFaultDetail";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML:http://srv.soap.factura.sit.mx.com:timbraCFDIXML:False:"] = @"Write14_timbraCFDIXML";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse:http://srv.soap.factura.sit.mx.com:timbraCFDIXMLResponse:False:"] = @"Write15_timbraCFDIXMLResponse";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.FiscoClicException:http://srv.soap.factura.sit.mx.com:FiscoClicException:False:"] = @"Write16_FiscoClicException";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.CancelaCFDI:http://srv.soap.factura.sit.mx.com:cancelaCFDI:False:"] = @"Write17_cancelaCFDI";
                    _tmp[@"Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse:http://srv.soap.factura.sit.mx.com:cancelaCFDIResponse:False:"] = @"Write18_cancelaCFDIResponse";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.Hashtable typedSerializers = null;
        public override System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp.Add(@"Mictlanix.FiscoClic.Client.Internals.FiscoClicException:http://srv.soap.factura.sit.mx.com:FiscoClicException:False:", new FiscoClicExceptionSerializer());
                    _tmp.Add(@"Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse:http://srv.soap.factura.sit.mx.com:timbraCFDIXMLResponse:False:", new TimbraCFDIXMLResponseSerializer());
                    _tmp.Add(@"Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML:http://srv.soap.factura.sit.mx.com:timbraCFDIXML:False:", new TimbraCFDIXMLSerializer());
                    _tmp.Add(@"Mictlanix.FiscoClic.Client.Internals.SoapEnvelope:http://schemas.xmlsoap.org/soap/envelope/:Envelope:False:", new SoapEnvelopeSerializer());
                    _tmp.Add(@"Mictlanix.FiscoClic.Client.Internals.SoapFault:http://schemas.xmlsoap.org/soap/envelope/:Fault:False:", new SoapFaultSerializer());
                    _tmp.Add(@"Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse:http://srv.soap.factura.sit.mx.com:cancelaCFDIResponse:False:", new CancelaCFDIResponseSerializer());
                    _tmp.Add(@"Mictlanix.FiscoClic.Client.Internals.CancelaCFDI:http://srv.soap.factura.sit.mx.com:cancelaCFDI:False:", new CancelaCFDISerializer());
                    _tmp.Add(@"Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail::", new SoapFaultDetailSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.SoapEnvelope)) return true;
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.SoapFault)) return true;
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail)) return true;
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML)) return true;
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse)) return true;
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.FiscoClicException)) return true;
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDI)) return true;
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.SoapEnvelope)) return new SoapEnvelopeSerializer();
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.SoapFault)) return new SoapFaultSerializer();
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.SoapFaultDetail)) return new SoapFaultDetailSerializer();
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXML)) return new TimbraCFDIXMLSerializer();
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.TimbraCFDIXMLResponse)) return new TimbraCFDIXMLResponseSerializer();
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.FiscoClicException)) return new FiscoClicExceptionSerializer();
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDI)) return new CancelaCFDISerializer();
            if (type == typeof(global::Mictlanix.FiscoClic.Client.Internals.CancelaCFDIResponse)) return new CancelaCFDIResponseSerializer();
            return null;
        }
    }
}
#endif