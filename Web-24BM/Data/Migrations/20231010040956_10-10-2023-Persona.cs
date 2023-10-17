using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_24BM.Data.Migrations
{
    /// <inheritdoc />
    public partial class _10102023Persona : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AreaTrabajo",
                table: "Persona",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RFC",
                table: "Persona",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaTrabajo",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "RFC",
                table: "Persona");
        }
    }
}
