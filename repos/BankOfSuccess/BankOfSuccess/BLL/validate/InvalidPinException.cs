using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.BLL.validate
{
    internal class InvalidPinException:ApplicationException
    {
         public InvalidPinException(string msg=null):base(msg)
        {

        }
    }
}
