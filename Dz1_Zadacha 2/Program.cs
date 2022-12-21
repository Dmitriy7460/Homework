Console.Write("Введи первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());


if (number1 > number2) { Console.WriteLine($"max = {number1},min = {number2}"); }
else if (number1 < number2) { Console.WriteLine($"max={number2},min={number1}");}
else if (number1 == number2) { Console.WriteLine("Введенные значения не удовлетворяют условиям задачи.");}

