// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());


int SumOfTheSeries(int num)
{
    num = Math.Abs(num);
    int sum = 0;
    while (num > 0)
    {
        int temp = num % 10;
        sum = sum + temp;
        num = num / 10;
    }
    return (sum);
}

int temp = SumOfTheSeries(number);

Console.WriteLine($"{number} -> {temp}");