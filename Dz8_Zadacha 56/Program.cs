// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] matrix = CreateMatrixDobleRnd(5, 5, -99, 99);  // Строки, Столбцы, Мин, Макс.

PrintMatrix (matrix);
Console.WriteLine("");
Check(matrix);

//\\//\\//\\//\\//\\//\\//\\

int[,] CreateMatrixDobleRnd(int rows, int coloms, int min, int max)
{
    Random rnd = new Random();
    int[,] mtr = new int[rows, coloms];

    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            mtr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return mtr;
}

void PrintMatrix(int[,] mtr)
{
    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        Console.Write("|");

        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            Console.Write($"{mtr[i, j],4}");
        }
        Console.WriteLine(" |");
    }
}

void Check (int[,]mtr)
{
    int[,] temp = new int[mtr.GetLength(0),2];

    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        temp[i,0] += i+1;

        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            temp[i,1] += mtr[i,j];
        }
         //Console.Write($"{temp[i,0]} / ");
         //Console.WriteLine(temp[i,1]);
    } 

    Control(temp);
    PrintResolt(FindResolt(temp));
}

int FindResolt (int[,] mtr)
{
    int min = mtr[0,1];
    int count = mtr[0,0];

    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        if (mtr[i,1] < min)
       {
        min = mtr[i,1];
        count = mtr[i,0];
        }
    }
    return count;
}

void PrintResolt(int number)
{
    Console.WriteLine($"Наименьшая сумма элементов: {number} строка");
}

void Control(int[,] num)
{
    for (int i = 0; i <num.GetLength(0); i++)
    {
    Console.Write($"{num[i,0]} / ");
    Console.WriteLine(num[i,1]);
    }
}
