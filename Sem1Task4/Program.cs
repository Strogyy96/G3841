// запрашиваем данные у пользователя
Console.WriteLine("Введите три числа:");

string? inputNumLineA = Console.ReadLine();
string? inputNumLineB = Console.ReadLine();
string? inputNumLineC = Console.ReadLine();
// проверяем чтобы небыло пустых значений
if (inputNumLineA!=null&&inputNumLineB!=null&&inputNumLineC!=null)
// превращаем строки в цело численные значения
{
   int numberA = int.Parse(inputNumLineA);
   int numberB = int.Parse(inputNumLineB);
   int numberC = int.Parse(inputNumLineC);
   // циклом if else определяем большее число, внутри первого цикла создаём еще один для проверки победившего с третьим и выводим ответ
      if (numberA>numberB)
      {
        if (numberA>numberC)
        {
            Console.Write("Наибольшее число:");
            Console.WriteLine(numberA);
        }
        else
         {
            Console.Write("Наибольшее число:");
            Console.WriteLine(numberC);
         }
        
      }
      else 
      {
        if (numberB>numberC)
        {
           Console.Write("Наибольшее число:");
           Console.WriteLine(numberB);
        }
        else 
        {
           Console.Write("Наибольшее число:");
           Console.WriteLine(numberC);
        }
    }
}
