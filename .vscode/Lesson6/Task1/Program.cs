Console.Clear();

int count = 0;
string numbers = "";

Console.WriteLine("Введите числа, разделенные пробелом:");
string input = Console.ReadLine();

string[] nums = input.Split(' ');
foreach (string num in nums)
{
    int n = int.Parse(num.Trim());
    if (n > 0)
    {
        count++;
    }
    numbers += $"{n}, ";
}

Console.WriteLine($"{numbers.TrimEnd(' ', ',')} -> {count}");
