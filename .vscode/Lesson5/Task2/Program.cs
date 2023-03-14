Console.Clear();

int[] arr = new int[4];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-100, 100);
}

int sum = 0;
for (int i = 1; i < arr.Length; i += 2)
{
    sum += arr[i];
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
Console.WriteLine($"] -> {sum}");
