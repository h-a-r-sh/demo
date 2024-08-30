using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductTable.Migrations
{
    /// <inheritdoc />
    public partial class phasetwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductDetails",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductDetails",
                table: "products");
        }
    }
}
