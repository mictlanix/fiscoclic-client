//
// TestProgram.cs
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
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Mictlanix.CFDv32;
using Mictlanix.FiscoClic.Client;

namespace Tests {
	class TestProgram {
		const string CSD_CERTIFICATE_FILE = "CSD01_AAA010101AAA.cer";
		const string CSD_PRIVATE_KEY_FILE = "CSD01_AAA010101AAA.key";
		const string CSD_PRIVATE_KEY_PWD = "12345678a";
		const string USERNAME = "AAA111111ZZZ";
		const string PASSWORD = "TeStInGfIsCoClIc2012Ws";

		static DateTime NOW = DateTime.Now;
		static DateTime TEST_DATE = new DateTime (NOW.Year, NOW.Month, NOW.Day,
												  NOW.Hour, NOW.Minute, NOW.Second, DateTimeKind.Unspecified);
		//static DateTime TEST_DATE = new DateTime (2016, 02, 09, 10, 11, 12, DateTimeKind.Unspecified);

		static void Main(string[] args)
		{
			StampTest (USERNAME, PASSWORD);
			CancelTest (USERNAME, PASSWORD);
		}

		static void StampTest (string username, string password)
		{
			var cfd = CreateCFD ();
			var cli = new FiscoClicClient (username, password);

			AddItems (cfd, "Product", 3);
			cfd.Sign (File.ReadAllBytes (CSD_PRIVATE_KEY_FILE), Encoding.UTF8.GetBytes(CSD_PRIVATE_KEY_PWD));

			var tfd = cli.Stamp (cfd);
			Console.WriteLine (tfd.ToXmlString ());

			cfd.Complemento = new List<object>();
			cfd.Complemento.Add (tfd);

			Console.WriteLine (cfd.ToXmlString ());
			Console.WriteLine (cfd.ToString ());
		}

		static void CancelTest (string username, string password)
		{
			var cli = new FiscoClicClient (username, password);
			var issuer = "AAA010101AAA";
			var uuid = "FD94ED4E-7E57-46FE-8FBD-D400A1FAF7FA";

			if (cli.Cancel (issuer, uuid)) {
				Console.WriteLine ("Cancel Test: Success");
			} else  {
				Console.WriteLine ("Cancel Test: Fail");
			}
		}

		#region Helper Functions

		static Comprobante CreateCFD()
		{
			var cfd = new Comprobante
			{
				tipoDeComprobante = ComprobanteTipoDeComprobante.ingreso,
				serie = "A",
				folio = "1",
				fecha = TEST_DATE,
				LugarExpedicion = "México, DF",
				metodoDePago = "Efectivo",
				formaDePago = "PAGO EN UNA SOLA EXHIBICION",
				TipoCambio = (1m).ToString(),
				Moneda = "MXN",
				noCertificado = "20001000000200001428",
				certificado = Convert.ToBase64String (File.ReadAllBytes (CSD_CERTIFICATE_FILE)),
				Emisor = new ComprobanteEmisor
				{
					rfc = "AAA010101AAA",
					nombre = "ACCEM SERVICIOS EMPRESARIALES SC",
					RegimenFiscal = new ComprobanteEmisorRegimenFiscal[] {
						new ComprobanteEmisorRegimenFiscal {
							Regimen = "Régimen General de Ley Personas Morales"
						}
					},
				},
				Receptor = new ComprobanteReceptor
				{
					rfc = "XAXX010101000",
					nombre = "EMPRESA DEMO SC"
				},
				Impuestos = new ComprobanteImpuestos()
			};

			return cfd;
		}

		static void AddItem (Comprobante cfd, string code, string name, decimal qty, decimal amount)
		{
			int count = 1;

			if (cfd.Conceptos == null) {
				cfd.Conceptos = new ComprobanteConcepto [count];
			} else {
				count = cfd.Conceptos.Length + 1;
				var items = cfd.Conceptos;
				Array.Resize (ref items, count);
				cfd.Conceptos = items;
			}

			cfd.Conceptos[count-1] = new ComprobanteConcepto {
				cantidad = qty,
				unidad = "No Aplica",
				noIdentificacion = code,
				descripcion = name,
				valorUnitario = amount,
				importe = Math.Round(qty * amount, 2)
			};

			cfd.subTotal = cfd.Conceptos.Sum (x => x.importe);
			cfd.total = Math.Round (cfd.subTotal * 1.16m, 2);

			cfd.Impuestos.Traslados = new ComprobanteImpuestosTraslado[] {
				new ComprobanteImpuestosTraslado {
					impuesto = ComprobanteImpuestosTrasladoImpuesto.IVA,
					importe = cfd.total - cfd.subTotal,
					tasa = 16
				}
			};
		}

		static void AddItems (Comprobante cfd, string prefix, int count)
		{
			var sum = 0m;

			cfd.Conceptos = new ComprobanteConcepto[count];

			for(int i = 1; i <= count; i++) {
				cfd.Conceptos[i-1] = new ComprobanteConcepto {
					cantidad = i,
					unidad = "No Aplica",
					noIdentificacion = string.Format("P{0:D4}", i),
					descripcion = string.Format("{0} {1:D4}", prefix, i),
					valorUnitario = 5m * i,
					importe = 5m * i * i
				};
				sum += 5m * i * i;
			}

			cfd.subTotal = sum;
			cfd.total = Math.Round(sum * 1.16m, 2);

			cfd.Impuestos.Traslados = new ComprobanteImpuestosTraslado[] {
				new ComprobanteImpuestosTraslado {
					impuesto = ComprobanteImpuestosTrasladoImpuesto.IVA,
					importe = cfd.total - cfd.subTotal,
					tasa = 16
				}
			};
		}

		#endregion
	}
}
