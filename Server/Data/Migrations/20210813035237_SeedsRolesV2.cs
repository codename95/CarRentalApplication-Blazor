using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Server.Data.Migrations
{
    public partial class SeedsRolesV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89cb05e7-115d-46d8-8fa4-c3614440397d",
                column: "ConcurrencyStamp",
                value: "0bed5ecf-dc4b-4b33-9706-dd41b9825ca1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32a5c89-e896-437a-ae9d-fbabc03cb9eb",
                column: "ConcurrencyStamp",
                value: "5df80c78-18e9-405d-bc28-443e9e4bc45a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8d45faec-a9aa-4a4d-8a8f-ae187d4a3594", 0, "de8f7c33-4cce-47dc-985e-523335bc5dba", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEgQhtUx8sgwYq05p26+dJdQcokFlr9Tqo40Rv4Ei8VqU/z7xkE0NmtCwwXS3JsIKQ==", null, false, "98f75884-8988-4acd-ba90-856b9ad266ae", false, "admin@localhost.com" },
                    { "b68153c1-e3fe-41e7-979f-1ae22a3a1f74", 0, "9739d8dd-a6b7-415b-aaf2-da50e0277ea7", "user@localhost.com", false, "Salem", "Sky", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEP5uOhSYT/xfCpzlHnjv3gFmEvmrpE7rY3gKfoXbbsTkc6h3uYjjIaF+y+9SLJ6B7Q==", null, false, "df978b38-ccf6-45d0-b8b5-428c3b9b78c3", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 52, 36, 295, DateTimeKind.Utc).AddTicks(2), new DateTime(2021, 8, 13, 4, 52, 36, 295, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 52, 36, 296, DateTimeKind.Utc).AddTicks(368), new DateTime(2021, 8, 13, 4, 52, 36, 296, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 52, 36, 297, DateTimeKind.Utc).AddTicks(3108), new DateTime(2021, 8, 13, 4, 52, 36, 297, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 52, 36, 297, DateTimeKind.Utc).AddTicks(3444), new DateTime(2021, 8, 13, 4, 52, 36, 297, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 52, 36, 297, DateTimeKind.Utc).AddTicks(3450), new DateTime(2021, 8, 13, 4, 52, 36, 297, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 52, 36, 297, DateTimeKind.Utc).AddTicks(3454), new DateTime(2021, 8, 13, 4, 52, 36, 297, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 52, 36, 297, DateTimeKind.Utc).AddTicks(7961), new DateTime(2021, 8, 13, 4, 52, 36, 297, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 52, 36, 297, DateTimeKind.Utc).AddTicks(8297), new DateTime(2021, 8, 13, 4, 52, 36, 297, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 52, 36, 297, DateTimeKind.Utc).AddTicks(8302), new DateTime(2021, 8, 13, 4, 52, 36, 297, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 52, 36, 297, DateTimeKind.Utc).AddTicks(8304), new DateTime(2021, 8, 13, 4, 52, 36, 297, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 52, 36, 297, DateTimeKind.Utc).AddTicks(8306), new DateTime(2021, 8, 13, 4, 52, 36, 297, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 13, 3, 52, 36, 297, DateTimeKind.Utc).AddTicks(8309), new DateTime(2021, 8, 13, 4, 52, 36, 297, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "89cb05e7-115d-46d8-8fa4-c3614440397d", "8d45faec-a9aa-4a4d-8a8f-ae187d4a3594" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c32a5c89-e896-437a-ae9d-fbabc03cb9eb", "b68153c1-e3fe-41e7-979f-1ae22a3a1f74" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "89cb05e7-115d-46d8-8fa4-c3614440397d", "8d45faec-a9aa-4a4d-8a8f-ae187d4a3594" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c32a5c89-e896-437a-ae9d-fbabc03cb9eb", "b68153c1-e3fe-41e7-979f-1ae22a3a1f74" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d45faec-a9aa-4a4d-8a8f-ae187d4a3594");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b68153c1-e3fe-41e7-979f-1ae22a3a1f74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89cb05e7-115d-46d8-8fa4-c3614440397d",
                column: "ConcurrencyStamp",
                value: "dcd40f5e-c8cc-4b85-ab81-c60332d3335d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32a5c89-e896-437a-ae9d-fbabc03cb9eb",
                column: "ConcurrencyStamp",
                value: "1b021f0a-407a-4def-a754-308d039be3e2");

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
    }
}
