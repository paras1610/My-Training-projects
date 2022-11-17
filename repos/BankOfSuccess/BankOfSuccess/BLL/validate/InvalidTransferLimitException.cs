using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.BLL.validate
{
    internal class InvalidTransferLimitException : ApplicationException
    {
        public InvalidTransferLimitException(string msg):base(msg)
        {

        }
    }
}
