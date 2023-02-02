// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] matrix = CreateMatrixDobleNul(4, 4);  // Строки, Столбцы.
PrintMatrix(matrix);



int[,] CreateMatrixDobleNul(int rows, int coloms)
{
    int[,] mtr = new int[rows, coloms];

    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            mtr[i, j] = 0;
        }
    }
    PathFiender(mtr);
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

int[,] PathFiender(int[,] mtr)
{
    int raw = mtr.GetLength(0);
    int col = mtr.GetLength(1);
    int count = 1;



int i = 0;
int j = 0;

mtr[i, j] = count;
count++;

 while (count < col*raw+1)
 {

 if ((j < col-1)&&(mtr[i, j + 1] == 0))
    {while ((j < col-1)&&(mtr[i, j + 1] == 0))
    {mtr[i, j + 1] = count; j++; count++;}}
    

    else if ((i < raw-1)&&(mtr[i + 1, j] == 0))  
     {while((i < raw-1)&&(mtr[i + 1, j] == 0))
     {mtr[i + 1, j] = count; i++; count++;}}


    else if ( (j > 0)&&(mtr[i, j - 1] == 0)) 
     {while ((j > 0)&&(mtr[i, j - 1] == 0))
     {mtr[i, j - 1] = count; j--; count++;}}


    else if ( (i > 0 )&&(mtr[i - 1, j] == 0))  
     {while ((i > 0 )&&(mtr[i - 1, j] == 0)) 
     {mtr[i - 1, j] = count; i--; count++;}} 

    
    }
   return mtr; 
}
   
