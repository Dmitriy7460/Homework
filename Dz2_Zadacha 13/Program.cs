//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, 
//остаток от деления).
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());


int MagickBox(int a)
{
    while (a  > 1000)
    {
        a = a / 10;
    }
    a = a % 10; 
    return (a);
}


if (number <100)
    Console.WriteLine("Третьей цифры нет");
 else
    Console.WriteLine(MagickBox(number));

 