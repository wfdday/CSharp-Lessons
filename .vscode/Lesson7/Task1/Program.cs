Console.Clear();

int m = 3;
int n = 4;


double[,] array = GenerateRandomArray(m, n);

PrintArray(array);

static double[,] GenerateRandomArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.NextDouble() * 20 - 10;
        }
    }
    return array;
}

static void PrintArray(double[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0,6:F1} ", array[i, j]);
        }
        Console.WriteLine();
    }
}