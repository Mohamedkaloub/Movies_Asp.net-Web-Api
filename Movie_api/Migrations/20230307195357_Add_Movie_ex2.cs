using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_api.Migrations
{
    /// <inheritdoc />
    public partial class Add_Movie_ex2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Directors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Directors");
        }
    }
}
