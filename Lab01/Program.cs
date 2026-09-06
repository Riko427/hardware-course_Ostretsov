ConsoleColor[] CColors = new ConsoleColor[] {
    ConsoleColor.Black,
    ConsoleColor.DarkBlue, 
    ConsoleColor.DarkGreen, 
    ConsoleColor.DarkCyan, 
    ConsoleColor.DarkRed, 
    ConsoleColor.DarkMagenta, 
    ConsoleColor.DarkYellow, 
    ConsoleColor.Gray, 
    ConsoleColor.DarkGray, 
    ConsoleColor.Blue, 
    ConsoleColor.Green, 
    ConsoleColor.Cyan, 
    ConsoleColor.Red, 
    ConsoleColor.Magenta, 
    ConsoleColor.Yellow,
    ConsoleColor.White
    };
System.Console.WriteLine("Список цветов: ");
for (int i = 0; i<CColors.Length; i++) {
    Console.ForegroundColor = CColors[i];
    System.Console.Write($"{CColors[i]} ← ");
    Console.ResetColor();
    System.Console.WriteLine($"использован цвет: {CColors[i]}");
}
System.Console.WriteLine("Список завершён!");