﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int GetSumNumbers (int number)
{
    int number_Z = number;
    int sum = 0;
    while (number > 0)
    {
        sum += number %10;
        number /=10;
    }
    Console.WriteLine($"Сумма чисел в {number_Z} равна {sum}");
    return sum;
}
Console.WriteLine ("Введите число: ");
GetSumNumbers (Convert.ToInt32(Console.ReadLine()));
