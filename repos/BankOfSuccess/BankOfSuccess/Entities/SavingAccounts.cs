using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.Entities
{
    internal class SavingAccounts:Accounts
    {
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public long PhoneNumber { get; set; }
        public SavingAccounts(DateOnly dateOfBirth, string gender, long phoneNumber, String name, int balance,int pin,Privilege privilege):base(name,balance,pin,privilege)
        {
            DateOfBirth = dateOfBirth;
            Gender = gender;
            PhoneNumber = phoneNumber;
        }
    }
    
}
