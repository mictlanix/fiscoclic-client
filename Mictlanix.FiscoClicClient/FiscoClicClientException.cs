﻿//
// FiscoClicClientException.cs
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
using Mictlanix.CFDLib;

namespace Mictlanix.FiscoClic.Client
{
	[Serializable]
	public class FiscoClicClientException : CFDException
    {
		public FiscoClicClientException ()
        {
        }

		public FiscoClicClientException (string message) : base (message)
        {
        }
		
		public FiscoClicClientException (string message, Exception innerException) : base (message, innerException)
		{
		}

		internal FiscoClicClientException (string message, Internals.FiscoClicException ex) : base (message)
		{
			Code = ex.Code;
			FieldName = ex.FieldName;
			ServiceName = ex.ServiceName;
			Description = ex.Message;
		}

		public string Code { get; private set; }
		public string FieldName { get; private set; }
		public string ServiceName { get; private set; }
		public string Description { get; private set; }

		public override string ToString()
		{
			return string.Format("{0}: {1} (Code: {2}, Service: {3}, Field: {4})",
			                     Message, Description, Code, ServiceName, FieldName);
		}
    }
}
