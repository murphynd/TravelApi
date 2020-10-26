using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    PlaceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Landmark = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Review = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.PlaceId);
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceId", "City", "Country", "Date", "Landmark", "Rating", "Review" },
                values: new object[,]
                {
                    { -1, "Las Vegas", "USA", new DateTime(2020, 10, 26, 14, 7, 12, 370, DateTimeKind.Local).AddTicks(5760), "casino", 7, "Hot" },
                    { -2, "NYC", "USA", new DateTime(2020, 10, 26, 14, 7, 12, 383, DateTimeKind.Local).AddTicks(5810), "Empire State building", 10, "Crowded" },
                    { -3, "Portland", "USA", new DateTime(2020, 10, 26, 14, 7, 12, 383, DateTimeKind.Local).AddTicks(5830), "skidmore fountian", 2, "Bridges" },
                    { -4, "Seattle", "USA", new DateTime(2020, 10, 26, 14, 7, 12, 383, DateTimeKind.Local).AddTicks(5830), "starbucks", 4, "Hills" },
                    { -5, "Miami", "USA", new DateTime(2020, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "art basil", 2, "Beaches" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
