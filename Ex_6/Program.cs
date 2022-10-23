// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dear teacher, check my homework.");
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число number");
int number = Convert.ToInt32(Console.ReadLine());

if ( number % 2 == 0)
{
    System.Console.WriteLine("четное число");
}
else
{
    System.Console.WriteLine("не четное число");
}