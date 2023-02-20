// Напишите программу которая принимает на вход координаты точки X Y,
// причем X Y не равны нулю, и выдает номер четверти в которой находиться эта точка
// раз операция одинаковая мы ее обернем в метод!
int coordX = ReadData("Введите координату X");
int coordY = ReadData("Введите координату Y");
// вызываем метод
PrintQuterTest();
// Console.WriteLine("Введите координату Х");
// int coordX = int.Parse(Console.ReadLine()??"0");
// сначала указываем тип данных которым будет оперировать метод
// указываем значащее название
// метод читает данные от пользователя

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// берем метод войд = тишина, принимает но не возвращает. 
// определяем четверть по координатам точки
void PrintQuterTest()
{
    if (coordX > 0 && coordY > 0) Console.WriteLine("Точка в четверти 1");
    if (coordX > 0 && coordY < 0) Console.WriteLine("Точка в четверти 2");
    if (coordX < 0 && coordY < 0) Console.WriteLine("Точка в четверти 3");
    if (coordX < 0 && coordY > 0) Console.WriteLine("Точка в четверти 4");
}



