﻿// выводит третью цифру заданного числа или сообщает что третьей цифры нет
// запрашиваем данные у пользователя
Console.WriteLine("Введите число: ");
// применяем массив чар считывая данные введенные в консоль пользователем
char[] digit = Console.ReadLine().ToCharArray();
// ставим условие если чар(пишем название присвенное массиву - диджит) массив больше 3 тогда выводим вторую ячейку массива (третью цифру)
if (digit.Length >= 3)
{//выводим результат
    Console.WriteLine(digit[2]);
}
// если введенное число не трехзначное, массив короче чем 3 символа тогда выводим 
// "третей цифры нет"
else
{
    Console.WriteLine("Третьей цифры нет!");
}
