using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdatafordifficultiesandregions2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("75eb3527-f28f-4776-b1c2-7348cddc8ccd"), "CHC", "Christchurch", "https://example.com/images/christchurch.jpg" },
                    { new Guid("77da999a-7b86-4179-bbac-ae12067c80f3"), "AKL", "Auckland", "https://example.com/images/auckland.jpg" },
                    { new Guid("797a8585-6359-48c8-8ab8-7b70121fa9c3"), "WLG", "Wellington", "https://example.com/images/wellington.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("75eb3527-f28f-4776-b1c2-7348cddc8ccd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("77da999a-7b86-4179-bbac-ae12067c80f3"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("797a8585-6359-48c8-8ab8-7b70121fa9c3"));
        }
    }
}
