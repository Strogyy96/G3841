// напишите программу которая на вход принимает одно число а на выходе показывает все целые числа в промежутке от -n до n  
// считываем данные с косоли
string? numberA = Console.ReadLine();
// проверяем чтобы данные не были пустыми
if (numberA!=null)
{
// парсим введенное число
   int numberB = int.Parse (numberA);
// вводим переменную для отрицательных чисел
   int numberC = (numberB * -1);
// добавляем выходные значения
   string R = string.Empty;
// цикл вайл 
   while(numberC < numberB)
   {
    R = R + numberC + ",";
    numberC = numberC + 1;
   }
R = R + numberB;

Console.WriteLine(R);
}