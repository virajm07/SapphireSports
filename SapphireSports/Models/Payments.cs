using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Payments
    {
        [Key]
        public  required int PaymentID { get; set; }

        [DisplayName("Customer ID")]
        public required int CustomerID { get; set; }

        [DisplayName("Total Price")]
        public required string PayAmount { get; set; }

        [DisplayName("Payment Method")]
        public required string PaymentMethod { get; set; }

        [DisplayName("Payment Date")]
        public required DateTime PaymentDate { get; set; }

        public required Customer Customer { get; set; }


    }
}
