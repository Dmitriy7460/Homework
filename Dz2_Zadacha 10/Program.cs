﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа. Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write ("Введи трехзначное число ");
int number = Convert.ToInt32 (Console.ReadLine());
Console.Write (Function (number));



int Function (int a)
{
      int b = a/10 -a/100*10;
       return b;
}