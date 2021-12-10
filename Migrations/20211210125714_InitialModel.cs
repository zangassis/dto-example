using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellerManager.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountFactor = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "Address", "CreatedAt", "DiscountFactor", "Email", "Name" },
                values: new object[] { new Guid("7aec76ad-e684-4a24-8418-35c41faccc39"), "947 Heritage Road", new DateTime(2021, 12, 10, 12, 57, 14, 488, DateTimeKind.Utc).AddTicks(1735), 10m, "John@mail.com", "John Smith" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "Address", "CreatedAt", "DiscountFactor", "Email", "Name" },
                values: new object[] { new Guid("b71d5e76-ff10-4bcc-b772-d248ce953093"), "360 Bates Brothers Road", new DateTime(2021, 12, 10, 12, 57, 14, 488, DateTimeKind.Utc).AddTicks(1739), 10m, "vmarshall@mail.com", "Violet Marshall" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
