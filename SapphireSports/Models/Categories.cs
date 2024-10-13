using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Categories
    {

        [Key] public int CategoriesID { get; set; }
        //Indicates that CategoriesID is the primary key in this table
        public required string Cricket { get; set; }
        //String allows the user to type any characters in the field upto 256 words

        public required string Football { get; set; }
        //String allows the user to type any characters in the field upto 256 words

        public required string Basketball { get; set; }
        //String allows the user to type any characters in the field upto 256 words

        public required string Rugby { get; set; }
        //String allows the user to type any characters in the field upto 256 words

        public required string Tennis { get; set; }
        //String allows the user to type any characters in the field upto 256 words

        public required string Shoes { get; set; }
        //String allows the user to type any characters in the field upto 256 words

        public ICollection<Product> Products { get; set; } = new List<Product>();
        //One to many relationship with the Products table
    }
}
