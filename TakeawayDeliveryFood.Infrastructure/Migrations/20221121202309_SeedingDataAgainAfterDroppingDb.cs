using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TakeawayDeliveryFood.Data.Migrations
{
    public partial class SeedingDataAgainAfterDroppingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6615ac78-a9b6-4271-9192-ccf57b610779", 0, "FancyAddress", "33548f47-a395-4bf0-b6ee-1ba01b2ca863", "admin@mail.com", false, "AdminUser", false, null, "ADMIN@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEDMbdv4cAMcA1VeVy30agVt0WUb6QxyAKZ9VIT4i+S5HTC/qsizc6da9uFnCZZ4UTQ==", null, false, "f4f042a8-323e-4b1e-b4a6-ae47c48f5e3c", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dd3df4c6-425c-4da4-9314-7bb1a274ce43", 0, "FancyAddress", "3c12342d-f8f7-48f6-9a6d-a457da77c8fe", "customer@mail.com", false, "CustomerUser", false, null, "CUSTOMER@MAIL.COM", "CUSTOMER", "AQAAAAEAACcQAAAAEGUXSemXkZZAnEVBKkl6ubx58ylVUaWBkcKdRWqRN7smFn/OSNp/+g9cf4ikCT0A/g==", null, false, "ccec6b6f-3eeb-4bec-a535-54b733183ea3", false, "customer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
