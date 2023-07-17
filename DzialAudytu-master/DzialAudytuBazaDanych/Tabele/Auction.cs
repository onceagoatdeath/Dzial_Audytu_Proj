using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzialAudytuBazaDanych.Tabele
{

    /// Represents an auction entity.

    public class Auction
    {
        /// Gets or sets the unique identifier for the auction.
        public int Id { get; set; }

        /// Gets or sets the description of the auction.
        /// This property holds a nullable string that represents the description of the auction.
        public string? Opis { get; set; }

        /// Gets or sets the starting price for the auction.
        /// This property holds a nullable decimal value representing the starting price for the auction.
        public decimal? CenaPogladowa { get; set; }
    }
}
