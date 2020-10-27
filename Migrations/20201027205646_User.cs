using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -4,
                column: "Date",
                value: new DateTime(2020, 10, 27, 13, 56, 46, 643, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -3,
                column: "Date",
                value: new DateTime(2020, 10, 27, 13, 56, 46, 643, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -2,
                column: "Date",
                value: new DateTime(2020, 10, 27, 13, 56, 46, 643, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -1,
                column: "Date",
                value: new DateTime(2020, 10, 27, 13, 56, 46, 624, DateTimeKind.Local).AddTicks(8560));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -4,
                column: "Date",
                value: new DateTime(2020, 10, 27, 13, 50, 17, 495, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -3,
                column: "Date",
                value: new DateTime(2020, 10, 27, 13, 50, 17, 495, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -2,
                column: "Date",
                value: new DateTime(2020, 10, 27, 13, 50, 17, 495, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -1,
                column: "Date",
                value: new DateTime(2020, 10, 27, 13, 50, 17, 482, DateTimeKind.Local).AddTicks(7700));
        }
    }
}
