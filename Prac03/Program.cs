string text = "�";
byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text);

Console.WriteLine($"Текст: {text}");
Console.WriteLine($"Количество символов: {text.Length}");
Console.WriteLine($"Количество байтов: {textBytes.Length}");

Console.Write("Байты: ");
foreach (byte b in textBytes)
{
    Console.Write($"{b:X2} ");
}
Console.WriteLine();