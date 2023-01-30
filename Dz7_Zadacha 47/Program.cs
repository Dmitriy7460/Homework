// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



Console.Write("Введи число строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число столбцов: ");
    int coloms = Convert.ToInt32(Console.ReadLine());

double[,] matrix = CreateMatrixDobleRnd(rows, coloms, -10, 10);
PrintMatrix(matrix);


//\\//\\//\\//\\

double[,] CreateMatrixDobleRnd(int rows, int coloms, int min, int max)
{
    Random rnd = new Random();
    double[,] mtr = new double[rows, coloms];

    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            mtr[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return mtr;
}

void PrintMatrix(double[,] mtr)
{
    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        Console.Write("|");

        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            double temp = Math.Round(mtr[i, j], 2);
            Console.Write($"{temp,6}");
        }
        Console.WriteLine(" |");
    }
}