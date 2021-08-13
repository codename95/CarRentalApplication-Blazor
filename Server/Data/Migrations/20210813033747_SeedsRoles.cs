using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Server.Data.Migrations
{
    public partial class SeedsRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c32a5c89-e896-437a-ae9d-fbabc03cb9eb", "1b021f0a-407a-4def-a754-308d039be3e2", "User", "USER" },
                    { "89cb05e7-115d-46d8-8fa4-c3614440397d", "dcd40f5e-c8cc-4b85-ab81-c60332d3335d", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 37, 46, 911, DateTimeKind.Utc).AddTicks(1205), new DateTime(2021, 8, 13, 4, 37, 46, 911, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 37, 46, 912, DateTimeKind.Utc).AddTicks(5006), new DateTime(2021, 8, 13, 4, 37, 46, 912, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 37, 46, 914, DateTimeKind.Utc).AddTicks(3128), new DateTime(2021, 8, 13, 4, 37, 46, 914, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 37, 46, 914, DateTimeKind.Utc).AddTicks(3597), new DateTime(2021, 8, 13, 4, 37, 46, 914, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 37, 46, 914, DateTimeKind.Utc).AddTicks(3605), new DateTime(2021, 8, 13, 4, 37, 46, 914, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 37, 46, 914, DateTimeKind.Utc).AddTicks(3608), new DateTime(2021, 8, 13, 4, 37, 46, 914, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 37, 46, 915, DateTimeKind.Utc).AddTicks(9971), new DateTime(2021, 8, 13, 4, 37, 46, 915, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 37, 46, 916, DateTimeKind.Utc).AddTicks(537), new DateTime(2021, 8, 13, 4, 37, 46, 916, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 37, 46, 916, DateTimeKind.Utc).AddTicks(544), new DateTime(2021, 8, 13, 4, 37, 46, 916, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 37, 46, 916, DateTimeKind.Utc).AddTicks(547), new DateTime(2021, 8, 13, 4, 37, 46, 916, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 37, 46, 916, DateTimeKind.Utc).AddTicks(550), new DateTime(2021, 8, 13, 4, 37, 46, 916, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 37, 46, 916, DateTimeKind.Utc).AddTicks(553), new DateTime(2021, 8, 13, 4, 37, 46, 916, DateTimeKind.Local).AddTicks(554) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89cb05e7-115d-46d8-8fa4-c3614440397d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32a5c89-e896-437a-ae9d-fbabc03cb9eb");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 27, 36, 635, DateTimeKind.Utc).AddTicks(2920), new DateTime(2021, 8, 13, 4, 27, 36, 635, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 27, 36, 636, DateTimeKind.Utc).AddTicks(3174), new DateTime(2021, 8, 13, 4, 27, 36, 636, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 27, 36, 637, DateTimeKind.Utc).AddTicks(5743), new DateTime(2021, 8, 13, 4, 27, 36, 637, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 27, 36, 637, DateTimeKind.Utc).AddTicks(6089), new DateTime(2021, 8, 13, 4, 27, 36, 637, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 27, 36, 637, DateTimeKind.Utc).AddTicks(6096), new DateTime(2021, 8, 13, 4, 27, 36, 637, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 27, 36, 637, DateTimeKind.Utc).AddTicks(6098), new DateTime(2021, 8, 13, 4, 27, 36, 637, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 27, 36, 638, DateTimeKind.Utc).AddTicks(559), new DateTime(2021, 8, 13, 4, 27, 36, 638, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 27, 36, 638, DateTimeKind.Utc).AddTicks(898), new DateTime(2021, 8, 13, 4, 27, 36, 638, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 27, 36, 638, DateTimeKind.Utc).AddTicks(905), new DateTime(2021, 8, 13, 4, 27, 36, 638, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 27, 36, 638, DateTimeKind.Utc).AddTicks(907), new DateTime(2021, 8, 13, 4, 27, 36, 638, DateTimeKind.Local).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 27, 36, 638, DateTimeKind.Utc).AddTicks(909), new DateTime(2021, 8, 13, 4, 27, 36, 638, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 27, 36, 638, DateTimeKind.Utc).AddTicks(912), new DateTime(2021, 8, 13, 4, 27, 36, 638, DateTimeKind.Local).AddTicks(913) });
        }
    }
}
