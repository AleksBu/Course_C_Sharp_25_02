// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.

void mass(int length)
{
    int[] R = new int[length];
    for (int i=0; i<length; i++)
    {
        R[i] = new Random().Next(2);
        Console.Write(R[i]);
    }
}

mass(int.Parse(Console.ReadLine()!));