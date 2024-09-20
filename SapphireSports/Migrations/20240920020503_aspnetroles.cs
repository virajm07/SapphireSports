using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SapphireSports.Migrations
{
    /// <inheritdoc />
    public partial class aspnetroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "e4ad007c-4c5d-4a42-aa10-de5e73650397", "admin@sapphiresports.com", true, false, null, "ADMIN@SAPPHIRESPORTS.COM", "ADMIN", "AQAAAAIAAYagAAAAEFtJ7jx5TUTsI5pCm8Xi0bzhIU4IKuNNp8//5D9w/3c30s5uaeDvI+FkGuG3i/ZnOA==", null, false, "09b768e9-e82d-434d-a330-4a52fe55ce4d", false, "Admin" },
                    { "2", 0, "0da599a1-fde8-450f-9361-2ad212b83e98", "employee@example.com", true, false, null, "EMPLOYEE@EXAMPLE.COM", "EMPLOYEE", "AQAAAAIAAYagAAAAEMZuwB64nvBePbdIbQeisDhIgIli3F5FsuBuKAPgjQqV6YN1091MU7MTPFh2yLPNZw==", null, false, "93eb21ac-7195-45aa-bc9c-76e3dfd7558e", false, "Employee" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
