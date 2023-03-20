// Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пресечении которых
// расположен наименьший элемент масссива.

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

int []CoordinMin(int[,] arr)
{
    int min = arr[0,0];
    int []coordinate = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
      for (int j = 0; j < arr.GetLength(1); j++)
        if (min > arr[i, j])
        {
            min = arr[i, j];
            coordinate[0] = i;
            coordinate[1] = j;
        }
    Console.WriteLine(min);
    Console.WriteLine(coordinate[0]);
    Console.WriteLine(coordinate[1]);
return coordinate;
}

void PrintDel(int[,] arr, int[] arrdel)
{
  for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        if (i != arrdel[0] && j != arrdel[1])
        {
            Console.Write($" {arr[i, j]} ");
        }
        else Console.Write($"");
      }
    Console.WriteLine();
    }
}
Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
int[] coord = CoordinMin(mass);
PrintDel(mass, coord);

