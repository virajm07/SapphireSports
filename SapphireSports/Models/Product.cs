﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Product
    {

        [Key]
        public int ProductID { get; set; }

        [DisplayName("Product Name")]
        public required string ProductName { get; set; }

        [DisplayName("Brand ID")]
        public required string BrandID { get; set; }

        [DisplayName("Model Year")]
        public required string ModelYear { get; set; }

        [DisplayName("Model Name")]
        public required string ModelName { get; set; }

        public required string Price { get; set; }

        // Navigation properties
        public ICollection<Categories> Categories { get; set; } = new List<Categories>(); // Categories
        public ICollection<Cart> Carts { get; set; } = new List<Cart>(); // Carts
        public ICollection<Payments> Payments { get; set; } = new List<Payments>(); // Payments
    }
}
