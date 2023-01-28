// вводим данные 
string? inputNumLineA = Console.ReadLine();

string? inputNumLineB = Console.ReadLine();
// проверяем чтобы небыло пустых значений
if (inputNumLineA!=null&&inputNumLineB!=null)
// превращаем строки в цело численные значения
{
   int numberA = int.Parse(inputNumLineA);
   int numberB = int.Parse(inputNumLineB);
   // циклом if else определяем большее число и выводим ответ
      if (numberA>numberB)
      {
        Console.WriteLine("Первое число больше второго!");    
      }
      else 
      {
        Console.WriteLine("Второе число больше первого!");
      }



}

