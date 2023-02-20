// принимает на вход пятизначное число и проверяет является ли оно полиндромом или нет
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// выводим результат пользователю
void PrintData(bool msg)
{
    Console.WriteLine(msg);
}
// PalinTest проводим тест на полиндромность
bool PalinTest(int n)
{
    bool res = false;
    int digit1 = n / 10000;
    int digit2 = (n / 1000) % 10;
    int digit3 = (n / 10) % 10;
    int digit4 = n % 10;
    res = ((digit1 == digit4) && (digit2 == digit3)) ? true : false;
    return res;
}
// написали методы теперь прописываем последовательность действий
// запрашиваем число
int n = ReadData("Введите пятизначное число: ");
// обращаемся к методу определения полиндрома
bool line1 = PalinTest (n);
// выводим ответ на консоль
PrintData(line1);
