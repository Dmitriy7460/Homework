// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.


int[,] matrix = CreateMatrixDobleRnd(5, 10, -99, 99);  // Строки, Столбцы, Мин, Макс.

PrintMatrix (matrix);
Console.WriteLine();
matrix = SortMatrix(matrix);
PrintMatrix (matrix);


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

int[,] SortMatrix(int[,] mtr)
{
    int [] temp = new int[mtr.GetLength(1)];

    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        for (int j = 0; j < mtr.GetLength(1); j++)
             {temp[j] = mtr[i,j];}

        SortRawsMatrix(temp); 

        for (int j = 0; j < mtr.GetLength(1); j++)
                {mtr[i,j] = temp[j];}
    } 
    return mtr;
}

int[] SortRawsMatrix(int[] arr)
{
    int temp = 0;
    int count = 1;

while ((arr.Length-count)>0)
    
    {
        for (int i = 0; i < arr.Length-count; i++)
        {
            if (arr[i]<arr[i+1])
            {
                temp = arr[i];
                arr[i]=arr[i+1];
                arr[i+1] = temp;
            }
        }
        count++;
    }

    return arr;
}