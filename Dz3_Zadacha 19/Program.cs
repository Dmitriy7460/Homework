// Задача 19 Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введи пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0) number = Math.Abs(number);
int rebmun = (BlackBox(number));


if (number == rebmun) Console.WriteLine("Да");
if (number != rebmun) Console.WriteLine("Нет");

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