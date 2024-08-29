using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SapphireSports.Migrations
{
    /// <inheritdoc />
    public partial class virajpig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Orders",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Orders");
        }
    }
}
