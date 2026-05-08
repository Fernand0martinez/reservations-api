using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservations_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DeviceToken", "Email", "Name", "Password" },
                values: new object[] { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), null, "fernando@demo.edu", "Fernando Student", "123456" });
        }
    }
}
