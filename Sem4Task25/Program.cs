// напишите цикл который принимает на вход 2 числа (a,b) и возводит число a в степень b




int Pow (int a, int b)
{
    int res = 1;
    while (b>0)
    {
        b = b - 1;
        res = res*a;
    }
    return res;
}

void PrintData(int msg)
{
    Console.WriteLine(msg);
}

int a = ReadData("Введите число a: ");
int b = ReadData("Введите число b: ");

int answer = Pow (a,b);

PrintData (answer);