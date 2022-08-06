// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input number : ");
int EvenNum = Convert.ToInt32(Console.ReadLine());

if(EvenNum % 2 == 0)
Console.Write("Even number!");
else
Console.Write("Incorrect number!");