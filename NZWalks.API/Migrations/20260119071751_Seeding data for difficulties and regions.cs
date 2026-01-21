using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdatafordifficultiesandregions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03205c8a-abaa-4fe0-a893-2f9469862c11"), "Hard" },
                    { new Guid("85aa789b-c009-45ba-8223-6451c8e0a7c2"), "Medium" },
                    { new Guid("9d89d8f3-97eb-475c-a748-4d71ddf4f8e2"), "Easy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("03205c8a-abaa-4fe0-a893-2f9469862c11"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("85aa789b-c009-45ba-8223-6451c8e0a7c2"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("9d89d8f3-97eb-475c-a748-4d71ddf4f8e2"));
        }
    }
}
