// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dear teacher, check my homework.");
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Пример ниже универсальный для ввода трех чисел.
Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число с");
int d = Convert.ToInt32(Console.ReadLine());
if (a>b ^ b>d)
{
   if(a>d)
    {
        System.Console.WriteLine($"Введены числа {a} {b} {d}-> max = {a}");
    }
    else
    {
        System.Console.WriteLine($"Введены числа {a} {b} {d}-> max = {d}");
    }
}
else 
{
    if (b>d)
    {
        System.Console.WriteLine($"Введены числа {a} {b} {d}-> max = {b}");
    }
    else
    {
        System.Console.WriteLine($"Введены числа {a} {b} {d}-> max = {d}");
    }
}