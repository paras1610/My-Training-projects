using DBDemo1.Entities;
using DBDemo1.Data;

internal class program
{
    static void Main(string[] args)
    {

        Contact c = AcceptContact();
        IContactRepository repo = new ContactRepository();
        repo.Save(c);
        Console.WriteLine("contact saved....");

    }
    static Contact AcceptContact()
    {
        Contact c = new Contact();
        Console.WriteLine("Enter the name ");
        c.Name = Console.ReadLine();
        Console.WriteLine("Enter mobile number ");
        c.Mobile = Console.ReadLine();
        Console.WriteLine("Enter the Email ");
        c.Email = Console.ReadLine();
        Console.WriteLine("Enter the address ");
        c.Location = Console.ReadLine();
        return c;
    }
}