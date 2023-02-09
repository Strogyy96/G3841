// программа получает на вход цифру обозначающую день недели и на выходе отвечает 
// является этот день выходным или нет
int day = int.Parse(Console.ReadLine()??"0");

if (day > 7 || day < 1)
{
    Console.WriteLine("не день недели");
}
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
