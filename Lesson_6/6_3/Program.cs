// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1.

void Fibo (int num_1)
{
    int A = 0;
    int B = 1; 
    for (int i = 0; i < num_1; i++)
    {
        Console.Write(A+" ");
        (A, B) = (B, A+B);
    }
}
int G = int.Parse(Console.ReadLine()!);
Fibo (G);