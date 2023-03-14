Console.Clear();

int[] arr = new int[4];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(100, 1000);
}

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}

Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]);
    if (i != arr.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine($"] -> {count}");
