// Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

void PrdoubleArray(double[,]origin)
{
    for (double i = 0; i < origin.GetLength(0); i++)
    {
        for (double j = 0; j < origin.GetLength(1); j++)
        {
           Console.Write($"{origin[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(double[,] origin)
{
    for (double i = 0; i < origin.GetLength(0); i++)
    {
        for (double j = 0; j < origin.GetLength(1); j++)
        {
            origin[i, j] = new Random().Next(1,10);
        }
    }
}

// void Copy(double[,] origin)
// {
//     for
// }

double row = double.Parse(Console.ReadLine()!);
double colm = double.Parse(Console.ReadLine()!);
double[,] origin = new double [row,colm];

FillArray(origin);
PrdoubleArray(origin);
