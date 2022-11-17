using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.Entities
{
    internal class AccountRecords
    {
        
        [Key]
        public int AccountID { get; set; }
        public string AccountType {get; set; }  
        public int AccountNumber { get; set; }
        public string Name { get; set; }

      
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public long PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public string RegisterationNumber { get; set; }
        public int PinNumber { get; set; }
        public int Balance { get; set; }
        public bool IsActive { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime ClosedDate { get; set; }
    }
}
