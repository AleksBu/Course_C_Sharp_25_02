// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[,] Product(int[,] arr1, int[,] arr2)
{
    int[,] prod = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(0) != arr2.GetLength(1))
    {
        Console.WriteLine("The size of matrixes is incorrect");
    }
    else
    {

        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr2.GetLength(0); k++)
                {
                    prod[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
        
    }
return prod;
}


Console.Write("Enter the number of rows1: ");
int row_num1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns1: ");
int column_num1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of rows2: ");
int row_num2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns2: ");
int column_num2 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massives ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massives ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass1 = MassNums(row_num1, column_num1, start, stop);
int[,] mass2 = MassNums(row_num2, column_num2, start, stop);
Print(mass1);
Print(mass2);
int[,] massX = Product(mass1, mass2);
Print(massX);
