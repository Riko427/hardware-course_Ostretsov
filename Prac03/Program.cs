int min = int.MinValue;
int max = int.MaxValue;

int overflowed = max + 1;
int underflowed = min - 1;

Console.Write("max: ");
foreach (byte b in BitConverter.GetBytes(max))
{
    Console.Write($"{b:X2}");
}
Console.WriteLine();
Console.Write("overflowed: ");
foreach (byte b in BitConverter.GetBytes(overflowed))
{
    Console.Write($"{b:X2}");
}
Console.WriteLine();