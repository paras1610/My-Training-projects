using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMath_library
{
    public class InvalidEvenNumberException : ApplicationException
    {
        public InvalidEvenNumberException(string msg = null) : base(msg)
        { 
        
        }
    }
}
