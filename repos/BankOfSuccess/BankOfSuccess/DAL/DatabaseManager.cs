 using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.DAL
{
    public class DatabaseManager
    {
        public bool  PushAccount(string accounttype,string name,DateOnly dob,string gender,long phnumber,string companyname,string website,string registrationno,int pin,int balance,bool isactive,DateTime actdate)
        {


            return true;
        }
        public bool PopAccount()
        {


            return true;
        }

    }
}
