// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



int size = 5, minVal = -10, maxVal = 10;

double[] array = CreateArray(size, minVal, maxVal);
PrintArray(array);
Console.WriteLine($" -> {SearchForMax(array)-SearchForMin(array)}");

Console.WriteLine($" Max: {SearchForMax(array),3}");
Console.WriteLine($" Min: {SearchForMin(array),3}");


////////////////////////////////////

double[] CreateArray(int s, int min, int max)
{
    double[] arr = new double[s];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()*(max-min)+min;
        arr[i] = Math.Round(arr[i],1);
    }
    return arr;
};

double SearchForMax(double[] arr)
{
    double max = arr[0];
    
    for (int i = 1; i < arr.Length; i ++)
    {
        if (max<arr[i]) 
        {
            max = arr[i];
        }
    }
    return max;
};

double SearchForMin(double[] arr)
{
    double min = arr[0];
    
    for (int i = 1; i < arr.Length; i ++)
    {
        if (min>arr[i]) 
        {
            min = arr[i];
        }
    }
    return min;
};

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
    Console.Write("\b\b]");
};
