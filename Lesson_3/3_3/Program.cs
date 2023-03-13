// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

void Kvad(int num)
{
    for(int i = 1; i <=num; i++)
    {
        Console.Write(i * i +" ,");
    }

}
int x = int.Parse(Console.ReadLine()!);
Kvad(x);