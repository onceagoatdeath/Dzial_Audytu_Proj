using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzialAudytuBazaDanych.Tabele
{
    /// Represents a buyer entity.
    public class Buyer
    {
        /// Gets or sets the unique identifier for the buyer.
        [Key]
        public int UserId { get; set; }
    
        /// Gets or sets the username of the buyer.
        /// This property holds a nullable string representing the username of the buyer.
        [Required]
        public string? Username { get; set; }
    
        /// Gets or sets the password of the buyer.
        /// This property holds a nullable string representing the password of the buyer.
        [Required]
        public string? Password { get; set; }
    }
}
