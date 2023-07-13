﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzialAudytuBazaDanych.Tabele
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
    
        [Required]
        public string? Username { get; set; }
    
        [Required]
        public string? Password { get; set; }
    }
}
