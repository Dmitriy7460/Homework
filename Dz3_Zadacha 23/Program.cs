// Задача 23 Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введи число: ");
int number = Convert.ToInt32 (Console.ReadLine());


if (number > 0)
 {
    bool znach = true;
    Box(number, znach);
}

if (number<0)
{
    bool znach = false;
    Box(-number,znach);
}



void Box (int a, bool b)
{
int i = 0;
while (i < a)
{
  i ++;  

string c = b == true 
? c = Convert.ToString($"{i,3} | {i*i*i,3}")
: c = Convert.ToString($"{i,3} | {-i*i*i,3}");

Console.WriteLine(c);
}
}