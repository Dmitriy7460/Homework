// Console.WriteLine("Веди число");

// int number = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(number+2);

// PrintArray(array);



// int[] CreateArray(int num)
// {

//   int[] arr  = new int[num];
//     arr[0] =0;
//     arr[1] = 1;

//   for (int i = 2; i < arr.Length; i++)  
//     {
//      arr[i] = arr[i-1]+arr[i-2];
//    }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < number; i++)
//     {
//         Console.Write($"{arr[i]}; ");
//     }
//     Console.Write("\b\b]");
// }


///\\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\\

// int[] array1 = CreateArrayRnd(10, 0, 5);
// int[] array2 = CoppyArray(array1);

// PrintArray(array1);
// PrintArray(array2);


// int[] CreateArrayRnd(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}; ");
//     }
//     Console.WriteLine("\b\b]");
// }

// int[] CoppyArray(int[] arr)
// {
//     int[] arr2 = new int[arr.Length];

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr2[i] = arr[i];
//     }
//     return arr2;
// }





// Задайте двумерный массив m на n, каждый элемент в массиве находится по формуле:
// Amn = m + n.
// Выведитк полученный массив на экран:

// m = 3, n = 4.

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] matrix = CreateMatrixRnd (3,4,-10,10);
// PrintMatrix(matrix);


//     //\\//\\//\\//\\

// int[,] CreateMatrixRnd (int round, int coloms, int min, int max)
// {
//   //Random rnd = new Random();
//   int[,] matr = new int[round,coloms];

//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//      // matr[i,j] = rnd.Next(min, max + 1);
//       matr[i,j] = i+j;
//     }
//   }

//   return matr;
// }

// void PrintMatrix (int[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     Console.Write("|");
//       for (int j = 0; j < matr.GetLength(1); j++)
//       {
//         Console.Write($"{matr[i,j], 4} ");
//       }
//     Console.WriteLine(" |");
//   }
// }






////////////////////////////////////////////////


