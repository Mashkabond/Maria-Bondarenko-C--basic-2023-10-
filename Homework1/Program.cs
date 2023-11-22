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
                    Console.WriteLine("You may use the following commands: ");
                    Console.WriteLine("/start - starts a command to enter a user name ");
                    Console.WriteLine("/help - contains a list of all available commands ");
                    Console.WriteLine("/info - displays the application creation date and version ");
                    Console.WriteLine("/echo - displays a line of text ");
                    Console.WriteLine("/exit – shutdown the application ");
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