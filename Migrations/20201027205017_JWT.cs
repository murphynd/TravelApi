using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class JWT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -5,
                column: "Date",
                value: new DateTime(2020, 10, 27, 0, 0, 0, 0, DateTimeKind.Local));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -5,
                column: "Date",
                value: new DateTime(2020, 10, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -4,
                column: "Date",
                value: new DateTime(2020, 10, 26, 14, 7, 12, 383, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -3,
                column: "Date",
                value: new DateTime(2020, 10, 26, 14, 7, 12, 383, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -2,
                column: "Date",
                value: new DateTime(2020, 10, 26, 14, 7, 12, 383, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: -1,
                column: "Date",
                value: new DateTime(2020, 10, 26, 14, 7, 12, 370, DateTimeKind.Local).AddTicks(5760));
        }
    }
}
