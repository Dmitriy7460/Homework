// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = CreateArray(8);

WriteArray(array);
Console.Write(" -> [");
WriteArray(array);
Console.Write("]");


int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b");
}


