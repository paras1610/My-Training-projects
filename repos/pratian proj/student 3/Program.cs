// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter students name");
string Name=Console.ReadLine();
Console.WriteLine("Enter English marks");
int English=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Maths marks");
int Maths = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Science marks");
int Science = Convert.ToInt32(Console.ReadLine());
int TotalMarks = (English + Maths + Science);
int AverageMarks = TotalMarks / 3;
if(AverageMarks>=60 &&English>34 &&Maths>34&&Science>34)
    Console.WriteLine($"student is passed with first class with{TotalMarks}");
if (AverageMarks >= 50 && AverageMarks<60 && English > 34 && Maths > 34 && Science > 34)
    Console.WriteLine($"student is passed with Second  class with{TotalMarks}");
if (AverageMarks >= 35 && AverageMarks<50 && English > 34 && Maths > 34 && Science > 34)
    Console.WriteLine($"student is passed class with{TotalMarks} /300");
if (AverageMarks <35 || English < 34 || Maths < 34 || Science < 34)
    Console.WriteLine($"student is failed with{TotalMarks}");

