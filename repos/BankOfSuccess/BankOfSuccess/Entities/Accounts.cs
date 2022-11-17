using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.Entities
{
    internal class Accounts
    {
        static int count = 1000;

        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public bool IsActive { get; set; }
        public Privilege privilege{get; set;}
        public int PinNumber { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime ClosedDate { get; set; }

        public Accounts(String name, int balance,int pin, Privilege privilege)
        {
            AccountNumber = count++;
            Name = name;
            Balance = balance;
            IsActive = true;
            ActivationDate = DateTime.Now;
            PinNumber = pin;
            this.privilege = privilege;
        }
        public Accounts() { }
    }
    public enum Privilege
    {
        SILVER,
        GOLD,
        PREMIUM

    }
}
