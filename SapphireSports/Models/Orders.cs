using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Orders
    {

        [Key] public int OrderID { get; set; }

        [DisplayName("Customer ID")]
        public int CustomerID { get; set; }

        [Required]
        [DisplayName("Order Status")]
        public required string OrderStatus { get; set; }

        [Required]
        [DisplayName("Order Date")]
        [DataType(DataType.Date)]
        public required string OrderDate { get; set; }

        [Required]
        [DisplayName("Store ID")]
        public int StoreID { get; set; }

        // Navigation properties

        public required Customer Customer { get; set; }
        public required Cart Cart { get; set; }
        public required Payments Payments { get; set; }

    }
}
