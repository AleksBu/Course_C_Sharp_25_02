void Find(int num)
{
    if (num < 100)
    
        Console.WriteLine("This number has less then three figures");
    
    else     
    {
        while (num > 999)
        {
            num = num/10;
        }
    num = num%10;
    Console.WriteLine(num);
    }
    
}
Find(int.Parse(Console.ReadLine()!));