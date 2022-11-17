int FirsT = 1;
int SeconD = 2;
int i = 1;
Console.Write($"{FirsT} {SeconD}");
while (i < 10)
{
    FirsT=FirsT + 3;
    SeconD= SeconD + 4;
    Console.Write($" {FirsT} ");
    Console.Write(SeconD);
    i++; 
}
