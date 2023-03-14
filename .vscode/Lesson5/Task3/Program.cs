Console.Clear();

double[] arr = new double[5];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Math.Round(rand.NextDouble() * 100, 2);
}

double min = arr[0];
double max = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
    if (arr[i] > max)
    {
        max = arr[i];
    }
}

double diff = max - min;

Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i].ToString("0.00"));
    if (i != arr.Length - 1)
    {
        Console.Write(" ");
    }
}
Console.WriteLine($"] -> {diff.ToString("0.00")}");
