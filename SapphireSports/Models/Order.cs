using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SapphireSports.Models
{
    public class Order
    {

        [Key] public int OrderID { get; set; }

        [DisplayName("Customer ID")]
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [Required]
        [DisplayName("Order Status")]
        public required string OrderStatus { get; set; }

        [Required]
        [DisplayName("Order Date")]
        [DataType(DataType.Date)]
        public required string OrderDate { get; set; }

      
        // Navigation properties

        public  Customer Customer { get; set; }
        public  Cart Cart { get; set; }
        

    }
}
