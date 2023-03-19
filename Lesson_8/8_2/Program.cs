// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9


 void Print(int[,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
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

int[] Vocab(int[,] arr)
{
    int [] arr_new = new int [10];
    foreach (int count in arr) arr_new [count]++;
    return arr_new;
}

void Print_2(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($" {i} - {arr[i]} ");
    Console.WriteLine();
  }
  Console.WriteLine();  
}

Console.WriteLine("Введите количество строк массива");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок массива");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте минимальное число в массиве");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте максмальное число в массиве");
int stop = int.Parse(Console.ReadLine()!);


int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
Print_2(Vocab(mass));