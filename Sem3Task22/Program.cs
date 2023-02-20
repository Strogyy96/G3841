// Принимает на вход число N и выдает таблицу квадратов чисел от 1 до N
// метод для данных считывания
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// выводим результат пользователю
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}
// метод для сборки строк таблицы возвращаемый
string LineBuilder(int n, int p)
{
    string res = string.Empty;
    for (int i = 1; i <= n; i++)
    {
        res += Math.Pow(i, p) + "\t ";
    }
    return res;
}
// ввод данных
int num = ReadData("Введите N: ");
// собираем первую строку
string line1 = LineBuilder(num, 1);
// собираем вторую строку
string line2 = LineBuilder(num, 2);
// вывод данных
PrintData(line1, line2);