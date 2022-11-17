using BankOfSuccess.Entities;
using BankOfSuccess.BLL.validate;
using BankOfSuccess.DAL;

namespace BankOfSuccess.BLL
{
    /// <summary>
    /// manager :One Manager is required
    /// Single Design Pattern
    /// </summary>
    public class Manager
    {
        //Static :Binds the access to the class./Only Class static method will able to touch it.
        private static Manager Mymanager;

        //we use GetManager to create the object of Manager.It will allow user to create only one Manager object.
        public static Manager GetManager()
        {
            if(Mymanager == null)
                Mymanager = new Manager();
            return Mymanager;
        }

        //we make constructor private :Block user to make objects.
        private Manager() { }

        List<Accounts> accounts = new List<Accounts> ();

        bool valid;


        public void OpenAccount(string name,DateOnly date,string gender,long phonenumber,int pin,Privilege privilege)
        { bool ValidAge = false;
            try
            {
                AgeCheck agecheck = new AgeCheck();
                ValidAge = agecheck.Validate(date);

                if (ValidAge==false)
                { 
                    Accountform form = Accountform.GetForm();
                    form.OpenAccount();
                      
                }

                Console.WriteLine("please deposit opening amount for this new account  ~ min 1000");

                int openingbalance = int.Parse(Console.ReadLine());
                
                if (openingbalance >= 1000)
                {
                    

                    SavingAccounts acc = new SavingAccounts(date, gender, phonenumber, name, openingbalance, pin,privilege);
                    accounts.Add(acc);

                    Console.Clear();
                    
                    Console.Beep();

                    Console.WriteLine($"account number = {acc.AccountNumber}\nname = {acc.Name}\ngender= {acc.Gender}\nphonenumber= {acc.PhoneNumber}" +
                        $"\nDOB = {acc.DateOfBirth}\n balance= {acc.Balance}\nactivation date={acc.ActivationDate}" +
                        $"\nclosing date= {acc.ClosedDate} \nprivilege= {acc.privilege}");
                }
                else Console.WriteLine("please deposit sufficient opening amount :   TRY AGAIN!");


            }
            catch(InvalidAgeException ex)
            {
                throw;
            }



        }

        public void OpenAccount(string name,string companyname,string website,string registrationnumber,int pin,Privilege privilege)
        {
            
            try
            {
                RegistrationNumbercheck registrationcheck = new RegistrationNumbercheck();
                 valid = registrationcheck.validate(registrationnumber);
            } 
            catch(InvalidRegistrationNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
          
            Console.WriteLine("please deposite opening amount for new account ~ min 5000");
            int openingbalance = int.Parse(Console.ReadLine());


            if(openingbalance>=5000)
            {
                CurrentAccounts acc = new CurrentAccounts(companyname, website, registrationnumber, name, openingbalance,pin,privilege);
                accounts.Add(acc);

                Console.Clear();
                Console.Beep();
                Console.WriteLine($"Account number = {acc.AccountNumber}\n Name = {acc.Name}\nGender= {acc.CompanyName}\n" +
                    $"CompanyWebsite= {acc.Website}" +
                   $"\nDOB = {acc.RegisterationNumber}\nBalance= {acc.Balance}\nActivation date={acc.ActivationDate}" +
                   $"\nClosing date= {acc.ClosedDate} \nPrivilege= {acc.privilege}" );
            }
            else Console.WriteLine("Please deposit sufficient opening amount :   TRY AGAIN!");
        }
       
        public void CloseAccount(int accountnumber,int pin)
        {
            foreach(Accounts a in accounts) 
            {
                try
                {
                    if (a.AccountNumber == accountnumber)
                    {
                        AccountCheck pincheck = new AccountCheck();
                        valid = pincheck.Validate(a.IsActive,a.PinNumber, pin);
                        a.IsActive = false;
                        Console.WriteLine("Account is closed");
                    }
                }
                catch (InvalidClosedAccountException ex) { throw; }
                catch (InvalidPinException ex) { throw; }

            }
        }
        public bool Withdraw(int accountnumber,int pin, int amount)
        { 
            foreach (Accounts a in accounts)
            {
                if (a.AccountNumber == accountnumber)
                {
                    try
                    {   AccountBalanceCheck accountBalanceCheck = new AccountBalanceCheck();
                        AccountLimitCheck accountLimitCheck = new AccountLimitCheck();
                        valid = accountBalanceCheck.validate(a.Balance,amount,a.IsActive,a.PinNumber,pin);
                        valid = accountLimitCheck.validate(a.privilege,amount);
                        
                        a.Balance -= amount;

                        Console.WriteLine($"Transaction Success \n account{a.AccountNumber}\n updated amount{a.Balance}");
                        return true;
                    }
                    catch(InvalidClosedAccountException ex) { throw; }
                    catch(InvalidWithdrawAmountException ex) { throw; }
                    catch (InvalidPinException ex) { throw; }
                    catch (InvalidTransferLimitException ex) { throw; }
                }

            }
            Console.WriteLine("Account Not Found");
            return false;
        }
        public bool Deposit(int accountnumber,int amount)
        {
            foreach (Accounts a in accounts)
            {
                if (a.AccountNumber == accountnumber)
                {
                    try
                    {
                       AccountStatusCheck accountstatuscheck = new AccountStatusCheck();
                        valid = accountstatuscheck.Validate(a.IsActive);
                        AccountLimitCheck accountLimitCheck = new AccountLimitCheck();
                        valid = accountLimitCheck.validate(a.privilege, amount);

                        a.Balance += amount;
                        Console.WriteLine($"Transaction Success \n account = {a.AccountNumber}\n updated amount ={a.Balance}");
                        return true;
                    }
                    catch (InvalidClosedAccountException ex) { throw; }
                    catch (InvalidPinException ex) { throw; }
                    catch (InvalidTransferLimitException ex) { throw; }
                }

            }
            return false;
            Console.WriteLine("Account Not Found");
        }

        public void Transfer (int senderaccount,int senderpin,int amount,int receiveraccount)
        {
            valid=Withdraw(senderaccount, senderpin, amount);
            if(valid==true)
             valid=Deposit(receiveraccount, amount);
            if(valid == true)
            {
                Console.WriteLine("Transfer is Success:  Thankyou");
            }

        }
    }
}
