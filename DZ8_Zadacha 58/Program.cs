// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] matrix1 = CreateMatrixDobleRnd(2, 1, 1, 3);  // Строки, CОЛБЦЫ, Мин, Макс.
PrintMatrix(matrix1);

int[,] matrix2 = CreateMatrixDobleRnd(1, 3, 0, 3);  // СТРОКИ, Столбцы, Мин, Макс.
PrintMatrix(matrix2);

if (Check(matrix1, matrix2) == true)
{
    int[,] answer = Multiplication(matrix1, matrix2);
    PrintMatrix(answer);
}


//\\//\\//\\//\\//\\//\\


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
    Console.WriteLine();

    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        Console.Write("|");

        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            Console.Write($"{mtr[i, j],3}");
        }
        Console.WriteLine(" |");
    }
}

bool Check(int[,] first, int[,] second)
{
    bool reliability = (first.GetLength(1) == second.GetLength(0));

    if (reliability != true)
    {
        Console.WriteLine();
        Console.WriteLine("Число столбцов первой матрицы должо соответствовать числу строк второй матрицы.");
    };

    return reliability;
}

int[,] Multiplication(int[,] first, int[,] second)
{
    int rows = first.GetLength(0);
    int coloms = second.GetLength(1);
    int universal = first.GetLength(1);

    int[,] ans = new int[rows, coloms];


    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloms; j++)
        {
            ans[i, j] = 0;

            for (int k = 0; k < universal; k++)
            {
                ans[i, j] += first[i, k] * second[k, j];
            }
        }
    }

    return ans;
}