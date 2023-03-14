// принимает на вход число А и выдает сумму чисел от 1 до А

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int SumSimple(int numA)
{
    int sumOfNumbers = 1;
    for (int i = 2; i <= numA; i++)
    {
        sumOfNumbers += i;
    }

    return sumOfNumbers;
}

int SumGauss(int numA)
{
    return numA*(numA+1)/2;
}

int numberA = ReadData("Введите число А: ");

DateTime d2 = DateTime.Now;
int res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

DateTime d1 = DateTime.Now;
int res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);


PrintData("Сумма чисел от 1 до А(SumSimple): ", res1);
PrintData("Сумма чисел от 1 до А(SumGauss): ", res2);