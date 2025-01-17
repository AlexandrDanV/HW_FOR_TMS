using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation.InvalidExceptions
{
    public class WronPasswordException : Exception
    {
        public WronPasswordException() { }
        public WronPasswordException(string message) : base(message) { }
    }
}
