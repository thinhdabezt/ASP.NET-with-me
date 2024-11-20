using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "Introduction", "Name", "Price", "Rate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 17, 1, 51, 59, 517, DateTimeKind.Local).AddTicks(7685), "https://mangadex.org/covers/cf7b7869-3d9a-4c4d-bd06-249eba113558/72abee3c-5cde-4a6c-bc34-0ea02a1f5148.png", "Boku to GAL ga Fufu ni Narumade", "Boku to GAL ga Fufu ni Narumade", 1000f, 5f, new DateTime(2024, 9, 17, 1, 51, 59, 517, DateTimeKind.Local).AddTicks(7696) },
                    { 2, new DateTime(2024, 9, 17, 1, 51, 59, 517, DateTimeKind.Local).AddTicks(7698), "https://mangadex.org/covers/ee96e2b7-9af2-4864-9656-649f4d3b6fec/61f990f0-103a-4967-ac64-01dc9938cb5c.jpg.512.jpg", "Otaku ni Yasashii Gal wa Inai!?", "Otaku ni Yasashii Gal wa Inai!?", 1000f, 5f, new DateTime(2024, 9, 17, 1, 51, 59, 517, DateTimeKind.Local).AddTicks(7698) },
                    { 3, new DateTime(2024, 9, 17, 1, 51, 59, 517, DateTimeKind.Local).AddTicks(7700), "https://mangadex.org/covers/aa6c76f7-5f5f-46b6-a800-911145f81b9b/426242c4-b281-4f19-bb79-c4e15ab6bb24.jpg.512.jpg", "Sono Bisque Doll wa Koi o Suru", "Sono Bisque Doll wa Koi o Suru", 1000f, 5f, new DateTime(2024, 9, 17, 1, 51, 59, 517, DateTimeKind.Local).AddTicks(7700) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
