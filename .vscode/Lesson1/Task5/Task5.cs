Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "");
int result = (num / 10 % 10);

if (num < 100 || num >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");

}
else
{
    Console.WriteLine($"Вы ввели число {num}");
    Console.WriteLine($"Вторая цифра {result}");
}