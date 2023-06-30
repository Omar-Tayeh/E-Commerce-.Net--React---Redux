using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderEntityUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullAddress",
                table: "UserAddress",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_FullAddress",
                table: "Orders",
                newName: "ShippingAddress_FullName");

            migrationBuilder.RenameColumn(
                name: "Province",
                table: "OrderItem",
                newName: "Price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "UserAddress",
                newName: "FullAddress");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_FullName",
                table: "Orders",
                newName: "ShippingAddress_FullAddress");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "OrderItem",
                newName: "Province");
        }
    }
}
