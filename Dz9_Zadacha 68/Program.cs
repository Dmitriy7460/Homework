// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("A[m,n]");

Console.Write("Введи m: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи n: ");
int n2 = Convert.ToInt32(Console.ReadLine());


int answer = 0;
Console.Write($"{Akker(m1, n2)}");


//\\//\\//\\//\\

int Akker(int m, int n)
{
    if (m == 0) return ++n;
    else if (n == 0) return Akker(--m, 1);

    else return Akker(m - 1, Akker(m, --n));
}