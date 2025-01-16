using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation.InvalidExceptions
{
    internal class InvalidParamsExceptions : Exception
    {
        public InvalidParamsExceptions() { }
        public InvalidParamsExceptions(string message) : base(message) { }
    }
}
