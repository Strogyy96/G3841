// Напишите прог которая создает массив из 8 элементов и выводит их на экран

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// генерируем массив
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
int arrBegin = ReadData("Введите начало массива: ");
int arrEnd = ReadData("Введите конец массива: ");

int[] arr = Gen1DArr(arrLen, arrBegin, arrEnd);

Print1DArr(arr);