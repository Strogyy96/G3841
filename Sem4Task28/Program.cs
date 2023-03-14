// принимает число N и выдает произведение чисел от 1 до N
// чтобы подключить тип BigInteger используем  
using System.Numerics;
// и теперь наша система будет знать о существовании типа BigInteger!!!
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// выводим результат пользователю
void PrintData(string msg1, BigInteger msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}
// метод для вычисления факториала
BigInteger CalcFact(int num)
{
    BigInteger res = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res * i;
    }
    return res;
}
// пишем программу теперь
// вводим число
int number = ReadData("Введите число N: ");
// считаем факториал
BigInteger fact = CalcFact(number);
// Выводим результат
PrintData("Факториал равен: ",fact);

