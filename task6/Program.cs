/*
Программа, на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/ 

Console.WriteLine("Ввведите число a:");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("a=" + firstNum);

int i = firstNum % 2;

if (i == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

