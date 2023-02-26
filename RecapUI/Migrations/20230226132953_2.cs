using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecapUI.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuantittPerUnit",
                table: "products",
                newName: "QuantityPerUnit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuantityPerUnit",
                table: "products",
                newName: "QuantittPerUnit");
        }
    }
}
