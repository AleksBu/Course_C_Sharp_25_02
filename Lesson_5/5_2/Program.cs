// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void SumPosNeg(int[] arr, int num_1)
{


    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num_1) 
        {
          Console.WriteLine("Да");
          return;
        }
    }
    Console.WriteLine("No");
}


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int num_1 = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, start, stop);
Print(mass);
SumPosNeg(mass, num_1);