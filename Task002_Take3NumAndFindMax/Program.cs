int a = new Random().Next(-100, 101);
int b = new Random().Next(-100, 101);
int c = new Random().Next(-100, 101);
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("a = ");
Console.WriteLine(a);

Console.Write("b = ");
Console.WriteLine(b);

Console.Write("c = ");
Console.WriteLine(c);

Console.Write("max = ");
Console.WriteLine(max);