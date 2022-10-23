// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dear teacher, check my homework.");
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

// Пример ниже универсальный для ввода двух чисел.
Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    System.Console.WriteLine("Введены числа {0} {1} -> max = {0}", a , b);
}
else
{
    System.Console.WriteLine("Введены числа {0} {1} -> max = {0}", a , b);
}


