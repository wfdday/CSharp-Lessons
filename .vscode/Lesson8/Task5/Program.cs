Console.Clear();

int[,] array = new int[4, 4];
int value = 1;
int left = 0, top = 0, right = array.GetLength(1) - 1, bottom = array.GetLength(0) - 1;
while (left <= right && top <= bottom)
{
    for (int i = left; i <= right; i++)
    {
        array[top, i] = value++;
    }
    top++;

    for (int i = top; i <= bottom; i++)
    {
        array[i, right] = value++;
    }
    right--;

    for (int i = right; i >= left; i--)
    {
        array[bottom, i] = value++;
    }
    bottom--;

    for (int i = bottom; i >= top; i--)
    {
        array[i, left] = value++;
    }
    left++;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]:D2} ");
    }
    Console.WriteLine();
}
