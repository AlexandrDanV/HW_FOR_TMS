using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation.InvalidExceptions
{
    internal class ComparePasswordExceptions : Exception
    {
        public ComparePasswordExceptions() { }
        public ComparePasswordExceptions(string message) : base(message) { }
    }
}
