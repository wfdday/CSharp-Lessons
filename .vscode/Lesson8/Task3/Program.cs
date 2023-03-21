Console.Clear();

int n = 2, m = 2, p = 2, q = 2;

int[,] A = new int[n, m];
int[,] B = new int[p, q];
Random rnd = new Random();

Console.WriteLine("Даны 2 матрицы:");
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        A[i, j] = rnd.Next(10);
        Console.Write("{0} ", A[i, j]);
    }
    Console.Write("| ");
    for (int j = 0; j < q; j++)
    {
        B[i, j] = rnd.Next(10);
        Console.Write("{0} ", B[i, j]);
    }
    Console.WriteLine();
}

int[,] C = new int[n, q];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < q; j++)
    {
        C[i, j] = 0;
        for (int k = 0; k < m; k++)
        {
            C[i, j] += A[i, k] * B[k, j];
        }
    }
}

Console.WriteLine();
Console.WriteLine("Результирующая матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < q; j++)
    {
        Console.Write("{0} ", C[i, j]);
    }
    Console.WriteLine();
}