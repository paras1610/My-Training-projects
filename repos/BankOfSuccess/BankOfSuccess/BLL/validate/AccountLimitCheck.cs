using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankOfSuccess.Entities;

namespace BankOfSuccess.BLL.validate
{
    internal class AccountLimitCheck
    {
        public bool validate(Privilege privilige,int amount)
        {
            if (privilige == Privilege.SILVER && amount>25000)
                throw new InvalidTransferLimitException("Your Account's daily limit is 25000:    PLEASE TRY AGAIN! ");
            if (privilige == Privilege.GOLD && amount > 50000)
                throw new InvalidTransferLimitException("Your Account's daily limit is 50000:    PLEASE TRY AGAIN! ");
            if (privilige == Privilege.PREMIUM && amount > 100000)
                throw new InvalidTransferLimitException("Your Account's daily limit is 100000:    PLEASE TRY AGAIN! ");

            return true;
        }
    }
}
