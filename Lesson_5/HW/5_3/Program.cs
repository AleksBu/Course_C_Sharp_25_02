//  Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.


void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($" {string.Format("{0:F2}", arr[i])}");
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (99.99 - 0.01) + 0.01;
    }
    return arr;
}

void Difference(double[] arr)
{
    double dif = 0;
    double max = arr[0];
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    dif = max - min;
    Console.WriteLine($"The differeance between max and min is {string.Format("{0:F2}", dif)}");
}

int num = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num);
Print(mass);
Difference(mass);

