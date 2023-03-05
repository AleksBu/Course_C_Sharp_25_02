// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int num)
{
    for(int i = 1; i <=num; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }

}
int x = int.Parse(Console.ReadLine()!);
Cube(x);