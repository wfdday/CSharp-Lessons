Console.Clear();

int[,,] arr = new int[2, 2, 2];
Random rand = new Random();

HashSet<int> used = new HashSet<int>();
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            int num;
            do
            {
                num = rand.Next(10, 100);
            } while (used.Contains(num));
            used.Add(num);
            arr[i, j, k] = num;
        }
    }
}

Console.WriteLine();
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}