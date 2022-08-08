// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Clear();
// // aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");
// Console.Clear();
// // int i = 0;


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sqrt = number * number;
// // number *= number;
// // sqrt = Convert.ToInt32(Math.Pow(number, 2));

// Console.Write("Число в квадрате: " + sqrt);

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2*num2);
// {
//     Console.Write("First number");
// }




// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	// 3 -> Среда 
// 5 -> Пятница


// Console.Write("Input number of the day: ");

// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7)
// {
//     Console.Write("Incorrect number");
// }
// else
// {
//     if (day == 1)
//     {
//         Console.Write("Monday");
//     }
//     if (day == 2)
//     {
//         Console.Write("Tuesday");
//     }

// 4 Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

// выводим текст с запросом в терминал
Console.Write("Введите число: ");
// присваиваем переменной N введенное число
int N = Convert.ToInt32(Console.ReadLine());
// обяъвляем новую переменную, в которую сохраняем значение N с противоположным знаком
int B = -N;

// условный цикл, который будет "работать" до тех пор, пока значение переменной B меньше либо равно значению N
while (B <= N)
{
    // выводим на экран значение B и пробел
    Console.Write(B+ " ");
    // увеличиваем значение B на единицу
    B++; // B = B + 1 аналогично B += 1 
}
 
// // Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//  Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num <= 999){
//     int x = num % 10;
//     Console.WriteLine(x);
// }
// else{
//     Console.WriteLine("Введенное число не трехзначное");
// }
// //  или
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num <= 999){
//     Console.Write("Последняя цифра: " + Math.Abs(num) % 10);;
// }
// else{
//     Console.WriteLine("Введенное число не трехзначное");
// }



// Console.Write("Введите число: ");
// Console