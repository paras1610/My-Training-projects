Console.WriteLine("Enter the series Nth value");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 1;
while (i <= N)
{
    j = j+(i * i);
    Console.Write(" " + (j));
    i = i + 1;
}

