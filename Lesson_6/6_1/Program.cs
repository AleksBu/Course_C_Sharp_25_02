// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.

void Tringl (int A, int B, int C)
{
    if (A < B + C && B < A + C && C < A + B)
    Console.WriteLine($"Yes, Triangle exist");
    else Console.WriteLine($"No, trinangle not exist");
}   
int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
int num_3 = int.Parse(Console.ReadLine()!);

Tringl(num_1, num_2, num_3);


// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины

// void Trngl (int A, int B, int C)
// {
//     if (A < B + C && B < A + C && C < A + B)
//     Console.WriteLine($"Да, такой треугольник может быть");
//     else Console.WriteLine($"Нет, такого треугольника не может быть");
// }
// int num_1 = int.Parse(Console.ReadLine()!);
// int num_2 = int.Parse(Console.ReadLine()!);
// int num_3 = int.Parse(Console.ReadLine()!);

// Trngl(num_1, num_2, num_3);