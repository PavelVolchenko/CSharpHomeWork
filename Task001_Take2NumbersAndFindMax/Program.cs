int a = new Random().Next(1, 101);
int b = new Random().Next(1, 101);
int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}

Console.Write("a = ");
Console.WriteLine(a);

Console.Write("b = ");
Console.WriteLine(b);

Console.Write("max = ");
Console.WriteLine(max);