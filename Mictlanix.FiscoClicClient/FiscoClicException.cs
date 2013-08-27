using System;

namespace Mictlanix.FiscoClic.Client
{
	[Serializable]
	public class FiscoClicException : Exception
    {
		public FiscoClicException ()
        {
        }

		public FiscoClicException (string message) : base (message)
        {
        }
		
		internal FiscoClicException (string message, Internals.FiscoClicException ex) : base (message)
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
    }
}
