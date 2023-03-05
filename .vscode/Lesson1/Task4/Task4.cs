Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");
Console.Write($"{num} ->");
for (int i = 1; i <= num; i++)
    if (i % 2 == 0)
        Console.Write($" {i}");
