// программа принимает номер четверти координат и 
// выдает условия какие должны быть коорд X Y
int qNum = ReadData("Введите номер четверти");

// вызываем метод
PrintQuterAnswer(qNum);

// сначала указываем тип данных которым будет оперировать метод (int)
// указываем значащее название
// Данный метод читает данные от пользователя

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// берем метод войд = тишина, принимает но не возвращает. 
// метод определяет допустимый диапазон координат точек на четверти

void PrintQuterAnswer(int num)


{
    if (num > 0 && num < 5)
    {
        if (num == 1) Console.WriteLine("X > 0 Y > 0");
        if (num == 2) Console.WriteLine("X > 0 Y < 0");
        if (num == 3) Console.WriteLine("X < 0 Y < 0");
        if (num == 4) Console.WriteLine("X < 0 Y > 0");
    }
    else Console.WriteLine("Это не номер четверти!");
}

