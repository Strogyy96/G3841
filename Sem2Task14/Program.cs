// Ввести 1 число и проверить кратно ли оно 7 и 23?
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
int result1 = num1 % 7;
int result2 = num1 % 23;
//два типа объединений 1 - логическое И обозначается &&;
// 2 - логическое ИЛИ обозначается ||
if ((result1 == 0) && (result2 == 0))
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Некратно");
}