// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

void mass(int length)
{
    int[] R = new int[length];
    for (int i=0; i<length; i++)
    {
        R[i] = new Random().Next(10);
        Console.Write(R[i]+", ");
    }
}

mass(int.Parse(Console.ReadLine()!));