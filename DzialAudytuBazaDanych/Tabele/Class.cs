using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzialAudytuBazaDanych.Tabele
{
    public class Class
    {
        [Key]
        [MaxLength(2)]
        public string? Klasa { get; set; }
    
        [Required]
        [MaxLength(200)]
        public string? Opis { get; set; }
    
        public int? Rabat { get; set; }
    }
}
