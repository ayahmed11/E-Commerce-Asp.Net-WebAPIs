using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_commerceAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "CartID", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserRole" },
                values: new object[,]
                {
                    { "1", 0, "123 Street,NewYork City", 23, 0, "b536351c-96ca-4ece-a43a-3064f0f88105", "aya@example.com", false, 1, false, null, null, null, null, null, false, "17f68623-41bd-407d-be11-f0df8ec5f0e0", false, "aya", "User" },
                    { "10", 0, "1616 Lane, Village", 29, 0, "3e7015b3-a34f-4dc7-9fde-98c9283ddf7b", "alaa@example.com", false, 0, false, null, null, null, null, null, false, "e195cccb-4ae9-4b45-99e1-3e984209cdcc", false, "alaa", "User" },
                    { "2", 0, "456 Avenue, Town", 25, 0, "d08f051d-81b4-4b31-a56d-a9b1da0665a5", "farah@example.com", false, 1, false, null, null, null, null, null, false, "622640d1-ef87-48ac-ac37-19baac9ab07a", false, "farah", "User" },
                    { "3", 0, "789 Boulevard, Metropolis", 35, 0, "1594d27d-c40c-4477-8918-79c22a2968ea", "rahma@example.com", false, 1, false, null, null, null, null, null, false, "bc2e0626-b242-4a80-bb42-36ca97421241", false, "rahma", "User" },
                    { "4", 0, "1010 Way, Village", 28, 0, "7bfc79b1-f141-4a88-93c1-7ad5755eb298", "amal@example.com", false, 1, false, null, null, null, null, null, false, "72ae3f43-48ec-42a1-869e-98ea65343383", false, "amal", "User" },
                    { "5", 0, "1111 Road, Hamlet", 22, 0, "aa03b2c3-6187-49eb-a084-7a4389e1af0a", "fadia@example.com", false, 1, false, null, null, null, null, null, false, "94231814-c56e-4236-a070-c1867aeb5e50", false, "fadia", "User" },
                    { "6", 0, "1212 Parkway, Borough", 40, 0, "71230616-5d18-4eaa-82f5-e921da03c0db", "rawan@example.com", false, 0, false, null, null, null, null, null, false, "3d76b3c2-7038-40da-a620-da89d79b302e", false, "zain", "User" },
                    { "7", 0, "1313 Plaza, City", 33, 0, "46c1d958-ee29-4bfc-89ed-39094dbd8388", "menna@example.com", false, 1, false, null, null, null, null, null, false, "6e692e62-c631-4128-b979-92de0b7d751e", false, "menna", "User" },
                    { "8", 0, "1414 Terrace, Town", 27, 0, "691745e0-9b1b-4b4f-9565-9f39991bdbdc", "ahmed@example.com", false, 0, false, null, null, null, null, null, false, "869fd797-c571-4073-849b-676a6fe070f5", false, "ahmed", "User" },
                    { "9", 0, "1515 Court, Metropolis", 24, 0, "ad57dd19-e5da-41c3-bcc2-9db579189faf", "mohamed@example.com", false, 0, false, null, null, null, null, null, false, "d2786240-441a-4222-b5eb-9dc018244d69", false, "mohamed", "User" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Home Appliances category description", "Home Appliances" },
                    { 2, "Sports category description", "Sports" },
                    { 3, "Smartphones category description", "Smartphones" },
                    { 4, "Laptops category description", "Laptops" },
                    { 5, "Books category description", "Books" },
                    { 6, "Furniture category description", "Furniture" },
                    { 7, "Clothing category description", "Clothing" },
                    { 8, "Toys category description", "Toys" },
                    { 9, "Electronics category description", "Electronics" },
                    { 10, "Beauty & Health category description", "Beauty & Health" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "ID", "UserId" },
                values: new object[,]
                {
                    { 1, "1" },
                    { 2, "2" },
                    { 3, "3" },
                    { 4, "4" },
                    { 5, "5" },
                    { 6, "6" },
                    { 7, "7" },
                    { 8, "8" },
                    { 9, "9" },
                    { 10, "10" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "CreatedDateTime", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7622), 32000m, "1" },
                    { 2, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7638), 34000m, "2" },
                    { 3, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7647), 18000m, "3" },
                    { 4, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7657), 59750m, "4" },
                    { 5, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7666), 80000m, "5" },
                    { 6, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7678), 3500m, "6" },
                    { 7, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7687), 33000m, "7" },
                    { 8, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7696), 15000m, "8" },
                    { 9, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7705), 2500m, "9" },
                    { 10, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7717), 7166m, "10" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Count", "Description", "ImageUrl", "Name", "Price", "Rate" },
                values: new object[,]
                {
                    { 1, 5, 20, "8 GB Storage, Waterproof, 6.8-inch Display, Adjustable Warm Light - Black", null, "Amazon Kindle Paperwhite", 12000m, 4 },
                    { 2, 10, 12, "Electric, Rechargeable, 5 Modes, Travel Case - White", null, "Philips Sonicare DiamondClean Toothbrush", 15000m, 5 },
                    { 3, 1, 15, "Industry Leading Noise Canceling Overhead Headphones, Wireless, Bluetooth, 30 Hours Battery Life - Black", null, "Sony WH-1000XM4", 20000m, 5 },
                    { 4, 2, 8, "2-in-1 Laptop, 11th Gen Intel Core i7, 16GB RAM, 1TB SSD, 13.3-inch FHD Touch Display, Windows 10 - Nightfall Black", null, "HP Spectre x360", 85000m, 4 },
                    { 5, 2, 5, "Apple 2022 MacBook Air laptop with M2 chip: 13.6-inch Liquid Retina display, 8GB RAM, 256GB SSD storage, 1080p FaceTime HD camera. Works with iPhone and iPad; Space Grey;", null, "Apple 2022 MacBook", 59750m, 4 },
                    { 6, 4, 7, "9 kg, Front Load, Fully Automatic, EcoSilence Drive, 1400 RPM - White", null, "Bosch Serie 6 Washing Machine", 40000m, 4 },
                    { 7, 7, 30, "Men's Running Shoes, Comfortable Fit, Durable, Size 10 - Black", null, "Nike Air Zoom Pegasus 38", 8000m, 5 },
                    { 8, 8, 10, "Building Kit, Collectible Model, Ages 16+, 7541 Pieces", null, "LEGO Star Wars Millennium Falcon", 55000m, 5 },
                    { 9, 9, 25, "Official Size, Indoor Use, High-Quality Composite Leather - Orange", null, "Wilson Evolution Game Basketball", 4500m, 4 },
                    { 10, 5, 20, "8 GB Storage, Waterproof, 6.8-inch Display, Adjustable Warm Light - Black", null, "Amazon Kindle Paperwhite", 12000m, 4 }
                });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "ID", "CartId", "CreatedDate", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7393), 4500m, 9, 2 },
                    { 2, 6, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7510), 15000m, 10, 1 },
                    { 3, 2, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7520), 66666m, 1, 1 },
                    { 4, 2, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7530), 59750m, 2, 1 },
                    { 5, 3, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7542), 40000m, 6, 2 },
                    { 6, 3, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7556), 20000m, 3, 1 },
                    { 7, 4, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7564), 12000m, 5, 3 },
                    { 8, 4, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7573), 85000m, 4, 1 },
                    { 9, 5, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7583), 8000m, 7, 1 },
                    { 10, 5, new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7595), 55000m, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedDate", "OrderId", "PriceTotal", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 66000m, 1, 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 119500m, 2, 0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 40000m, 6, 0 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 20000m, 3, 0 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 24000m, 5, 0 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 85000m, 4, 0 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 8000m, 7, 0 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 55000m, 8, 0 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 9000m, 9, 0 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 30000m, 10, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
