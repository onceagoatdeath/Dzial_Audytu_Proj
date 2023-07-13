using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DzialAudytuBazaDanych.Tabele;

namespace DzialAudytuBazaDanych
{
    public class SupplyDatabaseWithData
    {
        private readonly DADbContext _context;

        public SupplyDatabaseWithData(DADbContext context)
        {
            _context = context;
        }
        public void SeedDatabase()
        {
            SeedUsers();
            SeedComputers();
            SeedClasses();
            SeedAuctions();
            SeedBuyers();
        }
        private void SeedUsers()
        {
            if (_context.Users.Any())
            {
                return; 
            }

            var users = new List<User>
            {
                new User { Username = "user1", Password = "password1" },
                new User { Username = "user2", Password = "password2" },
                new User { Username = "user3", Password = "password3" }
            };

            _context.Users.AddRange(users);

            _context.SaveChanges();
        }

        public void SeedComputers()
        {
            if (_context.Computers.Any())
            {
                return; 
            }

            var computers = new List<Computer>
            {
                new Computer
                {
                    DataWprowadzenia = DateTime.Now,
                    Producent = "Company A",
                    CPU = "Intel Core i5",
                    RAM = 8,
                    KartaGraficzna = "NVIDIA GeForce GTX 1050",
                    Dysk = "256GB SSD",
                    Klasa = "A",
                    Aukcja = 1,
                    DataAudytu = DateTime.Now
                },
                new Computer
                {
                    DataWprowadzenia = DateTime.Now,
                    Producent = "Company B",
                    CPU = "AMD Ryzen 7",
                    RAM = 16,
                    KartaGraficzna = "AMD Radeon RX 5700",
                    Dysk = "1TB HDD",
                    Klasa = "B",
                    Aukcja = 2,
                    DataAudytu = DateTime.Now
                },
                new Computer
                {
                    DataWprowadzenia = DateTime.Now,
                    Producent = "Company C",
                    CPU = "Intel Core i7",
                    RAM = 32,
                    KartaGraficzna = "NVIDIA GeForce RTX 3080",
                    Dysk = "512GB SSD",
                    Klasa = "A",
                    Aukcja = 3,
                    DataAudytu = DateTime.Now
                }
            };

            _context.Computers.AddRange(computers);

            _context.SaveChanges();
        }

        public void SeedClasses()
        {
            if (_context.Classes.Any())
            {
                return; 
            }

            var classes = new List<Class>
            {
                new Class { Klasa = "A", Opis = "Class A", Rabat = 10 },
                new Class { Klasa = "B", Opis = "Class B", Rabat = 5 },
                new Class { Klasa = "C", Opis = "Class C", Rabat = null }
            };

            _context.Classes.AddRange(classes);

            _context.SaveChanges();
        }

        public void SeedBuyers()
        {
            if (_context.Buyers.Any())
            {
                return; 
            }

            var buyers = new List<Buyer>
            {
                new Buyer { Username = "buyer1", Password = "password1" },
                new Buyer { Username = "buyer2", Password = "password2" },
                new Buyer { Username = "buyer3", Password = "password3" }
            };

            _context.Buyers.AddRange(buyers);

            _context.SaveChanges();
        }

        public void SeedAuctions()
        {
            if (_context.Auctions.Any())
            {
                return;
            }

            var auctions = new List<Auction>
            {
                new Auction { Opis = "Auction 1", CenaPogladowa = 100 },
                new Auction { Opis = "Auction 2", CenaPogladowa = 200 },
                new Auction { Opis = "Auction 3", CenaPogladowa = 300 }
            };

            _context.Auctions.AddRange(auctions);

            _context.SaveChanges();
        }
    }
}
