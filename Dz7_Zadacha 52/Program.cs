// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




int[,] matrix = CreateMatrixDobleRnd(5, 12, -3, 3);  //строки, столбцы, мин, макс
PrintMatrix(matrix);

PrintAnswer(Сalculations(matrix));


//\\//\\//\\//\\


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
            Console.Write($"{mtr[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

double[] Сalculations (int[,] mtr)
{
    double[] temp = new double[mtr.GetLength(1)];

    for (int i = 0; i < mtr.GetLength(1); i++)
    {
        for (int j = 0; j < mtr.GetLength(0); j++)
        {
            temp[i] += mtr[j,i];
        }
        temp[i] = temp[i] / mtr.GetLength(0);
        temp[i] = Math.Round(temp[i],2);
        //Console.WriteLine( temp[i]);
    }
    return temp;
}

void PrintAnswer (double[] arrr)
{ 
    Console.WriteLine();
    Console.WriteLine($"{String.Join(";  ",arrr)}");
}

