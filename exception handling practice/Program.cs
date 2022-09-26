//UI logic Layer

//vaiable declare outside loop
using SimpleMath_library;
int Fno;
int Sno;
int sum;
while (true)
{
    try
    {


        Console.WriteLine("enter the first value =");
        Fno = int.Parse(Console.ReadLine());


        Console.WriteLine("enter the second value =");
        Sno = int.Parse(Console.ReadLine());

        SimpleMath sm = new SimpleMath();//instance of simplemath class is created
        sum = sm.Sum(Fno, Sno);
        Console.WriteLine($"the sum of {Fno} and {Sno} is={sum} ");
    }
    catch (InvalidEvenNumberException ex)
    {
        Console.WriteLine("please enter one even value !");
    }
    catch (FormatException ex)
    {
        Console.WriteLine("please enter the numerical value ! ");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"some error occured try again (...{ex.Message})...");
    }
}
