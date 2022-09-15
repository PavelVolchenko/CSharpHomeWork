int number = new Random().Next(1, 101);
if (number % 2 == 0)
{
    Console.Write("Число ");
    Console.Write(number);
    Console.Write(" является четным!");
}
else
{
    Console.Write("Число ");
    Console.Write(number);
    Console.Write(" является нечетным!");
}