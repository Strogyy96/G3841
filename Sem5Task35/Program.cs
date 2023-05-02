// Задача 35 - задайте одномерный массив из 123 случайных чисел
// найдите кол-во элементов массива, значения которых лежат в отрезке 10 - 99

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// метод Search для поиска нужного числа
int CountElem(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

bool Test (int n)
{
    return (n>10&&n<99);
}

int [] testArr = Gen1DArr(123,0,1000);
Print1DArr(testArr);
int count = CountElem(testArr);
PrintData("Количество элементов в отрезке [10,99] :" + count);
