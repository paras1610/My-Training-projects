//UI Layer

using validatecheck;
string Number ; // Declare Variable to store the string.
string Status; // Declare Variable to store the status of number.

while (true) //infinite loop 
{   
    try
    {
        Console.WriteLine("\n Enter the mobile number :-");
        ValidateString Validity = new ValidateString();
        Number = Console.ReadLine();
        Status = Validity.Check(Number);
        Console.WriteLine($"number is {Status}");
    }

    //exception catch block

  
    catch (InvalidFormat ex)     //exception defined in validatecheck project to check (9*********)format.
    {
        Console.WriteLine(ex.Message);
    }


    catch (InvalidType ex)  //exception defined in validatecheck project to check the string contain all digit.
    {
        Console.WriteLine(ex.Message);
    }


    catch (InvalidSize ex)  //exception defined in validatecheck project to check number has 10 character.
    {
        Console.WriteLine(ex.Message);
    }


    catch (Exception)  // universal exception class contain all exception.
    {
        Console.WriteLine("Error:- Something went wrong");
    }
}

