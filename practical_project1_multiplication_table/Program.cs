Console.WriteLine(string.Format("{0, 90}", "Multiplication table from 1 to 10"));

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        /*Console.Write(string.Format("{0, -14}", $"{j} * {i} = {i * j}"));*/
        Console.Write($"{j} * {i} = {j * i}\t");
    }
    Console.WriteLine();
}