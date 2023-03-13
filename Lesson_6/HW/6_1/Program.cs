// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = int.Parse(Console.ReadLine()!);
    return arr;
}

void CMas(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0)  count += 1;
    Console.WriteLine(count);
}

int M = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(M);
Print(mass);
CMas(mass);
