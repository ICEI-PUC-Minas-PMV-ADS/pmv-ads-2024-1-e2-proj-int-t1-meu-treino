using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndMeutreino.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imagem",
                table: "exercicio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imagem",
                table: "exercicio",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
