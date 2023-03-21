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

int[] columnSums = new int[cols];
int[] columnCounts = new int[cols];

for (int i = 0; i < cols; i++)
{
    for (int j = 0; j < rows; j++)
    {
        columnSums[i] += array[j, i];
        columnCounts[i]++;
    }
}

Console.Write("Массив:\n");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.Write("\n");
}

Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < cols; i++)
{
    double average = (double)columnSums[i] / columnCounts[i];
    Console.Write(average.ToString("F1") + "; ");
}