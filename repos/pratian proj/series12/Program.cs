int FirsT = 1;
int SeconD = 4;
int ThirD = 7;
int sum = 0;
int i = 1;
Console.Write($"{FirsT} {SeconD} {ThirD}");
while (i < 10)
{
    sum = FirsT + SeconD + ThirD;
    Console.Write($" {sum} ");
    FirsT = SeconD;
    SeconD = ThirD;
    ThirD = sum;
    i++;
}

