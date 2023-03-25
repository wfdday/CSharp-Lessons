Console.Clear();

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"N = {n} -> ");
PrintNumbers(n);

Console.ReadKey();

static void PrintNumbers(int n)
{
    Console.Write($"{n}");

    if (n > 1)
    {
        Console.Write(", ");
        PrintNumbers(n - 1);
    }
}