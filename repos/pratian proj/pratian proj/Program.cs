// See https://aka.ms/new-console-template for more information

    Console.WriteLine("Enter the amount");
    double Principle = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Interest");
    double RateOfInterest = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the Time");
    double Time = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Calculated Simple Interest is"+((Principle*RateOfInterest*Time)/100));
 
