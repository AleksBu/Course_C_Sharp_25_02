string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int max = 0;

if (a > b)
{
    max = a;
    Console.WriteLine(max);
}

else if (a < b)
{
    max = b;
    Console.WriteLine(max);
}

else
{
    Console.WriteLine("the numbers are equal");
}

