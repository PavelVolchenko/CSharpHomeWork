int a = new Random().Next(-101, 101);
int b = new Random().Next(-101, 101);
int max = 0;
int min = 0;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

Console.Write("a = ");
Console.WriteLine(a);

Console.Write("b = ");
Console.WriteLine(b);

Console.Write($"max = {max} min = {min}");