using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.BLL.validate
{
    internal class AccountStatusCheck
    {
        public bool Validate(bool isactive)
        {
            if (isactive == false)
                throw new InvalidClosedAccountException("Account is closed :    CONTACT TO BANK!");

            return true;
        }
    }
}
