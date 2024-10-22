using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pilak.Migrations
{
    /// <inheritdoc />
    public partial class Person_FatherName_NationalCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Persons",
                type: "TEXT",
                maxLength: 225,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "Persons",
                type: "TEXT",
                maxLength: 225,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "Persons");
        }
    }
}
