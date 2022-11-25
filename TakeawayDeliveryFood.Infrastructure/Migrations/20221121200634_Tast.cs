using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TakeawayDeliveryFood.Data.Migrations
{
    public partial class Tast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6615ac78-a9b6-4271-9192-ccf57b610779");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd3df4c6-425c-4da4-9314-7bb1a274ce43");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "439688ef-1ee3-4471-8a0c-50086bfadb23", 0, "FancyAddress", "0d9478eb-4520-40c9-bb7a-a630de1bfe02", "customer@mail.com", false, "CustomerUser", false, null, "CUSTOMER@MAIL.COM", "CUSTOMER", "AQAAAAEAACcQAAAAENoAnc7JZdaAIBlepty5tlursjN1dNW3VKOFRkH4Jtq6G8Sl8R8IktLYM3qgthpZ0Q==", null, false, "0a3502f3-3efd-461a-a702-bf6434ed3ef3", false, "customer" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "82d60140-19e7-483a-9c47-0efd47305e41", 0, "FancyAddress", "d09bf1f9-a9b3-4fe8-a3e1-7a130ef22ee2", "admin@mail.com", false, "AdminUser", false, null, "ADMIN@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEHNcSBTHQYKOydOGZhLndzIqUZ35m56DJputNB8vmqM/4y6fdLm6wF2BPNnkDHqxjw==", null, false, "a36688e9-e154-4fb2-a318-7ac7ec3049d3", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "439688ef-1ee3-4471-8a0c-50086bfadb23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82d60140-19e7-483a-9c47-0efd47305e41");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6615ac78-a9b6-4271-9192-ccf57b610779", 0, "FancyAddress", "a97faa6f-7297-4bb4-b813-ff7f4d6adb6b", "admin@mail.com", false, "AdminUser", false, null, "ADMIN@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAENtxW9M6sW8qLKq6fqGMATTPC/sq9aez8L5zR5KY+fA3g0+BhY7KeQBI4EflmHyl5A==", null, false, "661a463c-e4ad-4ff1-b46b-6c04fd423c57", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dd3df4c6-425c-4da4-9314-7bb1a274ce43", 0, "FancyAddress", "73518364-b0a1-4a37-aeb4-22acdc58cadd", "customer@mail.com", false, "CustomerUser", false, null, "CUSTOMER@MAIL.COM", "CUSTOMER", "AQAAAAEAACcQAAAAEOqkCa8p6u0+rL3QWQljCWQwAXn4hAY3fmtTuUhjY3BTZyKqz8vbvzvZatC7m1a8kw==", null, false, "4d898745-9279-4e88-879c-3ab283b29fd7", false, "customer" });
        }
    }
}
