/*
Программа, принимает на 
вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число a:");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("a=" + firstNum);

Console.WriteLine("Введите число b:");
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine("b=" + secondNum);

Console.WriteLine("Введите число c:");
int therdNum = int.Parse(Console.ReadLine());
Console.WriteLine("c=" + therdNum);

int max = firstNum;

if (secondNum > max) max = secondNum;
if (therdNum > max) max = therdNum;
Console.WriteLine("max=" + max);
