using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models

{    
        public enum Year
    {
        [Display(Name = "2025")]
        Year2025,
        [Display(Name = "2024")]
        Year2024,
        [Display(Name = "2023")]
        Year2023,
        [Display(Name = "2022")]
        Year2022,
        [Display(Name = "2021")]
        Year2021,
        [Display(Name = "2020")]
        Year2020,
    }


    public enum Category
{
    [Display(Name = "Cricket")]
    Cricket,
    [Display(Name = "Football")]
    Football,
    [Display(Name = "Basketball")]
    Basketball,
    [Display(Name = "Rugby")]
    Rugby,
    [Display(Name = "Tennis")]
    Tennis,
    [Display(Name = "Shoes")]
    Shoes
    }


    public class Product
    {

        [Key]
        public int ProductID { get; set; }
        //Indicates that ProductID is the primary key in this table

        [DisplayName("Category")]
        //Will display as "Category"
        public required string ProductName { get; set; }

        [DisplayName("Brand Name")]
        //Will display as "Brand Name"
        public required string BrandID { get; set; }

        [DisplayName("Model Year")]
        //Will display as "Model Year"
        public required string ModelYear { get; set; }

        [DisplayName("Model Name")]
        //Will display as "Model Name"
        public required string ModelName { get; set; }

        public required int Price { get; set; }
        // Navigation properties
        public ICollection<Categories> Categories { get; set; } = new List<Categories>(); 
        //One to many relationship with the Categories table
        public ICollection<Cart> Carts { get; set; } = new List<Cart>(); 
        //One to many relationship with the Carts table
        public ICollection<Payments> Payments { get; set; } = new List<Payments>(); 
        //One to many relationship with the Payments table
    }
}

