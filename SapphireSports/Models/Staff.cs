﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Models
{
    public class Staff
    {

        [Key]
        public int StaffId { get; set; }
        //Indicates that StaffID is the primary key in this table

        [Required]
        [DisplayName("First Name")]
        //Will display as "First Name"
        public required string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        //Will display as "Last Name"
        public required string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        //Only allows the user to enter a date field (cannot write letters)
        public required string DOB { get; set; }

        [Required]
        [DisplayName("Contact Number")]
        //Will display as "Contact Number"
        [RegularExpression("((^\\([0]\\d{1}\\))(\\d{7}$)|(^\\([0][2]\\d{1}\\))(\\d{6,8}$)|([0][8][0][0])([\\s])(\\d{5,8}$))", ErrorMessage = "Please enter a valid phone number")]
        //Validation for phone numbers (doesn't allow any numbers to be written, needs a format such as (021)
        public required string ContactNumber { get; set; }

        [Required]
        public required string Email { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Payments> Payments { get; set; } = [];
        //One to many relationship with the payments table
    }
}
