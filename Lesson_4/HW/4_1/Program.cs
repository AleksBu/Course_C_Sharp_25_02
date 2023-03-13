// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sum(int num)
{
    int summa = 0;
    for (int i = 1; num > 0; i++)
    {
        summa = summa + num % 10;
        num = num / 10;
    }
    
    return summa;
    
}

int A = int.Parse(Console.ReadLine()!);
int result = sum(A);
Console.WriteLine(result);