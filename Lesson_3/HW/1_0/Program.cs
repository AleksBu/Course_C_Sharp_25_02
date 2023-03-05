// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом

void Pal(int num)
{
    if (num < 99999 && num > 9999)
    {
        if (num % 10 == num / 10000 && (num % 100)/10 == (num / 1000)%10)
        Console.WriteLine("Yes");
        else 
        Console.WriteLine("No");
    } 
    else Console.WriteLine("it's not 5-th digit number");
}
Pal (int.Parse(Console.ReadLine()!));
