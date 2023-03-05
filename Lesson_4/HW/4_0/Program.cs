// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int SumNum(int A, int B)
{
    int Degree = A;
    for (int i = 1; i < B; i++)
    {
        Degree = Degree * A;
    }
    return Degree;
}

int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int result = SumNum(A, B);
Console.WriteLine(result);