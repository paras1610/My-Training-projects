//UI layer
using BLL;
using SUMT;

static void Main(string[] args)
{
    int FirstNum = 0;
    int SecondNum = 0;
    int Sum = 0;

  
            //first value
            Console.WriteLine("Enter the first value =");
            FirstNum = int.Parse(Console.ReadLine());

            //second value
            Console.WriteLine("Enter the second value =");
            SecondNum = int.Parse(Console.ReadLine());

            //creating object of DOsum  class as s1
            DOsum s1 = new DOsum();
            Sum = s1.DoSum(FirstNum, SecondNum);

            //showing result sum
            Console.WriteLine($"Sum of the numbers {FirstNum} and {SecondNum} is = {Sum}");
}

static SUM initialize()
{
    SUM s = new SUM();
    s.First_num=
}