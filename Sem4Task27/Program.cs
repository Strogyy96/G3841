// ввести число и посчитать сумму чисел в этом числе

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int SumSym (int num)
{
    int res = 0;
    while(num >0)
    {
        res = res + num%10;
        num = num/10;
    }
    return res;
}

void PrintData(int msg)
{
    Console.WriteLine(msg);
}

int number = ReadData("Введите число: ");

int answer = SumSym (number);

PrintData(answer);