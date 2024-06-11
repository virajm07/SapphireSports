using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Stocks
    {

        [Required]
        public int StoreID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

    }
}
