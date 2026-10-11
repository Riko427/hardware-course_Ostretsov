using System.Diagnostics;

#if DEBUG
Console.WriteLine("Режим сборки: DEBUG");
#else
Console.WriteLine("Режим сборки: RELEASE");
#endif

long counter = 0;
var stopwatch = Stopwatch.StartNew();

while (stopwatch.ElapsedMilliseconds < 1000)
{
    counter++;
}

Console.WriteLine($"Итерации примерно на 1 секунду: {counter:N0}");