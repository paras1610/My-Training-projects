using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.Entities
{
    internal class CurrentAccounts:Accounts
    {
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public string RegisterationNumber { get; set; }
        public CurrentAccounts(string companyName, string website, string registerationNumber, String name, int balance,int pin,Privilege privilege) :base(name,balance,pin,privilege)
        {
            CompanyName = companyName;
            Website = website;
            RegisterationNumber = registerationNumber;

        }
    }
}
