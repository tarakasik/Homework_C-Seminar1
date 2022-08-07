// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input first number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number: ");
int numC = Convert.ToInt32(Console.ReadLine());

if(numA > numB && numA > numC)
{
    Console.Write("Max = ");
    Console.WriteLine(numA);
}
else
{
    if(numB > numA && numB > numC)
    {
    Console.Write("Max = ");
    Console.WriteLine(numB);
    }

       else
      
       if(numC > numA && numC > numB)
       {
       Console.Write("Max = ");
       Console.WriteLine(numC);
       }
}
    