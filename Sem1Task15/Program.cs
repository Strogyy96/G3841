﻿// программа получает на вход цифру обозначающую день недели и на выходе отвечает 
// является этот день выходным или нет

// запрашиваем данные у пользователя
Console.WriteLine("Введите номер дня недели: ");
// превращаем символы в целочисленное значение и проводим проверку на null
int day = int.Parse(Console.ReadLine()??"0");
// через цикл ифэлз если введенное число за пределами 1-7 выводим что это не день недели
if (day > 7 || day < 1)
{
    Console.WriteLine("не день недели");
}
// если число больше пяти но меньше 8 тогда пишем Выходной, если меньше 5 но больше 1 рабочий.
else
{
    if (day>5)
    {
        Console.WriteLine("Выходной");

    }
    else
    {
        Console.WriteLine("рабочий");

    }
}
