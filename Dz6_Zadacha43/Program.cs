// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



double k1 = InPut("k1");         
double b1 = InPut("b1");         
double k2 = InPut("k2");          
double b2 = InPut("b2");         

Checkout (k1,k2);



///\\\

 double InPut (string name)
 {
    Console.Write($"Введи {name}: ");  
    double num = Convert.ToInt64(Console.ReadLine());

    return num;
 }


void Checkout (double k1,double k2)
{
    if (k1 != k2)  FindingIntersection (k1, b1, k2, b2);

    else Console.WriteLine("Прямые параллельны.");
}


void FindingIntersection (double k1, double b1, double k2, double b2 )
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;

    PrintResult (x, y);
}


void PrintResult (double x, double y)
{
    Console.WriteLine("Кординаты точки пересечения:");
    Console.WriteLine($"x = {Math.Round(x,3)}");
    Console.WriteLine($"y = {Math.Round(y,3)}");
}