namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user! You may choose the following commands: /start (/echo), /help, /info, /exit.");
            Console.WriteLine("Enter the command: ");
            var command = Console.ReadLine();

            string name = null;

            while (command != "/exit")
            {
               
                if (command == "/start")
                {
                    Console.WriteLine("Enter your name: ");
                    name = Console.ReadLine();
                    Console.WriteLine($"{name}, you may use '/echo' command ");
                                       
                }
                                
                if (command.StartsWith("/echo"))
                {
                    if (name == null)
                    {
                        Console.WriteLine("You need to use '/start' command before using '/echo' command ");
                    }

                    else
                    {
                        var result = command.Substring(6);
                        Console.WriteLine($"{name}, this is your result: ");
                        Console.WriteLine(result);
                    }               
                }

                if (command == "/help")
                {
                    if (name == null)
                    {
                        Console.WriteLine("You may use the following commands: ");
                    }

                    else
                    {
                        Console.WriteLine($"{name}, you may use the following commands: ");
                    }
                                        
                    Console.WriteLine("/start - starts a command to enter a user name ");
                    Console.WriteLine("/help - contains a list of all available commands ");
                    Console.WriteLine("/info - displays the application creation date and version ");
                    Console.WriteLine("/echo - displays a line of text ");
                    Console.WriteLine("/exit – shutdown the application ");
                }

                if (command == "/info")
                {
                    if (name != null)
                    {
                        Console.WriteLine($"{name}, here is the application information: ");
                    }
                                         
                    Console.WriteLine("Version: 1.0");
                    Console.WriteLine("Creation date: 19/11/2023");
                }

                Console.WriteLine("Enter the command: ");
                command = Console.ReadLine();

            }
        }
    }
}