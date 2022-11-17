using BankOfSuccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankOfSuccess.BLL
{
     ///<summary>
    ///Account form class :One object required 
    ///Singleton design pattern
    ///</summary>
    public class Accountform
    {
        private static Accountform form;
        public static Accountform GetForm()
        {
            if (form == null)
                form = new Accountform();
            return form;
        }

        private Accountform() { }

        //create my manager object.
        Manager manager = Manager.GetManager();
        public void OpenAccount()
        {

            Privilege member = Privilege.SILVER;
            int x;
            try
            {
                Console.WriteLine("Which type of Account you Want to Open " +
                    " \n1. Saving Account \n2. Current Account \n Press 1 For Saving \n Press 2 for Current Account");

                x = int.Parse(Console.ReadLine());

                if (x == 1)
                {
                    string name;              
                    Console.WriteLine("Enter the Name = \t");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the Date Of Birth =\t");
                    DateOnly date = DateOnly.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Gender \n Press:- \n\tM for male \n\tY for Female \n\tO for Other ");
                    string gender = Console.ReadLine();
                    Console.WriteLine("Enter your PhoneNumber");
                    long phonenumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Want to Opt for gold membership \n Press Yes|Y /|No|N :-\t for daily trasfer limit upto 50000 \n Note:- Bydefault it is 25000.");
                    string lim = Console.ReadLine().ToUpper();
                    
                    if (lim.Equals("Y") || lim.Equals("YES"))
                        member = Privilege.GOLD;
                    

                    Console.WriteLine("Set the security Pin for account");
                    int pin = int.Parse(Console.ReadLine());


                    manager.OpenAccount(name, date, gender, phonenumber,pin,member);

                }

                else if (x == 2)
                {

                    Console.WriteLine("Enter the Name =\t");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter Company Name =\t");
                    string companyname = Console.ReadLine();

                    Console.WriteLine("Enter the company website URL =\t");
                    string website = Console.ReadLine();

                    Console.WriteLine("Enter your Company Registration number");
                    string registration = Console.ReadLine();
                  
                    Console.WriteLine("Set the security Pin for account");
                    int pin = int.Parse(Console.ReadLine());
                    Console.WriteLine("Want to Opt for gold membership \n Press Yes|Y /|No|N :-\t for daily trasfer limit upto 50000 \n Note:- Bydefault it is 25000.");
                    string lim = Console.ReadLine().ToUpper();

                    if (lim.Equals('Y') || lim.Equals("YES"))
                    {
                        member = Privilege.GOLD;
                    }
                    manager.OpenAccount(name, companyname, website, registration,pin,member);

                }
                
                else Console.WriteLine("Please choose correct option");

            }
            catch (Exception ex) { throw; }
        }


        public void CloseAccount() 
        {
           

                Console.WriteLine("Enter Account Number");
                int accountnumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter security pin");
                int pin = int.Parse(Console.ReadLine());

                manager.CloseAccount(accountnumber, pin);
            
           

        }
        public void Withdraw() 
        {
            try
            {

                Console.WriteLine("Enter Account Number");
                int accountnumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter security pin");
                int pin = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the withdraw amount");
                int amount = int.Parse(Console.ReadLine());

                manager.Withdraw(accountnumber, pin, amount);
            }
            catch(Exception ex) { throw; }
        }
        public void Deposit() 
        {
            try
            {

                Console.WriteLine("Enter Account Number");
                int accountnumber = int.Parse(Console.ReadLine());
             
                Console.WriteLine("Enter the deposit amount");
                int amount = int.Parse(Console.ReadLine());

                manager.Deposit(accountnumber,amount);
            }
            catch (Exception ex) { throw; }
        }
        public void Transfer() 
        {

            Console.WriteLine("Enter  Senders Account Number");
            int senderaccount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter security pin");
            int senderpin = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Amount to be Transfered");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Receivers Account Number");
            int receiveraccount = int.Parse(Console.ReadLine());

            manager.Transfer(senderaccount, senderpin, amount, receiveraccount);
        }
    }
}
