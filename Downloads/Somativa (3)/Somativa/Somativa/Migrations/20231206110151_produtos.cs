using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Somativa.Migrations
{
    /// <inheritdoc />
    public partial class produtos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "tbProdutos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "tbProdutos");
        }
    }
}
