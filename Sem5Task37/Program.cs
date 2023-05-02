// Задача 37 - Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и тд,
// результат запишите в новый массив.

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
int[] ConvertArr(int[] arr)
{
    int[] resArr = new int[(arr.Length / 2) + 1];
    for (int i = 0; i < resArr.Length; i++)
    {
        resArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return resArr;
}

int[] testArr = Gen1DArr(123, 0, 1000);
Print1DArr(testArr);
int[] convArr = ConvertArr(testArr);
Print1DArr(convArr);
Print1DArr(testArr);

