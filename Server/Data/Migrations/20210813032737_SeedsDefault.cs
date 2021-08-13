using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Server.Data.Migrations
{
    public partial class SeedsDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 13, 3, 27, 36, 635, DateTimeKind.Utc).AddTicks(2920), new DateTime(2021, 8, 13, 4, 27, 36, 635, DateTimeKind.Local).AddTicks(3302), "Black", "System" },
                    { 2, "Sysem", new DateTime(2021, 8, 13, 3, 27, 36, 636, DateTimeKind.Utc).AddTicks(3174), new DateTime(2021, 8, 13, 4, 27, 36, 636, DateTimeKind.Local).AddTicks(3179), "Red", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Sysem", new DateTime(2021, 8, 13, 3, 27, 36, 637, DateTimeKind.Utc).AddTicks(5743), new DateTime(2021, 8, 13, 4, 27, 36, 637, DateTimeKind.Local).AddTicks(5750), "TOYOTA", "System" },
                    { 2, "Sysem", new DateTime(2021, 8, 13, 3, 27, 36, 637, DateTimeKind.Utc).AddTicks(6089), new DateTime(2021, 8, 13, 4, 27, 36, 637, DateTimeKind.Local).AddTicks(6091), "BMW", "System" },
                    { 3, "Sysem", new DateTime(2021, 8, 13, 3, 27, 36, 637, DateTimeKind.Utc).AddTicks(6096), new DateTime(2021, 8, 13, 4, 27, 36, 637, DateTimeKind.Local).AddTicks(6096), "LEXUS", "System" },
                    { 4, "Sysem", new DateTime(2021, 8, 13, 3, 27, 36, 637, DateTimeKind.Utc).AddTicks(6098), new DateTime(2021, 8, 13, 4, 27, 36, 637, DateTimeKind.Local).AddTicks(6099), "MERCEDES-BENZ", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Sysem", new DateTime(2021, 8, 13, 3, 27, 36, 638, DateTimeKind.Utc).AddTicks(559), new DateTime(2021, 8, 13, 4, 27, 36, 638, DateTimeKind.Local).AddTicks(562), "CAMRY", "System" },
                    { 2, "Sysem", new DateTime(2021, 8, 13, 3, 27, 36, 638, DateTimeKind.Utc).AddTicks(898), new DateTime(2021, 8, 13, 4, 27, 36, 638, DateTimeKind.Local).AddTicks(901), "COROLLA", "System" },
                    { 3, "Sysem", new DateTime(2021, 8, 13, 3, 27, 36, 638, DateTimeKind.Utc).AddTicks(905), new DateTime(2021, 8, 13, 4, 27, 36, 638, DateTimeKind.Local).AddTicks(906), "PRIUS", "System" },
                    { 4, "Sysem", new DateTime(2021, 8, 13, 3, 27, 36, 638, DateTimeKind.Utc).AddTicks(907), new DateTime(2021, 8, 13, 4, 27, 36, 638, DateTimeKind.Local).AddTicks(908), "VITZ", "System" },
                    { 5, "Sysem", new DateTime(2021, 8, 13, 3, 27, 36, 638, DateTimeKind.Utc).AddTicks(909), new DateTime(2021, 8, 13, 4, 27, 36, 638, DateTimeKind.Local).AddTicks(910), "3 SERIES", "System" },
                    { 6, "Sysem", new DateTime(2021, 8, 13, 3, 27, 36, 638, DateTimeKind.Utc).AddTicks(912), new DateTime(2021, 8, 13, 4, 27, 36, 638, DateTimeKind.Local).AddTicks(913), "XS", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
