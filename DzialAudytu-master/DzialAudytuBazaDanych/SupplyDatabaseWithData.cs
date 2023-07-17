using DzialAudytuBazaDanych.Tabele;

namespace DzialAudytuBazaDanych;

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
        if (_context.Users.Any()) return;

        var users = new List<User>
        {
            new() { Username = "user", Password = "1234" }
        };

        _context.Users.AddRange(users);

        _context.SaveChanges();
    }

    public void SeedComputers()
    {
        if (_context.Computers.Any()) return;

        var computers = new List<Computer>
        {
            new()
            {
                DataWprowadzenia = DateTime.Now,
                Producent = "Dell",
                CPU = "Intel Core i5",
                RAM = 8,
                KartaGraficzna = "NVIDIA GeForce GTX 1050",
                Dysk = "256GB SSD",
                Klasa = "A",
                Aukcja = 1,
                DataAudytu = DateTime.Now
            },
            new()
            {
                DataWprowadzenia = DateTime.Now,
                Producent = "Dell",
                CPU = "AMD Ryzen 7",
                RAM = 16,
                KartaGraficzna = "AMD Radeon RX 5700",
                Dysk = "1TB HDD",
                Klasa = "B",
                Aukcja = 2,
                DataAudytu = DateTime.Now
            },
            new()
            {
                DataWprowadzenia = DateTime.Now,
                Producent = "Acer",
                CPU = "Intel Core i7",
                RAM = 32,
                KartaGraficzna = "NVIDIA GeForce RTX 3080",
                Dysk = "512GB SSD",
                Klasa = "A",
                Aukcja = 3,
                DataAudytu = DateTime.Now
            },
            new Computer
            {
            DataWprowadzenia = DateTime.Now,
            Producent = "Acer",
            CPU = "Intel Core i7",
            RAM = 16,
            KartaGraficzna = "NVIDIA GeForce RTX 2060",
            Dysk = "512GB SSD",
            Klasa = "A+",
            Aukcja = 3,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Asus",
            CPU = "AMD Ryzen 5",
            RAM = 8,
            KartaGraficzna = "NVIDIA GeForce GTX 1660",
            Dysk = "1TB HDD",
            Klasa = "B",
            Aukcja = 4,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Asus",
            CPU = "Intel Core i9",
            RAM = 32,
            KartaGraficzna = "NVIDIA GeForce RTX 3080",
            Dysk = "1TB SSD",
            Klasa = "A+",
            Aukcja = 5,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Fujitsu",
            CPU = "AMD Ryzen 9",
            RAM = 32,
            KartaGraficzna = "AMD Radeon RX 6800 XT",
            Dysk = "2TB HDD",
            Klasa = "A",
            Aukcja = 6,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Fujitsu",
            CPU = "Intel Core i5",
            RAM = 8,
            KartaGraficzna = "NVIDIA GeForce GTX 1650",
            Dysk = "512GB SSD",
            Klasa = "B",
            Aukcja = 7,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Fujitsu",
            CPU = "AMD Ryzen 7",
            RAM = 16,
            KartaGraficzna = "AMD Radeon RX 6700 XT",
            Dysk = "1TB SSD",
            Klasa = "A",
            Aukcja = 8,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Lenovo",
            CPU = "Intel Core i7",
            RAM = 16,
            KartaGraficzna = "NVIDIA GeForce RTX 3070",
            Dysk = "256GB SSD",
            Klasa = "B",
            Aukcja = 9,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Lenovo",
            CPU = "AMD Ryzen 5",
            RAM = 8,
            KartaGraficzna = "NVIDIA GeForce GTX 1660 Ti",
            Dysk = "512GB SSD",
            Klasa = "A",
            Aukcja = 10,
            DataAudytu = DateTime.Now
        },
        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Lenovo",
            CPU = "AMD Ryzen 5",
            RAM = 8,
            KartaGraficzna = "NVIDIA GeForce GTX 1660 Ti",
            Dysk = "512GB SSD",
            Klasa = "A",
            Aukcja = 10,
            DataAudytu = DateTime.Now
        },
        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Lenovo",
            CPU = "AMD Ryzen 5",
            RAM = 8,
            KartaGraficzna = "NVIDIA GeForce GTX 1660 Ti",
            Dysk = "512GB SSD",
            Klasa = "A",
            Aukcja = 10,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Lenovo",
            CPU = "Intel Core i9",
            RAM = 32,
            KartaGraficzna = "NVIDIA GeForce RTX 3090",
            Dysk = "2TB SSD",
            Klasa = "A+",
            Aukcja = 11,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Hp",
            CPU = "AMD Ryzen 9",
            RAM = 32,
            KartaGraficzna = "AMD Radeon RX 6900 XT",
            Dysk = "1TB HDD",
            Klasa = "A",
            Aukcja = 12,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Hp",
            CPU = "Intel Core i5",
            RAM = 8,
            KartaGraficzna = "NVIDIA GeForce GTX 1050 Ti",
            Dysk = "256GB SSD",
            Klasa = "B",
            Aukcja = 13,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Hp",
            CPU = "AMD Ryzen 7",
            RAM = 16,
            KartaGraficzna = "AMD Radeon RX 580",
            Dysk = "512GB SSD",
            Klasa = "A",
            Aukcja = 14,
            DataAudytu = DateTime.Now
        },
        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Hp",
            CPU = "AMD Ryzen 7",
            RAM = 16,
            KartaGraficzna = "AMD Radeon RX 580",
            Dysk = "512GB SSD",
            Klasa = "A",
            Aukcja = 14,
            DataAudytu = DateTime.Now
        },
        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Hp",
            CPU = "AMD Ryzen 7",
            RAM = 16,
            KartaGraficzna = "AMD Radeon RX 580",
            Dysk = "512GB SSD",
            Klasa = "A",
            Aukcja = 14,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Hp",
            CPU = "Intel Core i7",
            RAM = 16,
            KartaGraficzna = "NVIDIA GeForce RTX 3060",
            Dysk = "1TB SSD",
            Klasa = "B",
            Aukcja = 15,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Dell",
            CPU = "AMD Ryzen 5",
            RAM = 8,
            KartaGraficzna = "NVIDIA GeForce GTX 1660 Super",
            Dysk = "2TB HDD",
            Klasa = "A",
            Aukcja = 16,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Dell",
            CPU = "Intel Core i9",
            RAM = 32,
            KartaGraficzna = "NVIDIA GeForce RTX 3080 Ti",
            Dysk = "512GB SSD",
            Klasa = "A+",
            Aukcja = 17,
            DataAudytu = DateTime.Now
        },

        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Dell",
            CPU = "AMD Ryzen 9",
            RAM = 32,
            KartaGraficzna = "AMD Radeon RX 6800",
            Dysk = "1TB SSD",
            Klasa = "A",
            Aukcja = 18,
            DataAudytu = DateTime.Now
        },
        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Dell",
            CPU = "AMD Ryzen 9",
            RAM = 32,
            KartaGraficzna = "AMD Radeon RX 6800",
            Dysk = "1TB SSD",
            Klasa = "A",
            Aukcja = 18,
            DataAudytu = DateTime.Now
        },
        new Computer
        {
            DataWprowadzenia = DateTime.Now,
            Producent = "Dell",
            CPU = "AMD Ryzen 9",
            RAM = 32,
            KartaGraficzna = "AMD Radeon RX 6800",
            Dysk = "1TB SSD",
            Klasa = "A",
            Aukcja = 18,
            DataAudytu = DateTime.Now
        }
        };

        _context.Computers.AddRange(computers);

        _context.SaveChanges();
    }

    public void SeedClasses()
    {
        if (_context.Classes.Any()) return;

        var classes = new List<Class>
        {
            new() { Klasa = "A", Opis = "Class A", Rabat = 10 },
            new() { Klasa = "B", Opis = "Class B", Rabat = 5 },
            new() { Klasa = "C", Opis = "Class C", Rabat = null }
        };

        _context.Classes.AddRange(classes);

        _context.SaveChanges();
    }

    public void SeedBuyers()
    {
        if (_context.Buyers.Any()) return;

        var buyers = new List<Buyer>
        {
            new() { Username = "userX", Password = "1234" },
            new() { Username = "userY", Password = "1234" },
            new() { Username = "userZ", Password = "1234" }
        };

        _context.Buyers.AddRange(buyers);

        _context.SaveChanges();
    }

    public void SeedAuctions()
    {
        if (_context.Auctions.Any()) return;

        var auctions = new List<Auction>
        {
            new() { Opis = "Aukcja 1", CenaPogladowa = 100 },
            new() { Opis = "Aukcja 2", CenaPogladowa = 200 },
            new() { Opis = "Aukcja 3", CenaPogladowa = 300 }
        };

        _context.Auctions.AddRange(auctions);

        _context.SaveChanges();
    }
}