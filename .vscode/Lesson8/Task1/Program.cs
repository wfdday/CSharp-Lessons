Console.Clear();

int rows = 3;
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

for (int i = 0; i < rows; i++)
{
    int[] rowArray = new int[cols];
    for (int j = 0; j < cols; j++)
    {
        rowArray[j] = array[i, j];
    }
    Array.Sort(rowArray, new Comparison<int>((x, y) => y.CompareTo(x)));
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = rowArray[j];
    }
}

Console.WriteLine("Упорядоченный массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
