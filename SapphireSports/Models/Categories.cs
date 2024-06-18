using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Categories
    {

        [Key] public int CategoriesID { get; set; }
        public required string Cricket { get; set; }

        public required string Football { get; set; }

        public required string Basketball { get; set; }

        public required string Rugby { get; set; }

        public required string Tennis { get; set; }

        public required string Shoes { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>(); // Product
    }
}
