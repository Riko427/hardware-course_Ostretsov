using System.Diagnostics;

int threadCount = 8;

System.Console.WriteLine($"Логических процессоров: {threadCount}");
System.Console.WriteLine($"Потоков запущено: {threadCount}");
System.Console.WriteLine("Запуск вычислений...");

Thread[] threads = new Thread[threadCount];

for (int i = 0; i < threadCount; i++)
{
    threads[i] = new Thread(() => {
        long result = 0;
        Stopwatch timer = Stopwatch.StartNew();

        while (timer.Elapsed.TotalSeconds < 5)
        {
            for (int j = 0; j < 1_000_000; j++)
            {
                result += j * j;
            }
        }
    });
    threads[i].Start();
}

foreach (Thread thread in threads)
{
    thread.Join();
}

System.Console.WriteLine("Все потоки завершили работу.");

// using System.Diagnostics;

// System.Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");
// System.Console.WriteLine("Запуск вычислений...");

// Stopwatch timer = Stopwatch.StartNew();
// long result = 0;
// while (timer.Elapsed.TotalSeconds < 5)
// {
//     for (int i = 0; i < 1_000_000; i++)
//     {
//         result += i * i;
//     }
// }

// System.Console.WriteLine($"Результат: {result}");
// System.Console.WriteLine("Готово.");

// using System.Runtime.InteropServices;

// System.Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");
// System.Console.WriteLine($"Архитектура процессора: {RuntimeInformation.ProcessArchitecture}");
// System.Console.WriteLine($"64-битный процесс: {Environment.Is64BitProcess}");