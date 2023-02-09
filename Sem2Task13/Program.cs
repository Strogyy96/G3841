// выводит третью цифру заданного числа или сообщает что третьей цифры нет

Console.WriteLine("Введите число: ");



char[] digit = Console.ReadLine().ToCharArray();

if (char.Length > 3)
{
    Console.WriteLine(digit[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}
