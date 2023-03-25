// 4. Напишите программу, которая на вход принимает два числа A и B,
//    и возводит число А в целую степень B с помощью рекурсии.

int ValueSet(int A, int B)
{
    if (B == 0) return 1;
    return ValueSet(A, B - 1) * A;
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(ValueSet(num1, num2));