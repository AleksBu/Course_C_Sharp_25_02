// / 2. Напишите программу, которая будет выдавать название дня
//    недели по заданному номеру.

string s_a = Console.ReadLine()!;

if (s_a == "1")
{
    Console.WriteLine("Пн");
}
else if (s_a == "2")
{
    Console.WriteLine("Вт");
}
else if (s_a == "3")
{
    Console.WriteLine("Ср");
}
else if (s_a == "4")
{
    Console.WriteLine("Чт");
}
else if (s_a == "5")
{
    Console.WriteLine("Пт");
}
else if (s_a == "6")
{
    Console.WriteLine("Сб");
}
else if (s_a == "7")
{
    Console.WriteLine("Вс");
}

else 
{
    Console.WriteLine("Ошибка");
}