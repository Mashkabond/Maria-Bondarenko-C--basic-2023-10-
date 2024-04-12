using System.Collections.Concurrent;

namespace Librarian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new ConcurrentDictionary<string, int>();
            Start(dictionary);
        }

        static void Start(ConcurrentDictionary<string, int> dictionary)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Добавить книгу");
                Console.WriteLine("2 - Вывести список непрочитанного");
                Console.WriteLine("3 - Выйти");
                Console.WriteLine();

                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Введите название книги:");
                        var book = Console.ReadLine();
                        var successfullyAdded = dictionary.TryAdd(book, 0);
                        if (successfullyAdded)
                        {
                            StartReading(dictionary);
                        }
                        break;
                    case ConsoleKey.D2:
                        foreach (var entry in dictionary)
                        {
                            Console.WriteLine($"{entry.Key} - {entry.Value}%");
                        }
                        break;
                    case ConsoleKey.D3:
                        continueProgram = false;
                        break;
                }
            }
        }

        static void StartReading(ConcurrentDictionary<string, int> dictionary)
        {
            Task.Run(() =>
            {
                while (true)
                {
                    foreach (var entry in dictionary)
                    {
                        if (entry.Value < 100)
                        {
                            dictionary[entry.Key] = entry.Value + 1;
                        }
                        else
                        {
                            dictionary.TryRemove(entry);
                        }
                    }
                    Thread.Sleep(1000);
                }
            });
        }
    }
}