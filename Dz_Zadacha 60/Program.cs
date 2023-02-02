// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int maximum = 28;
int minimum = 20;
int range = (maximum - minimum + 1);


int[,,] matrix = CreateMatrix(2, 2, 2, minimum, maximum);

PrintMatrix(matrix);



int[,,] CreateMatrix(int x, int y, int z, int min, int max)
{
    int count = 0;//////
    int[] array = new int[range];
    int[,,] mtr = new int[x, y, z];

    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            for (int k = 0; k < mtr.GetLength(2); k++)
            {
                array[count] = CheckRepit(min, max, array, count);
                mtr[i, j, k] = array[count];

                count++;
            }
        }
    }

    return mtr;
}

int CheckRepit(int min, int max, int[] arr, int co)
{
    Random rnd = new Random();
    int a = 0;
    bool rep = true;

    while (rep == true)
    {
        a = rnd.Next(min, max + 1);
        rep = false;

        for (int i = 0; i < co + 1; i++)
        { if (arr[i] == a) { rep = true; } }
    }
    return a;
}

void PrintMatrix(int[,,] mtr)
{
    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            for (int k = 0; k < mtr.GetLength(2); k++)
            {
                Console.Write($"{mtr[i, j, k]} {(i, j, k)},  ");
            }
        }
    }
    Console.WriteLine($"\b\b\b. ");

}