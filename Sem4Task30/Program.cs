// напишите программу которая выводит массив из 8 элементов заполняемый 0 и 1 рандомом
// пишем 2 метода 1й будет генерировать одномерный массив(Gen1DArr) а 2ой метод
// будет выводить массив(Print1DArra) на консоль
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] Gen1DArr(int num, int begin, int end)
{
     Random rnd = new Random();
    int[] arr = new int[num];   
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int arrLen = ReadData("Введите длинну массива: ");

int[] arr = Gen1DArr(arrLen, 0, 2);

Print1DArr(arr);