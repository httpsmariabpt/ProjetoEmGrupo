using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto.Data.Migrations
{
    /// <inheritdoc />
    public partial class alterTutoToIdCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tutor",
                table: "Animais");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tutor",
                table: "Animais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
