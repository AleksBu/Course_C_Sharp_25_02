// Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

void PrintArray(double[,] origin)
{
    for (int i = 0; i < origin.GetLength(0); i++)
    {
        for (int j = 0; j < origin.GetLength(1); j++)
        {
            Console.Write($"{string.Format("{0:F2}", origin[i, j])} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(double[,] origin)
{
    for (int i = 0; i < origin.GetLength(0); i++)
    {
        for (int j = 0; j < origin.GetLength(1); j++)
        {
            Random rnd = new Random();
            origin[i, j] = rnd.NextDouble() * (9.9 + 0.1) - 0.1;
        }
    }
}

void CopyPast(double[,] origin, double[,] copy)
{   
    for (int i = 0; i < origin.GetLength(0); i++)
    {
        for (int j = 0; j < copy.GetLength(1); j++)
        {
            copy[i, j] = origin[i, j];
            Console.Write($"{string.Format("{0:F2}", copy[i, j])} ");
        }
        Console.WriteLine();
    }
}

int row = int.Parse(Console.ReadLine()!);
int colm = int.Parse(Console.ReadLine()!);
double[,] origin = new double[row, colm];
double[,] copy = new double[row, colm];

FillArray(origin);
PrintArray(origin);
CopyPast(origin, copy);



