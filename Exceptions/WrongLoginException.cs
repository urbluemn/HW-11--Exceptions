using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class WrongLoginException : Exception
    {
        public WrongLoginException() : base() { }
       
        public WrongLoginException(string? excetionMessage) : base(excetionMessage) {  }
       
    }
}
