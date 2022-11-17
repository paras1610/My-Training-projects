using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.BLL.validate
{
    public class RegistrationNumbercheck
    {
        public bool validate(string registration)
        {
            if (registration == null)
                throw new InvalidRegistrationNumberException("Registration Number sholud not be null");

            return true;
        }
    }
}
