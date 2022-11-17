using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.BLL.validate
{
    public class InvalidWithdrawAmountException : ApplicationException
    {
        public InvalidWithdrawAmountException(string msg=null):base(msg)
            {

            }
    }
}
