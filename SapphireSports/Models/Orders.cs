using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Orders
    {

        [Required]
        public int OrderID { get; set; }
        [DisplayName("Customer ID")]
        public string CustomerID { get; set; }

        [Required]
        [DisplayName("Order Status")]
        public string OrderStatus { get; set; }

        [Required]
        [DisplayName("Order Date")]
        [DataType(DataType.Date)]
        public string OrderDate { get; set; }

        [Required]
        [DisplayName("Store ID")]
        public string StoreID { get; set; }
    }
}
