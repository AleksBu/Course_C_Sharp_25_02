// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

void ValueSet(int N, int M)
{
    if (N == M - 1) return;
    ValueSet(N - 1, M);
    Console.Write($"{N} ");
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
ValueSet(num1, num2);