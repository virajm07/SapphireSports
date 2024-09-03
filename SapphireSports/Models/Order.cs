using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SapphireSports.Models
{
    public enum Status
    {
        [Display(Name = "Order Recieved")]
        OrderRecieved,
        [Display(Name = "Sent for Shipping")]
        SentForShipping,
        [Display(Name = "Order Shipped")]
        OrderShipped
    }
    public class Order
    {

        [Key] public int OrderID { get; set; }
        //Indicates that OrderID is the primary key in this table

        [DisplayName("Customer Name")]
        //Will display as "Customer ID"
        [ForeignKey("Customer")]
        //Indicates that the Customer table is the foreign key
        public int CustomerID { get; set; }

        [Required]
        [DisplayName("Order Status")]
        //Will display as "Order Status"
        public required Status OrderStatus { get; set; }

        [Required]
        [DisplayName("Order Date")]
        //Will display as "Order Date"
        [DataType(DataType.Date)]
        //Only allows the user to enter a date field (cannot write letters)
        public required string OrderDate { get; set; }


        // Navigation properties
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public  Customer Customer { get; set; }
        public  Cart Cart { get; set; }
        //One to one relationship with the Cart table
        

    }
}
