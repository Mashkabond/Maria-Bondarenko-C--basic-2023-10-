using Homework16.DataAccess;
using Homework16.Models;

namespace Homework16.Data
{
    public class ProductData
    {
        private readonly ShopDataContext _db;

        public ProductData(ShopDataContext db)
        {
            _db = db;
        }

        public List<Product> GetProducts()
        {
            return _db.Products.ToList();
        }

        public Product? GetProductById(long id)
        {
            return _db.Products.FirstOrDefault(c => c.ID == id);
        }
    }
}
