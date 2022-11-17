using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.BLL.validate
{
    public class InvalidRegistrationNumberException : ApplicationException
    {
        public InvalidRegistrationNumberException(string msg=null) : base(msg)
        { 
        }
    }
}
