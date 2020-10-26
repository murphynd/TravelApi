using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    PlaceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Review = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.PlaceId);
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceId", "Date", "Name", "Rating", "Review" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 10, 26, 11, 2, 18, 159, DateTimeKind.Local).AddTicks(8530), "Las Vegas", 7, "Hot" },
                    { -2, new DateTime(2020, 10, 26, 11, 2, 18, 172, DateTimeKind.Local).AddTicks(2580), "NYC", 10, "Crowded" },
                    { -3, new DateTime(2020, 10, 26, 11, 2, 18, 172, DateTimeKind.Local).AddTicks(2600), "Portland", 2, "Bridges" },
                    { -4, new DateTime(2020, 10, 26, 11, 2, 18, 172, DateTimeKind.Local).AddTicks(2600), "Seattle", 4, "Hills" },
                    { -5, new DateTime(2020, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Miami", 22, "Beaches" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
