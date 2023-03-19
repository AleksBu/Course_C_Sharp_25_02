// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{string.Format("{0:F2}", arr[i, j])} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column, double from, double to)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Random rnd = new Random();
            arr[i, j] = rnd.NextDouble() * (to + from) - from;
        }
    }
    return arr;
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
double start = double.Parse(Console.ReadLine()!);
double stop = double.Parse(Console.ReadLine()!);

double[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);