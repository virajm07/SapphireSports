using System.ComponentModel;

namespace SapphireSports.Models
{
    public class Product
    {

        public int ProductID { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Brand ID")]
        public string BrandID { get; set; }

        [DisplayName("Model Year")]
        public string ModelYear { get; set; }

        [DisplayName("Model Name")]
        public string ModelName { get; set; }

        public string Price { get; set; }
    }
}
