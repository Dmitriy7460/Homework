// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите степень: ");
int exponent = int.Parse(Console.ReadLine());

int answer = 1;

if (exponent > 0)
{
    answer = Exponentiation(number, exponent);
}

if (exponent < 0)
{
    answer = Root(number, exponent);
}

Console.WriteLine(answer);




int Exponentiation(int num, int exp)
{
    int temp = num;

    for (int i = exp; i > 1; i = i - 1)
    {
        num = num * temp;
    }
    return (num);
}

int Root(int num, int exp)      //Попробовал без класса "Math", вышло не очень)
{
    int temp = 1;
    int temp1 = 1;

    while (num != temp)
    {
      temp = 1;
      temp1++;

    for (int i = exp; i < 0; i++)
    {
        temp = temp * temp1;
     }
    } return (temp1);
}

