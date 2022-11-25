using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TakeawayDeliveryFood.Data.Migrations
{
    public partial class ChangedUserAndRestaurantTablesAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_AspNetUsers_UserId1",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_UserId1",
                table: "Restaurants");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6615ac78-a9b6-4271-9192-ccf57b610779");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd3df4c6-425c-4da4-9314-7bb1a274ce43");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Restaurants");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Restaurants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Restaurants",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6615ac78-a9b6-4271-9192-ccf57b610779", 0, "FancyAddress", "33548f47-a395-4bf0-b6ee-1ba01b2ca863", "admin@mail.com", false, "AdminUser", false, null, "ADMIN@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEDMbdv4cAMcA1VeVy30agVt0WUb6QxyAKZ9VIT4i+S5HTC/qsizc6da9uFnCZZ4UTQ==", null, false, "f4f042a8-323e-4b1e-b4a6-ae47c48f5e3c", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dd3df4c6-425c-4da4-9314-7bb1a274ce43", 0, "FancyAddress", "3c12342d-f8f7-48f6-9a6d-a457da77c8fe", "customer@mail.com", false, "CustomerUser", false, null, "CUSTOMER@MAIL.COM", "CUSTOMER", "AQAAAAEAACcQAAAAEGUXSemXkZZAnEVBKkl6ubx58ylVUaWBkcKdRWqRN7smFn/OSNp/+g9cf4ikCT0A/g==", null, false, "ccec6b6f-3eeb-4bec-a535-54b733183ea3", false, "customer" });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_UserId1",
                table: "Restaurants",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_AspNetUsers_UserId1",
                table: "Restaurants",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
