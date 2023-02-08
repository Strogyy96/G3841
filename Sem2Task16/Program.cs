// принимает на вход 2 числа и проверяем является ли одно квадратом другого?
Console.WriteLine("Введите 2 числа: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");
// сравнение чисел на квадратность через метод ВОЙД, пишем метод и обращаемся к нему потом
TestSQRT(num1,num2);
TestSQRT(num2,num1);
// тут описан метод к которому мы обращаемся в строчках выше
void TestSQRT(int i, int j)
{
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.WriteLine("Число " + j + " является квадратом числа " + i);
    }
    else
    {
        Console.WriteLine("Число " + j + " не является квадратом числа " + i);
    }
}
