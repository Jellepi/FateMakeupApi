using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FateMakeupApi.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Makeups",
                columns: new[] { "ID", "Brand", "Category", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "MAC", "Lips", "Long-lasting matte finish lipstick in Ruby Woo shade.", "Matte Lipstick", "Lipstick" },
                    { 2, "Maybelline", "Face", "Lightweight foundation with full coverage and SPF 20.", "Liquid Foundation", "Foundation" },
                    { 3, "Urban Decay", "Eyes", "12-shade palette featuring warm neutrals and shimmer tones.", "Eyeshadow Palette", "Eyeshadow" },
                    { 4, "L'Oréal", "Eyes", "Mascara that provides intense volume and length.", "Volumizing Mascara", "Mascara" },
                    { 5, "NARS", "Cheeks", "Highly pigmented blush in the shade Orgasm.", "Blush Powder", "Blush" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makeups",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makeups",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makeups",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makeups",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Makeups",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
