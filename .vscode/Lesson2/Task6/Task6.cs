Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (num > 999)
{
    num /= 10;
    Console.WriteLine($"Третья цифра {num % 10}");
}
else
{
    Console.WriteLine($"Третья цифра {num % 10}");
}