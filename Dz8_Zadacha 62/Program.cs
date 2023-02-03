// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


string[,] matrix = CreateMatrixDobleNul(7, 4);  // Строки, Столбцы.
PrintMatrix(matrix);


string[,] CreateMatrixDobleNul(int rows, int coloms)
{
    string[,] mtr = new string[rows, coloms];

    PathFiender(mtr);
    return mtr;
}

void PrintMatrix(string[,] mtr)
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

string[,] PathFiender(string[,] mtr)
{
    int raw = mtr.GetLength(0);
    int col = mtr.GetLength(1);
    int count = 1;

    int i = 0;
    int j = 0;

    mtr[i, j] = Check(count);
    count++;

    while (count < col * raw + 1)
    {
        while ((j < col - 1) && (String.IsNullOrEmpty(mtr[i, j + 1])))
        { mtr[i, j + 1] = Check(count); j++; count++; }
        
        while ((i < raw - 1) && (String.IsNullOrEmpty(mtr[i + 1, j])))
        { mtr[i + 1, j] = Check(count); i++; count++; }
        
        while ((j > 0) && (String.IsNullOrEmpty(mtr[i, j - 1])))
        { mtr[i, j - 1] = Check(count); j--; count++; }
      
        while ((i > 0) && (String.IsNullOrEmpty(mtr[i - 1, j])))
        { mtr[i - 1, j] = Check(count); i--; count++; }      
    }
    return mtr;
}

string Check(int co)
{
    if (co <= 9) { return ("0" + $"{co}"); }
    else { return ($"{co}"); }
}