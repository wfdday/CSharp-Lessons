Console.Clear();

int rows = 4;
int cols = 4;

int[,] array = new int[rows, cols];
Random rand = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = rand.Next(1, 11);
    }
}

Console.WriteLine("Исходный массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

int minSum = int.MaxValue;
int minRow = -1;
for (int i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < cols; j++)
    {
        sum += array[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        minRow = i;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow + 1}");