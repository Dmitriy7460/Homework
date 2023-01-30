// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

char[] exceptions = new char[]{',', '.', ' ', ';'};


int[,] matrix = CreateMatrixDobleRnd(5, 3, -9, 9);  //строки, столбцы, мин, макс
PrintMatrix(matrix);
Check(Input(exceptions),matrix);


//\\//\\//\\//\\


string[] Input (char[] exp)
{
    Console.Write("Введи номера строки и столбца через пробел, точку или запятую: ");
    string num = Console.ReadLine();
    string[] stringOfNum = num.Split(exp);

    return stringOfNum;
}

void Check(string[]num, int[,]matr)
{
    
    int x = Convert.ToInt32(num[0]);
    int y =  Convert.ToInt32(num[1]);

    if ((x<=0) || (y<=0) || (x > matr.GetLength(0)) || (y > matr.GetLength(1)))
    {Console.WriteLine("Введены неверные значения");}

    else
    {Console.WriteLine($"Значение элемента на {x} строке и {y} столбще равняется {matr[x-1,y-1]}.");}
}

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

