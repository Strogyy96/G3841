// Считываем данные с консоли
string? inputLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if(inputLine!=null)
{
    
// Вариант 1
    // string [] dayWeek = new string[7];
    // dayWeek [0] = "понедельник";
    // dayWeek [1] = "вторник";
    // dayWeek [2] = "среда";
    // dayWeek [3] = "четверг";
    // dayWeek [4] = "пятница";
    // dayWeek [5] = "суббота";
    // dayWeek [6] = "воскресение";
    
    // int nameDay = int.Parse(inputLine);
    // Console.WriteLine(dayWeek[nameDay-1]);

    // Вариант 2
    int nameDay = int.Parse(inputLine);
    string dayWeek = string.Empty;
    switch (nameDay)
    {
        case 1: dayWeek = "понедельник"; break;
        case 2: dayWeek = "вторник"; break;
        case 3: dayWeek = "среда"; break;
        case 4: dayWeek = "четверг"; break;
        case 5: dayWeek = "пятница"; break;
        case 6: dayWeek = "суббота"; break;
        case 7: dayWeek = "воскресение"; break;
        default: dayWeek = "Это не день недели!"; break;
    }
    Console.WriteLine(dayWeek);
}
