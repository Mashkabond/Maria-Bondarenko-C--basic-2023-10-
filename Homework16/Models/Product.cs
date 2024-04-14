using LinqToDB.Mapping;

namespace Homework16.Models
{
    [Table("Products")]
    public class Product
    {
        [PrimaryKey, Identity]
        public long ID { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Description { get; set; }

        [Column]
        public int StockQuantity { get; set; }

        [Column]
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Product ID: {ID}, Name: {Name}, Description: {Description}, Stock Quantity: {StockQuantity}, Price: {Price}";
        }
    }
}
