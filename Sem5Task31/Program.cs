// задайте массив из 12ти элементов, заполненный случайными числами
// из промежутка [-9,9].
// найдите сумму отрицательных и положительных элементов массива

int positivSum = 0;
int negotivSum = 0;

int[] testArr = Gen1DArr(12,-9,9);
NegotivPosSum(testArr);
Print1DArr(testArr);
PrintData("Сумма положительных чисел: ", positivSum);
PrintData("Сумма отрицательных чисел: ", negotivSum);


// выводим результат пользователю
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

// генерируем массив
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue,maxValue + 1);
    }
    return arr;
}

// метод печати массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void NegotivPosSum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positivSum += arr[i];
        }
        else
        {
            negotivSum+=arr[i];
        }
    }
}