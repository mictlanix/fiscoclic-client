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

		public FiscoClicException (string code, string message) : base (message)
		{
			Code = code;
        }

		public string Code { get; private set; }
    }
}
