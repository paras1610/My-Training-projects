using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.BLL.validate
{
   public class AgeCheck
    {
        
        public bool Validate(DateOnly Dob)
        {
            int m = Dob.Month;
            int y = Dob.Year;
            DateTime currentdate =DateTime.Now;
            if(Dob.Day > currentdate.Day)
            {
                m -= 1;
            }
            if(m > currentdate.Month)
            {
                y -= 1;
            }
            int age = currentdate.Year - y;


            if (age < 18)
                throw new InvalidAgeException("Invalid age !  :below 18");

            return true;
        }
    }
}
