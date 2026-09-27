int number = 1_000_000;
byte[] bytes = BitConverter.GetBytes(number);

Console.WriteLine($"Число: {number}");
Console.Write("Байты: ");
foreach (byte b in bytes)
{
    Console.Write($"{b:X2}");
}
Console.WriteLine();
// Коммит

int max = int.MaxValue;
Console.WriteLine($"int.MaxValue = {max}");

int overflowed = max + 1;
Console.WriteLine($"int.MaxValue + 1 = {overflowed}");