using AspNetCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Customer
    {

        public int CustomerID { get; set; }

        [Required]
        [DisplayName("First Name")]
        public required string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public required string LastName { get; set; }

        [Required]
        public required string Address { get; set; }

        [Required]
        [DisplayName("Contact Number")]
        [RegularExpression("((^\\([0]\\d{1}\\))(\\d{7}$)|(^\\([0][2]\\d{1}\\))(\\d{6,8}$)|([0][8][0][0])([\\s])(\\d{5,8}$))", ErrorMessage = "Please enter a valid phone number")]
        public required string ContactNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public required string DOB { get; set; }

        [Required]
        public required string Email { get; set; }

        // Navigation properties
        public ICollection<Orders> Orders { get; set; } = new List<Orders>(); // Orders
        public ICollection<Cart> Carts { get; set; } = new List<Cart>(); // Carts
        public ICollection<Payments> Payments { get; set; } = new List<Payments>(); // Payments


    }
}
