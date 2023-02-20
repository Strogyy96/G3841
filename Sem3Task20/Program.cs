// программа принимает координаты 2 точек и находит расстояние между
// этими точками в пространстве


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// разработаем метод принт дата для вывода результата вычислений
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

// метод для вычисления длинны гипотенузы в значениях double, тк не целое значение получится
// вычисляем расстояние между точками в 2D пространстве
double CalcLen(int x1, int x2, int y1, int y2)
{
    double res = 0;
    // Math.Sqrt = извлекает корень, Math.Pow = возводит в указанную степень
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    return res;
}
// вводим координаты точек
int coordX1 = ReadData("Введите координату x1");
int coordX2 = ReadData("Введите координату x2");
int coordY1 = ReadData("Введите координату y1");
int coordY2 = ReadData("Введите координату y2");
// вычисляем длинну
double len = CalcLen(coordX1, coordX2, coordY1, coordY2);
// выдаем результат
PrintData("Расстояние между точками: ", len);
