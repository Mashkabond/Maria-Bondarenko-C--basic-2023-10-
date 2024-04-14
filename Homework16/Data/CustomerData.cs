using Homework16.DataAccess;
using Homework16.Models;

namespace Homework16.Data
{
    public class CustomerData
    {
        private readonly ShopDataContext _db;

        public CustomerData(ShopDataContext db)
        {
            _db = db;
        }

        public List<Customer> GetCustomers()
        {
            return _db.Customers.ToList();
        }

        public Customer? GetCustomerById(long id)
        {
            return _db.Customers.FirstOrDefault(c => c.ID == id);
        }
    }
}
