string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;
string s_c = Console.ReadLine()!;

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);
int max = a;

if (a < b)
{
    max = b;  
}

if (b < c)
{
    max = c;
}

Console.WriteLine(max);