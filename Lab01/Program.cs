string studentName = "Острецов Владимир П.";
string studentGroup = "ПМБИ-261";
string studentPLanguage = "Python";
int expInProgram = 2;

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
System.Console.WriteLine("Список завершён.");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("ВИЗИТКА");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n[Студент]");
Console.ResetColor();
Console.WriteLine($"Имя: {studentName}");
Console.WriteLine($"Группа: {studentGroup}");
Console.WriteLine($"Любимый язык программирования: {studentPLanguage}");
Console.WriteLine($"Сколько лет программирует: {expInProgram}");