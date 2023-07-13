using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DzialAudytuBazaDanych.Tabele
{
    public class Computer
    {
        public int Id { get; set; }
        public DateTime DataWprowadzenia { get; set; }
        public string? Producent { get; set; }
        public string? CPU { get; set; }
        public int? RAM { get; set; }
        public string? KartaGraficzna { get; set; }
        public string? Dysk { get; set; }
        public string? Klasa { get; set; }
        public int? Aukcja { get; set; }
        public DateTime DataAudytu { get; set; }
    }
}
