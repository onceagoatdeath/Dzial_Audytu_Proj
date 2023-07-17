using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzialAudytuBazaDanych.Tabele
{
    /// Represents a user entity.
    public class User
    {
        /// Gets or sets the unique identifier for the user.
        [Key]
        public int UserId { get; set; }
    
        /// Gets or sets the username of the user.
        /// This property holds a nullable string representing the username of the user.
        [Required]
        public string? Username { get; set; }
    
        /// Gets or sets the password of the user.
        /// This property holds a nullable string representing the password of the user.
        [Required]
        public string? Password { get; set; }
    }
}
