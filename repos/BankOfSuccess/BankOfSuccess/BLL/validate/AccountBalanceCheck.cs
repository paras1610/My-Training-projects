using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.BLL.validate
{
    internal class AccountBalanceCheck
    {
        public bool validate(int availableamount,int withdrawamount,bool isactive,int accountpin,int userpin)
        {

            if (availableamount<withdrawamount)
                throw new InvalidWithdrawAmountException("Not sufficient funds:   TRY AGAIN!");
            if (isactive == false)
                throw new InvalidClosedAccountException("Account is closed :  CONTACT TO BANK! ");
            if (accountpin != userpin)
                throw new InvalidPinException("Please enter the correct pin:   PIN IS WRONG!");

            return true;
        }
    }
}
