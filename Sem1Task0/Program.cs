// считываем данные с консоли
string? inputNum = Console.ReadLine();
// проверяем чтобы данные были не пустыми
if (inputNum != null)
{
    // // Парсим введенное число (превращаем строку в число)
    // int number = int.Parse(inputNum);
    // // Находим квадрат числа
    // // int result = number*number;
    // int result = (int)Math.Pow(number,2);



    // // Вывоим данные в консоль
    // Console.WriteLine(result);

    Console.WriteLine(Math.Pow(int.Parse(inputNum),2));
}