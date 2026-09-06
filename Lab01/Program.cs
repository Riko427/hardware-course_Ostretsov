string studentName = "Острецов Владимир П.";
string studentGroup = "ПМБИ-261";
string studentPLanguage = "Python";
int expInProgram = 2;

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