using DzialAudytuBazaDanych.Tabele;
using Microsoft.EntityFrameworkCore;

namespace DzialAudytuBazaDanych;

public class DADbContext : DbContext
{
    public DADbContext()
    {
    }

    public DbSet<Auction> Auctions { get; set; }
    public DbSet<Buyer> Buyers { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<Computer> Computers { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure Auction entity
        modelBuilder.Entity<Auction>()
            .HasKey(a => a.Id);

        // Configure Buyer entity
        modelBuilder.Entity<Buyer>()
            .HasKey(b => b.UserId);
        modelBuilder.Entity<Buyer>()
            .Property(b => b.Username)
            .IsRequired();
        modelBuilder.Entity<Buyer>()
            .Property(b => b.Password)
            .IsRequired();

        // Configure Klasy entity
        modelBuilder.Entity<Class>()
            .HasKey(k => k.Klasa);
        modelBuilder.Entity<Class>()
            .Property(k => k.Klasa)
            .HasMaxLength(2);
        modelBuilder.Entity<Class>()
            .Property(k => k.Opis)
            .IsRequired()
            .HasMaxLength(200);

        // Configure Computer entity
        modelBuilder.Entity<Computer>()
            .HasKey(c => c.Id);
        modelBuilder.Entity<Computer>()
            .Property(c => c.DataWprowadzenia)
            .IsRequired();
        modelBuilder.Entity<Computer>()
            .Property(c => c.Producent);
        modelBuilder.Entity<Computer>()
            .Property(c => c.CPU);
        modelBuilder.Entity<Computer>()
            .Property(c => c.RAM);
        modelBuilder.Entity<Computer>()
            .Property(c => c.KartaGraficzna);
        modelBuilder.Entity<Computer>()
            .Property(c => c.Dysk);
        modelBuilder.Entity<Computer>()
            .Property(c => c.Klasa);
        modelBuilder.Entity<Computer>()
            .Property(c => c.Aukcja);
        modelBuilder.Entity<Computer>()
            .Property(c => c.DataAudytu)
            .IsRequired();

        // Configure User entity
        modelBuilder.Entity<User>()
            .HasKey(u => u.UserId);
        modelBuilder.Entity<User>()
            .Property(u => u.Username)
            .IsRequired();
        modelBuilder.Entity<User>()
            .Property(u => u.Password)
            .IsRequired();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Database.db");
    }
}