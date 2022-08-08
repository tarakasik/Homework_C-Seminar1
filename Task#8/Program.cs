// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N);
    {
        if(i % 2 == 0)
        {
        Console.WriteLine($"All even numbers [1, N]: {i}");
        }
i = i + 2;
    }
// i++;
//    else if(i % 2 == 0);
//    Console.WriteLine()





