using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation.InvalidExceptions
{
    public class WronLoginException : Exception
    {
        public WronLoginException() { }
        public WronLoginException(string message) : base(message) { }
    }
}
