Console.WriteLine("Enter the series Nth value");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i<=N)
{   int j=2*i;
    Console.Write(" "+(j*j));
    i = i + 1;
}
