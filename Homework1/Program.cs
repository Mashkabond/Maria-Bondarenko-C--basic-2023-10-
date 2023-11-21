namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user! You may choose the following commands: /start, /help, /info, /exit.");
            Console.WriteLine("Enter the command: ");
            var command = Console.ReadLine();

            while (command != "/exit")
            {
                if (command == "/start")
                {
                    Console.WriteLine("Enter your name: ");
                    var name = Console.ReadLine();
                    Console.WriteLine("You may use '/echo' command ");

                    command = Console.ReadLine();
                    if (command.StartsWith("/echo"))
                    {
                        var result = command.Substring(6);
                        Console.WriteLine(result);
                    }
                }

                if (command == "/help")
                {
                    Console.WriteLine("information ");
                }

                if (command == "/info")
                {
                    Console.WriteLine("Version: 1.0");
                    Console.WriteLine("Creation date: 19/11/2023");
                }

                Console.WriteLine("Enter the command: ");
                command = Console.ReadLine();

            }
        }
    }
}