// 1. Напишите программу, которая выводит случайное число
//    из отрезка [10, 99] и показывает наибольшую цифру числа.

int TakeNum(int num)
{
    int result1 = num % 10;
    int result2 = num / 10;
    if (result1 > result2)
    {
        return result1;
    }
    else
    {
        return result2;
    }
}

int itog = TakeNum(new Random().Next(10, 100));
Console.WriteLine(itog);