using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzialAudytuBazaDanych.Tabele
{
    /// Represents a computer entity.
    public class Computer
    {
        /// Gets or sets the unique identifier for the computer.
        public int Id { get; set; }

        /// Gets or sets the date of data entry for the computer.
        public DateTime DataWprowadzenia { get; set; }

        /// Gets or sets the manufacturer of the computer.
        /// This property holds a nullable string representing the manufacturer of the computer.
        public string? Producent { get; set; }

        /// Gets or sets the CPU model of the computer.
        /// This property holds a nullable string representing the CPU model of the computer.
        public string? CPU { get; set; }

        /// Gets or sets the RAM size of the computer in GB.
        /// This property holds a nullable integer representing the RAM size of the computer in GB.
        public int? RAM { get; set; }

        /// Gets or sets the graphics card of the computer.
        /// This property holds a nullable string representing the graphics card of the computer.
        public string? KartaGraficzna { get; set; }

        /// Gets or sets the storage disk of the computer.
        /// This property holds a nullable string representing the storage disk of the computer.
        public string? Dysk { get; set; }
        /// Gets or sets the class of the computer.
        /// This property holds a nullable string representing the class of the computer.
        /// </remarks>
        public string? Klasa { get; set; }

        /// Gets or sets the auction identifier associated with the computer.
        /// This property holds a nullable integer representing the auction identifier associated with the computer.
        public int? Aukcja { get; set; }

        /// Gets or sets the date of the computer audit.
        public DateTime DataAudytu { get; set; }
    }
}
