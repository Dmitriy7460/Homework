//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введи день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

 if (7 < day || day < 1)
    Console.WriteLine("Некорректный ввод данных");
    else BlackBox(day);


 void BlackBox(int a)
    {
    if (a > 5) 
    Console.WriteLine ("да");
    else  Console.WriteLine ("нет");
    }


