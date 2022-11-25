using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TakeawayDeliveryFood.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CuisineTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuisineTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RestaurantImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    WorkingHours = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    CuisineTypeId = table.Column<int>(type: "int", nullable: false),
                    DeliveryCost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MinOrderAmount = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DeliveryTime = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurants_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Restaurants_CuisineTypes_CuisineTypeId",
                        column: x => x.CuisineTypeId,
                        principalTable: "CuisineTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6615ac78-a9b6-4271-9192-ccf57b610779", 0, "FancyAddress", "a97faa6f-7297-4bb4-b813-ff7f4d6adb6b", "admin@mail.com", false, "AdminUser", false, null, "ADMIN@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAENtxW9M6sW8qLKq6fqGMATTPC/sq9aez8L5zR5KY+fA3g0+BhY7KeQBI4EflmHyl5A==", null, false, "661a463c-e4ad-4ff1-b46b-6c04fd423c57", false, "admin" },
                    { "dd3df4c6-425c-4da4-9314-7bb1a274ce43", 0, "FancyAddress", "73518364-b0a1-4a37-aeb4-22acdc58cadd", "customer@mail.com", false, "CustomerUser", false, null, "CUSTOMER@MAIL.COM", "CUSTOMER", "AQAAAAEAACcQAAAAEOqkCa8p6u0+rL3QWQljCWQwAXn4hAY3fmtTuUhjY3BTZyKqz8vbvzvZatC7m1a8kw==", null, false, "4d898745-9279-4e88-879c-3ab283b29fd7", false, "customer" }
                });

            migrationBuilder.InsertData(
                table: "CuisineTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Indian" },
                    { 2, "Burgers" },
                    { 3, "Sishi" },
                    { 4, "Italian" },
                    { 5, "Asian" },
                    { 6, "Bulgarian" },
                    { 7, "Arab" },
                    { 8, "Pizza" },
                    { 9, "Vegetarian" },
                    { 10, "Europian" },
                    { 11, "Mexican" },
                    { 12, "Fine dine" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "CuisineTypeId", "DeliveryCost", "DeliveryTime", "Description", "MinOrderAmount", "Name", "RestaurantImage", "UserId", "UserId1", "WorkingHours" },
                values: new object[,]
                {
                    { 1, 8, "Free", "20 - 50 min.", "Authentic Italian pizza", "Min. 10.00 lv.", "Genaro`s pizza", "https://tse1.mm.bing.net/th?id=OIP.VIHoNlxPTkXfW2i6DgfIbwHaF7&pid=Api", 0, null, "12:00 - 22:00" },
                    { 2, 1, "Free from 30.00 lv.", "30 - 50 min.", "Authentic Indian pizza", "Min. 20.00 lv.", "Taj Mahal", "https://tse2.mm.bing.net/th?id=OIP.8gNduGMsG-TnwPqLDlRQVQHaE8&pid=Api", 0, null, "11:00 - 23:00" },
                    { 3, 2, "Free from 20.00 lv.", "20 - 50 min.", "Best American style burgers", "Min. 20.00 lv.", "Burgers & Fries", "https://tse1.mm.bing.net/th?id=OIP.W0r1nOj-EPrXoziOqjjFPAHaE8&pid=Api", 0, null, "11:00 - 23:00" },
                    { 4, 11, "2.99 lv.", "20 - 50 min.", "Cosy Mexican restaurant in the heart of the big city", "Min. 20.00 lv.", "El Gatto", "https://tse4.mm.bing.net/th?id=OIP.Q74hg6Rl1KPSs-0sUXcXugHaE8&pid=Api", 0, null, "11:00 - 22:00" },
                    { 5, 3, "2.99 lv.", "30 - 60 min.", "Authentic sushi prepared from our sushi master", "Min. 20.00 lv.", "Kioto sushi", "https://tse3.mm.bing.net/th?id=OIP.2oT2R6wz3DbEm0NIePcJzwHaE_&pid=Api", 0, null, "11:00 - 24:00" },
                    { 6, 5, "5.99 lv.", "30 - 60 min.", "Authentic Chinese dishes", "Min. 10.00 lv.", "Golden dragon", "https://tse2.mm.bing.net/th?id=OIP.GvVXxZP0xh8i9a_1XFmTyAHaE8&pid=Api", 0, null, "12:00 - 22:00" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_CuisineTypeId",
                table: "Restaurants",
                column: "CuisineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_UserId1",
                table: "Restaurants",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "CuisineTypes");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6615ac78-a9b6-4271-9192-ccf57b610779");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd3df4c6-425c-4da4-9314-7bb1a274ce43");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");
        }
    }
}
