Console.Clear();

Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());

Console.Write("{0} -> ", n);
for (int i = 1; i <= n; i++)
{
    int cube = i * i * i;
    Console.Write(cube);
    if (i != n)
    {
        Console.Write(", ");
    }
}