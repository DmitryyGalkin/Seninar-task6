﻿Console.Clear();

Console.WriteLine("Введите число: ");
string input = Console.ReadLine()!;
int number = int.Parse(input);

if (number % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}