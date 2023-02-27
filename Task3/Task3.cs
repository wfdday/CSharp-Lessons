Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");
if(num % 2 == 0)
    Console.WriteLine($"{num} -> да");
else
    Console.WriteLine($"{num} -> нет");

