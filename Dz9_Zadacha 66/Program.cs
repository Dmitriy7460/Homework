// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.Write("Введи число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи число 2 : ");
int number2 = Convert.ToInt32(Console.ReadLine());

int rezult = number1;



Console.WriteLine($"Cумма натуральных элементов в промежутке от {number1} до {number2} = {SumOfArray(number1,number2,rezult) }  ");
     


//\\//\\//\\//\\

int SumOfArray(int num1, int num2, int rez)
{
     if (rez == num2)  return num2;
    
    else  
       { 
        int universal = (num2 - num1) / (Math.Abs(num2 - num1));
        return rez + SumOfArray(num1, num2, rez += universal);
      }  
}
