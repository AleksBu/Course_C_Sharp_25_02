// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.


string convert(int num_1)
{
    string result = "";
    while (num_1 > 0)
    {
        result = num_1 % 2 + result;
        num_1 /= 2;
    }
    return result;
}
Console.WriteLine (convert(45)!);


// string Binary(int num)
// {
//     string res = "";

//     while (num > 0)
//     {
//         res = num % 2 + res;
//         num /= 2;
//     }
//     return res;
// }

// // 12 - 1100, 4 - 100, 45 - 101101
// int n = int.Parse(Console.ReadLine()!);
// string result = Binary(n);
// Console.WriteLine(result);