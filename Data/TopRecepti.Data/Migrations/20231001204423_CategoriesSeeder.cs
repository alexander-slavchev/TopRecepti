using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopRecepti.Data.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedByUsedId",
                table: "Recipes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddedByUsedId",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
