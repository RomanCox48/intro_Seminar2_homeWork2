﻿// Задача 1: Напишите программу, 
// которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите целое число:"); //Запрос числа, для того, чтобы можно было проверить оба исхода

int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число " + number + " кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine("Число " + number + " некратно одновременно 7 и 23");
}