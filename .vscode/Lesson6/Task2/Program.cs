Console.Clear();

double b1, k1, b2, k2;
Console.Write("Введите b1: ");
b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
b2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
k2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения: ({x:f2}; {y:f2})");
