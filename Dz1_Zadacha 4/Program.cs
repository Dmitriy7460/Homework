
Console.WriteLine("Введите 3 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b>a && b>c) {max=b;}
if (c>a && c>b) {max=c;}


Console.WriteLine($"max={max}");