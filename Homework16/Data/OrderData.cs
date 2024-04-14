using Homework16.DataAccess;
using Homework16.Models;

namespace Homework16.Data
{
    public class OrderData
    {
        private readonly ShopDataContext _db;

        public OrderData(ShopDataContext db)
        {
            _db = db;
        }

        public List<Order> GetOrders()
        {
            return _db.Orders.ToList();
        }

        public Order? GetOrderById(long id)
        {
            return _db.Orders.FirstOrDefault(c => c.ID == id);
        }
    }
}
