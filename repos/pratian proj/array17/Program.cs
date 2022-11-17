Console.WriteLine("Enter the size of array");
int x=int.Parse(Console.ReadLine());
int[] arr = new int[x];
int j = 0;
while(j < arr.Length)
{ arr[j]=int.Parse(Console.ReadLine());
j++;}

Array.Sort(arr);
foreach(int i in arr)
    { Console.WriteLine(i); }

Console.WriteLine("enter the number you want to search");
int c = int.Parse(Console.ReadLine());
for 


