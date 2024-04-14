using Homework16.Models;
using LinqToDB;
using LinqToDB.Data;

namespace Homework16.DataAccess
{
    public class ShopDataContext : DataConnection
    {
        public ShopDataContext(DataOptions options)
        : base(options) { }

        public ITable<Customer> Customers => this.GetTable<Customer>();
        public ITable<Product> Products => this.GetTable<Product>();
        public ITable<Order> Orders => this.GetTable<Order>();
    }
}
