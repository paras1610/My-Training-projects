Console.WriteLine("Enter the size of the array");
int N = Convert.ToInt32(Console.ReadLine());
int[,] TwoD = new int[N, N];
int[,] TwoDTranspose = new int[N, N];
int counter1 = 0;
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.WriteLine($"enter element {i},{j} in the array");
        TwoD[i, j] = Convert.ToInt32(Console.ReadLine());
        TwoDTranspose [j,i] = TwoD[i,j];
    }
}
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {

        Console.Write(TwoD[i, j] + "\t");
        //Console.Write(TwoDTranspose[i, j] + "\t");
        if (TwoD[i, j] == TwoDTranspose[j,i]) { counter1 = counter1 + 1; }

    }
    Console.WriteLine();
}
int count = N * N;
if (counter1==count ) { Console.Write("array is symmetric matrix"); }
else { Console.Write("Array is not symmetric matrix"); }