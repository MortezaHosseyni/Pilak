using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pilak.Migrations
{
    /// <inheritdoc />
    public partial class Person_Nullable_Picture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Persons",
                type: "TEXT",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 225);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Persons",
                type: "TEXT",
                maxLength: 225,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 225,
                oldNullable: true);
        }
    }
}
