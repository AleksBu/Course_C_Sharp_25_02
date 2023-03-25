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


// // 2. Задайте значения M и N. Напишите программу, которая 
// //    рекурсивно выведет все натуральные числа в промежутке от M до N.


// void ValuesSet(int M, int N)
// {
//     if (N < M) return;
//     ValuesSet(M , N- 1);
//     Console.Write($"{N} ");
// }

// int num1 = int.Parse(Console.ReadLine()!);
// int num2 = int.Parse(Console.ReadLine()!);
// ValuesSet(num1, num2);