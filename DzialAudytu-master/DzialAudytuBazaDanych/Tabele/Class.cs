using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzialAudytuBazaDanych.Tabele
{

    /// Represents a class entity.
    public class Class
    {
        /// Gets or sets the class identifier.
        /// This property holds a nullable string representing the class identifier with a maximum length of 2 characters.
        [Key]
        [MaxLength(2)]
        public string? Klasa { get; set; }
    
        /// Gets or sets the description of the class.
        /// This property holds a nullable string representing the description of the class with a maximum length of 200 characters.
        [Required]
        [MaxLength(200)]
        public string? Opis { get; set; }

        /// Gets or sets the discount percentage for the class.
        /// This property holds a nullable integer representing the discount percentage for the class.
        public int? Rabat { get; set; }
    }
}
