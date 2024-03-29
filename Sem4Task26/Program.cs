﻿// принимает число и отвечает сколько цифр в числе

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
// считаем кол-во символов, с пом цикла вайл пока не отстанется 0 от деления
// делим и считаем сколько раз произвели деление
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res++;
        num = num / 10;
    }
    return res;
}
// метод через оператора тустринг, преобразует число в строку и определяем длинну
// данные кладем в переменную рес
int SumDigStr(int num)
{
    int res = 0;
    res = num.ToString().Length;
    return res;
}
// метод с помощью логорифма
int VariantLog(int num)
{
    int count = (int)Math.Log10(num) + 1;
    return count;
}
int number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int res1 = SumDigit(number);
Console.WriteLine(DateTime.Now - d1);
PrintData("Вариант (SumDigit): ", res1);

DateTime d2 = DateTime.Now;
int res2 = SumDigStr(number);
Console.WriteLine(DateTime.Now - d2);
PrintData("Вариант (SumDigStr): ", res2);

DateTime d3 = DateTime.Now;
int res3 = VariantLog(number);
Console.WriteLine(DateTime.Now - d3);
PrintData("Вариант (VariantLog): ", res3);