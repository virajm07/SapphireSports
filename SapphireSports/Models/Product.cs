using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Product
    {

        [Key]
        public int ProductID { get; set; }
        //Indicates that ProductID is the primary key in this table

        [DisplayName("Sport")]
        //Will display as "Product Name"
        public required string ProductName { get; set; }

        [DisplayName("Brand Name")]
        //Will display as "Brand ID"
        public required string BrandID { get; set; }

        [DisplayName("Model Year")]
        //Will display as "Model Year"
        public required string ModelYear { get; set; }

        [DisplayName("Model Name")]
        //Will display as "Model Name"
        public required string ModelName { get; set; }

        public required int Price { get; set; }
        // Navigation properties
        public ICollection<Categories> Categories { get; set; } = new List<Categories>(); 
        //One to many relationship with the Categories table
        public ICollection<Cart> Carts { get; set; } = new List<Cart>(); 
        //One to many relationship with the Carts table
        public ICollection<Payments> Payments { get; set; } = new List<Payments>(); 
        //One to many relationship with the Payments table
    }
}
