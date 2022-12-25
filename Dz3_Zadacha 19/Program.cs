// Задача 19 Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введи пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0) number = Math.Abs(number);

if ((number > -10000 && number < 1000) ||(number>99999)||(number<-99999))
    Console.WriteLine ("Число не удовлетворяет условиям задачи");
else 
    {
    int rebmun = (BlackBox(number));
    if (number == rebmun) Console.WriteLine("Да");
    if (number != rebmun) Console.WriteLine("Нет");
    }



int BlackBox(int chislo)
{
    int re = 0;

    while (chislo > 0)
    {
        int ind = chislo;
        ind = ind % 10;
        chislo = chislo / 10;
        re = re * 10 + ind;
    }
    return re;
}