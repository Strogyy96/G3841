// на входе трехзначное число, 
//цифру посередине убрать и вывести двузначное число.


System.Random numSintezanor = new System.Random();

int num = numSintezanor.Next(100,1000);

Console.WriteLine(num);

int digitFirst = num/100;
int digitLast = num%10;

Console.WriteLine(digitFirst*10 + digitLast);
