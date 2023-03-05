Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");

if (num >= 6 && num <=7)
{
    Console.WriteLine($"{num} -> Да");
}
else if (num < 1 || num > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
else
{
    Console.WriteLine($"{num} -> Нет");
}