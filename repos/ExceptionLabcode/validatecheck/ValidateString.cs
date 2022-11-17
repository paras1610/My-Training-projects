//Business logic layer
using validatecheck;
/// <summary>
/// Use this class for validate mobile number . 
/// </summary>

public class ValidateString
{
    /// <summary>
    /// validate the number Size(10) ,Type(digit),Format(9****).
    /// </summary>
    /// <param name="Number"></param>
    /// <returns></returns>
    /// <exception cref="InvalidSize"></exception>
    /// <exception cref="InvalidFormat"></exception>
    /// <exception cref="InvalidType"></exception>
    public string Check(string Number)
    {  


        if (Number.Length > 10|| Number.Length < 10)
        {
            throw new InvalidSize("Error:- Enter 10 digit only");
        }


        if (Number[0] != '9')
        {
            throw new InvalidFormat("Error:- Number should be start from  9"); 
        }


        if (Number.All(char.IsDigit) != true)
        {
            throw new InvalidType("Error:- Enter only digits/number value");

        }


        return "OK";
    }
}

