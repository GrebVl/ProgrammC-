/*
Программа, на вход принимает два числа 
и выдаёт максимальное из этих чисел.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите число a:");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("a=" + firstNum);

Console.WriteLine("Введите число b:");
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine("b=" + secondNum);

if (firstNum > secondNum)
{
    Console.WriteLine("max=" + firstNum);
}
else if (secondNum > firstNum)
{
    Console.WriteLine("max=" + secondNum);
}
else
{
    Console.WriteLine("max=a=b=" + firstNum);
}
