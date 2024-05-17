using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Staff
    {

        public int StaffId { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string DOB { get; set; }

        [Required]
        [DisplayName("Contact Number")]
        [RegularExpression("((^\\([0]\\d{1}\\))(\\d{7}$)|(^\\([0][2]\\d{1}\\))(\\d{6,8}$)|([0][8][0][0])([\\s])(\\d{5,8}$))", ErrorMessage = "Please enter a valid phone number")]
        public string ContactNumber { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
