using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mangadex.Migrations
{
    /// <inheritdoc />
    public partial class AddMangaToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mangas",
                columns: new[] { "Id", "Description", "ImageUrl", "PublicDate", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "Until the Gal and I Become a Married Couple", "https://mangadex.org/covers/cf7b7869-3d9a-4c4d-bd06-249eba113558/72abee3c-5cde-4a6c-bc34-0ea02a1f5148.png", new DateOnly(1, 1, 1), 8f, "Boku to GAL ga Fufu ni Narumade" },
                    { 2, "Gal Can’t Be Kind to Otaku!?", "https://mangadex.org/covers/ee96e2b7-9af2-4864-9656-649f4d3b6fec/61f990f0-103a-4967-ac64-01dc9938cb5c.jpg.512.jpg", new DateOnly(1, 1, 1), 8f, "Otaku ni Yasashii Gal wa Inai!?" },
                    { 3, "My Dress-Up Darling", "https://mangadex.org/covers/aa6c76f7-5f5f-46b6-a800-911145f81b9b/426242c4-b281-4f19-bb79-c4e15ab6bb24.jpg.512.jpg", new DateOnly(1, 1, 1), 8f, "Sono Bisque Doll wa Koi o Suru" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
