Console.WriteLine("Enter the size of the array");
int N = Convert.ToInt32(Console.ReadLine());
int[ , ] TwoD = new int[N, N];
int counter1=0;
int counter2=0;
for (int i = 0; i < N; i++)
{
    for(int j = 0; j < N; j++)
    {
        Console.WriteLine($"enter element {i},{j} in the array");
        TwoD[i,j]=Convert.ToInt32(Console.ReadLine());
    }
}
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
         
        Console.Write(TwoD[i, j] + "\t");
        if (i == j && TwoD[i, j] == 1) { counter1=counter1+1; }
        if(i!=j && TwoD[i, j] == 0) { counter2=counter2+1; }
    }
    Console.WriteLine();
}
int check = (N * N) - N;
if (counter1 == N && counter2 == check) { Console.Write("array is identity matrix"); }
else { Console.Write("Array is not identity matrix"); }