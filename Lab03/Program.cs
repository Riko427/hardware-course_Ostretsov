using System.Text;

int number = 305419896;
Console.WriteLine($"Число: {number}");
Console.WriteLine($"В hex: 0x{number:X8}");
Console.WriteLine($"Little-endian: {BitConverter.IsLittleEndian}");
byte[] numberBytes = BitConverter.GetBytes(number);
Console.WriteLine("Байты числа:");
Console.WriteLine(BitConverter.ToString(numberBytes));
string text = "Hello";
Console.WriteLine();
Console.WriteLine($"Текст: {text}");
byte[] textBytes = Encoding.UTF8.GetBytes(text);
Console.WriteLine($"Байты текста UTF-8: {BitConverter.ToString(textBytes)}");