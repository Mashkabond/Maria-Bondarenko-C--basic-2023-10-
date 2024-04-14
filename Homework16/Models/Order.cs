using LinqToDB.Mapping;

namespace Homework16.Models
{
    [Table("Orders")]
    public class Order
    {
        [PrimaryKey, Identity]
        public long ID { get; set; }

        [Column]
        public long CustomerID { get; set; }

        [Column]
        public long ProductID { get; set; }

        [Column]
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Order ID: {ID}, Customer ID: {CustomerID}, Product ID: {ProductID}, Quantity: {Quantity}";
        }
    }
}
