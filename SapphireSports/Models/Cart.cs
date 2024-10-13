using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Cart
    {
        [Key]
        //Indicates that CartID is the primary key in this table
        public int CartID { get; set; }

        [Required]
        [DisplayName("Product Name")]
        //Field will display as Product Name
        public int ProductID { get; set; }

        [Required]
        [DisplayName("Order Date")]
        //Field will display as Order Date
        public int OrderID { get; set; }

        [Required]
        [DisplayName("Price")]
        //Field will display as Price
        public int ListPrice { get; set; }

        [Required]
        public int Quantity { get; set; }
        public Order Order { get; set; }
        //One to one relationship with the Orders table
        public Product Product { get; set; }
        //One to one relationship with the Products table
    }
}
