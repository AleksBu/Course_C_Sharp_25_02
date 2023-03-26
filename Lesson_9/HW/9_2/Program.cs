// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

int ValuesSet(int M, int N)
{
    int sum = N;
    if (N < M) return 0;
    return ValuesSet(M , N - 1) + sum;
    
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(ValuesSet(num1, num2));