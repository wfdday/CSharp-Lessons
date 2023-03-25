Console.Clear();

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = m; i <= n; i++)
{
    sum += i;
}

Console.WriteLine($"M = {m}; N = {n} -> {sum}");

Console.ReadKey();