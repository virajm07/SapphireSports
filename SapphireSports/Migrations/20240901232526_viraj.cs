using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SapphireSports.Migrations
{
    /// <inheritdoc />
    public partial class viraj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Orders_OrdersOrderID",
                table: "Staff");

            migrationBuilder.DropTable(
                name: "CartProduct");

            migrationBuilder.DropIndex(
                name: "IX_Staff_OrdersOrderID",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "OrdersOrderID",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderStatus",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_StaffId",
                table: "Product",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StaffId",
                table: "Orders",
                column: "StaffId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ProductID",
                table: "Cart",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Product_ProductID",
                table: "Cart",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Staff_StaffId",
                table: "Orders",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "StaffId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Staff_StaffId",
                table: "Product",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Product_ProductID",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Staff_StaffId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Staff_StaffId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_StaffId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Orders_StaffId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Cart_ProductID",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrdersOrderID",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "OrderStatus",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "CartProduct",
                columns: table => new
                {
                    CartsCartID = table.Column<int>(type: "int", nullable: false),
                    ProductsProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProduct", x => new { x.CartsCartID, x.ProductsProductID });
                    table.ForeignKey(
                        name: "FK_CartProduct_Cart_CartsCartID",
                        column: x => x.CartsCartID,
                        principalTable: "Cart",
                        principalColumn: "CartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartProduct_Product_ProductsProductID",
                        column: x => x.ProductsProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_OrdersOrderID",
                table: "Staff",
                column: "OrdersOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_ProductsProductID",
                table: "CartProduct",
                column: "ProductsProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Orders_OrdersOrderID",
                table: "Staff",
                column: "OrdersOrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
