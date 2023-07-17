using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DzialAudytuBazaDanych.Tabele
{
    public class Auction
    {
        public int Id { get; set; }
        public string? Opis { get; set; }
        public decimal? CenaPogladowa { get; set; }
    }
}
