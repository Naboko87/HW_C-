// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dear teacher, check my homework.");

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число number");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("четные числа");
for (int a = 1; a < number; a++)
{ 
    if (a % 2 == 0)
    {
        System.Console.Write($"{a} ; ");
    }
}