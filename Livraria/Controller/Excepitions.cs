using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.Exceptions
{
    public class WarningException : Exception
    {
        public WarningException(string msg) : base(msg) { }
    }

    public class InformationException : Exception
    {
        public InformationException(string msg) : base(msg) { }
    }
}
