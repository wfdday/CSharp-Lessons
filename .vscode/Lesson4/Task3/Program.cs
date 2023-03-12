Console.Clear();

int[] numbers = new int[8];
Random rand = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(1, 101);
}
string input = String.Join(", ", numbers);
string output = ($"{input} -> [{input}]");

Console.WriteLine(output);