// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.Write("Введи число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи число 2 : ");
int number2 = Convert.ToInt32(Console.ReadLine());

int rezult = number1;
int summa = number1;

SumOfArray(number1, number2, rezult, summa);

//\\//\\//\\//

void SumOfArray(int num1, int num2, int rez, int sum)//
{
    int universal = (num2 - num1) / (Math.Abs(num2 - num1));

    if (rez == num2)
    {
        Console.WriteLine($"Cумма натуральных элементов в промежутке от {num1} до {num2} = {sum }  ");
        return;
    }
    
    SumOfArray(num1, num2, rez += universal, sum += rez);
}
