namespace RegularCustomer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            var customer = new Customer();
            customer.Subscribe(shop);
            OnKeyPress(shop);
        }

        static void OnKeyPress(Shop shop)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        var name = $"Товар от {DateTime.Now}";
                        shop.Add(name);
                        break;
                    case ConsoleKey.D:
                        Console.Write("Введите идентификатор товара: ");
                        if (int.TryParse(Console.ReadLine(), out var id))
                        {
                            shop.Remove(id);
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат идентификатора");
                        }
                        break;
                    case ConsoleKey.X:
                        continueProgram = false;
                        break;
                }
            }
        }
    }
}