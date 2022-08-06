// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("Input first number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int numB = Convert.ToInt32(Console.ReadLine());
if(numA > numB)
{ 
Console.Write("Bigger = ");  
Console.WriteLine(numA); 
Console.Write("Lower = ");
Console.WriteLine(numB);
}
else
     {
     Console.Write("Bigger = ");
     Console.WriteLine(numB);
     Console.Write("Lower = ");
     Console.WriteLine(numA);  
     }
