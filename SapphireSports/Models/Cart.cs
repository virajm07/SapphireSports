using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public int OrderID { get; set; }

        [Required]
        public int ListPrice { get; set; }

        [Required]
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public ICollection<Product> Products { get; set; }  // Product
    }
}
