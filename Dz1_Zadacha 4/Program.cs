﻿//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22

Console.WriteLine("Введите 3 числа");
int max = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (b > max && b > c) { max = b; }
if (c > max && c > b) { max = c; }

Console.WriteLine($"max={max}");