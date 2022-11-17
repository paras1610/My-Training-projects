Console.WriteLine("Enter the base value");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the power");
int X = Convert.ToInt32(Console.ReadLine());
int i = 1;int sum = 1;
while (i <= X)
{
    sum = sum * N;
 
    i = i + 1;
}
Console.Write(sum);