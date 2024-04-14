using LinqToDB.Mapping;

namespace Homework16.Models
{
    [Table("Customers")]
    public class Customer
    {
        [PrimaryKey, Identity]
        public long ID { get; set; }

        [Column]
        public string FirstName { get; set; }

        [Column]
        public string LastName { get; set; }

        [Column]
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Customer ID: {ID}, Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
}
