// напишите программу которая выводит случайные числа из отрезка 10 - 99 и показывает наибольшую цифру этого числа

// вариант 1

System.Random numSintezanor = new System.Random();

// int rndNum = numSintezanor.Next(10, 100);
// Console.WriteLine("Случайное число: " + rndNum);

// int digit1 = rndNum / 10;
// int digit2 = rndNum % 10;

// if (digit1 > digit2)
// {
//     Console.WriteLine("Цифра 1 больше цифры 2: " + digit1 + " " + digit2);
// }
// else
// {
//     Console.WriteLine("Цифра 2 больше цифры 1: " + digit1 + " " + digit2);
// }

// Вариант 2

char[] digits = numSintezanor.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
int digit1 = (int)digits[0]-48;
int digit2 = (int)digits[1]-48;
int resNum = digit1>digit2?digit1:digit2;
Console.WriteLine(resNum);

// Вариант 3
// заполняем массив готовыми ответами под любое необходимое нам число