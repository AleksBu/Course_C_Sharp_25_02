// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;  значения b1, k1, b2 и k2 задаются пользователем.

void CrossLine (double b1, double k1, double b2, double k2)
{
    if ((k1 == k2) && (b1 == b2))
        Console.WriteLine("Прямые совпадают");

    else if (k1==k2)
        Console.WriteLine("Прямые параллельны");

    else 
    {
        double cross_X = (b2-b1)/(k1-k2);
        double cross_Y = (k1*(b2-b1))/(k1-k2)+b1;     
        Console.WriteLine($"cross_X= {cross_X}");
        Console.Write($"cross_Y= {cross_Y}");
    }
    return;
}
Console.WriteLine("Input b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Input k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Input b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Input k2: ");
double k2 = double.Parse(Console.ReadLine()!);
CrossLine (b1, k1, b2, k2);