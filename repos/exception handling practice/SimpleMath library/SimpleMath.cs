//business logic layer or backend class

using SimpleMath_library;

/// <summary>
/// Use this class for calculate simple math operation 
/// </summary>
public class SimpleMath
{ 
    /// <summary>
    /// calculate the sum of two number atleast one even .
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// <exception cref="InvalidEvenNumberException"></exception>
    public int Sum(int a, int b)
    {
        if (a % 2 == 0 || b % 2 == 0)
            return a + b;
        throw new InvalidEvenNumberException("Enter Only Even Number !");
        
        
    }
}