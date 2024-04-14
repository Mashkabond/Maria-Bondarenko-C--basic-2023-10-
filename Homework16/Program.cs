using Homework16.DataAccess;
using LinqToDB;
using Homework16.Data;

namespace Homework16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            using var db = ConfigureContext();

            ExecuteCustomerQueries(db);
            ExecuteProductQueries(db);
            ExecuteOrderQueries(db);
        }

        static ShopDataContext ConfigureContext()
        {
            var connectionString = "User ID=usr;Password=pwd;Host=localhost;Port=5432;Database=Shop;";
            var options = new DataOptions()
                .UseSqlServer(connectionString)
                .UsePostgreSQL();
            return new ShopDataContext(options);
        }

        static void ExecuteCustomerQueries(ShopDataContext db)
        {
            Console.WriteLine("Get All Customers:");
            var customerData = new CustomerData(db);
            var customers = customerData.GetCustomers();
            customers.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Get Customer By ID:");
            var customer = customerData.GetCustomerById(1);
            Console.WriteLine($"{customer}\n");
        }

        static void ExecuteProductQueries(ShopDataContext db)
        {
            Console.WriteLine("Get All Products:");
            var productData = new ProductData(db);
            var products = productData.GetProducts();
            products.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Get Product By ID:");
            var product = productData.GetProductById(1);
            Console.WriteLine($"{product}\n");
        }

        static void ExecuteOrderQueries(ShopDataContext db)
        {
            Console.WriteLine("Get All Orders:");
            var orderData = new OrderData(db);
            var orders = orderData.GetOrders();
            orders.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Get Order By ID:");
            var order = orderData.GetOrderById(1);
            Console.WriteLine($"{order}\n");
        }
    }
}