using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class WrongPasswordException : Exception
    {
        public WrongPasswordException() : base() { }
        

        public WrongPasswordException(string? excetionMessage) : base(excetionMessage) {  }
        
    }
}
