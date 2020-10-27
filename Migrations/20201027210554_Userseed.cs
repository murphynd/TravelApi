using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class Userseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -4,
                column: "Date",
                value: new DateTime(2020, 10, 27, 14, 5, 54, 262, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -3,
                column: "Date",
                value: new DateTime(2020, 10, 27, 14, 5, 54, 262, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -2,
                column: "Date",
                value: new DateTime(2020, 10, 27, 14, 5, 54, 262, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -1,
                column: "Date",
                value: new DateTime(2020, 10, 27, 14, 5, 54, 250, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Token", "Username" },
                values: new object[] { -1, "yoyoyo", null, "NatDawg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1);

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
    }
}
