// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введи числа:");                           //Последовательный ввод чисел.  
                                                            //Двойной Enter запускает вычисление.

int i = 0;
int[] arr = new int[50];

CreateArray(arr, i);

        //..\\

int[] CreateArray(int[] arr, int i)
{
    string abc = Console.ReadLine();

    if (abc.Length != 0)
      {
        arr[i] = Convert.ToInt32(abc);
        i++;
        CreateArray(arr, i);
      }
    else
      {
        // Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine(CountOfNumbers(arr));
      };

    return arr;
}

int CountOfNumbers(int[] arr)
{
    int Count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        int x = (arr[i] < 0) ? Count ++ : Count += 0;
    }
    return Count;
}




