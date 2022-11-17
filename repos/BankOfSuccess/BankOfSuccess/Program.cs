using BankOfSuccess.BLL;
using BankOfSuccess.Entities;
using System;

class BOS
{
    static public void Main(string[] args)
    {
      
        
        Accountform form =Accountform.GetForm();
        Boolean a = true;
        int x;
        while (a == true)
        {
            try
            {
                Console.WriteLine("\t\tWelcome to the Bank of Success\n\n");
                Console.WriteLine("Press 1 to open an account");
                Console.WriteLine("Press 2 to Close account");
                Console.WriteLine("Press 3 to Withdraw money from your account");
                Console.WriteLine("Press 4 to Deposit Money in Account");
                Console.WriteLine("Press 5 to Transfer money from Account  ");
                Console.WriteLine("Press 6 to Exit");

                x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        {


                            form.OpenAccount();



                        }
                        break;

                    case 2:
                        {
                            form.CloseAccount();
                        }
                        break;

                    case 3:
                        { 
                            form.Withdraw();
                        }
                        break;

                    case 4:
                        {
                            form.Deposit();
                        }
                        break;

                    case 5:
                        {
                            form.Transfer();  
                        }
                        break;

                    case 6:
                        {
                            Console.WriteLine("Thankyou for visiting the Bank");
                            a = false;
                        }
                        break;

                    default:
                        Console.WriteLine("Please choose from Above option");
                        break;
                }
            }
            catch (Exception ex) { Console.WriteLine($"\t\t{ex.Message}\n\n"); }
        }

    }
}