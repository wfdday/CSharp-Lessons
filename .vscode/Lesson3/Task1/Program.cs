Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Ошибка: введено число, не являющееся пятизначным");
    return;
}

int originalNumber = number;
int reversedNumber = 0;

while (number > 0)
{
    reversedNumber = reversedNumber * 10 + number % 10;
    number /= 10;
}

if (originalNumber == reversedNumber)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}