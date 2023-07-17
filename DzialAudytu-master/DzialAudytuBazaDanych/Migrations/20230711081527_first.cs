using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DzialAudytuBazaDanych.Migrations
{

    public partial class first : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auctions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Opis = table.Column<string>(type: "TEXT", nullable: true),
                    CenaPogladowa = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Klasa = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    Opis = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Rabat = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Klasa);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataWprowadzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Producent = table.Column<string>(type: "TEXT", nullable: true),
                    CPU = table.Column<string>(type: "TEXT", nullable: true),
                    RAM = table.Column<int>(type: "INTEGER", nullable: true),
                    KartaGraficzna = table.Column<string>(type: "TEXT", nullable: true),
                    Dysk = table.Column<string>(type: "TEXT", nullable: true),
                    Klasa = table.Column<string>(type: "TEXT", nullable: true),
                    Aukcja = table.Column<int>(type: "INTEGER", nullable: true),
                    DataAudytu = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auctions");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
