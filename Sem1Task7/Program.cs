// принимаем на входе трехзначное число и на выходе показываем последнюю цифру трехзначного числа

string? numberA = Console.ReadLine();
// проверяем чтобы данные не были пустыми
if (numberA != null)
{
    // парсим введенное число
    int numberB = int.Parse(numberA);
    // остаток от деления на 10 с помощью оператора %
    int LastDigit = numberB % 10;

    Console.WriteLine(LastDigit);
}
