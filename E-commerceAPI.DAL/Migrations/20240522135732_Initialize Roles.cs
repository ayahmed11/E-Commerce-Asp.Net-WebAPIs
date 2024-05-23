using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_commerceAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitializeRoles : Migration
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
                    { "2", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f74b512-e208-4f28-9c63-be019e2ea417", "19a8c1b0-b90c-4e94-8a88-b37cf8c0e668" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "384ed9be-c6c7-4218-9c24-f29ae28378aa", "c7025b4c-1323-47c1-be24-067e85d1f73a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32f61906-a103-48ea-8a33-080624b668a3", "8b09074e-96cc-40e5-b661-0c38ed214c92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0146f1e5-cff9-41a2-9597-74e16151890b", "8b75d18e-9f95-4218-9036-04060eb1f489" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "974badd6-c42a-488a-bb89-fdfdac887478", "3458074e-5027-4a89-ae81-b1e4eb1bb786" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02943b41-268e-460a-930d-64f30a66a69e", "e862c736-d9b4-4674-a67d-97a4ff8f8c3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e274251-7714-4297-8020-2968dee96088", "14cd99e5-617c-45ec-9954-613c72d9213d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eaf5dd48-81ae-4424-b567-fc33867fd6d0", "3b1854bc-89b0-4bb8-bfb3-7ca88f520bae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "afbffae9-328a-4b5c-8745-1be647a3b67d", "7d7ec415-4a5e-4765-9b59-b5ecc899a259" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86246ca7-f874-46b5-bd5c-bed9cd55aa85", "b68aa427-caa9-4780-a0dd-d87fe61e1861" });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 22, 16, 57, 32, 179, DateTimeKind.Local).AddTicks(4597));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6df90b13-b033-4510-9420-fdebae219cd8", "b37de797-1c4c-41c7-ab53-6bf629071f6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e938e31-494b-4c04-9f15-74fd856f21af", "d84c6fa3-f0a2-4866-b214-d357fca95e6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7293bf9e-672e-4af9-9ec6-7703821968a9", "6edd4025-953f-46dc-aa91-25da12b7f349" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aca54455-1f5d-4029-8b97-4ae506acc1aa", "79776dc9-3e7b-43bd-acb4-14ea639dd246" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f161eaf-df30-4fac-b26b-88b4305405a8", "a4b61a9c-96d7-45ec-96dd-8d28ae58a136" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e6c579a-2184-426c-a08d-32dc9545f508", "caee68a8-1d13-45e6-8f3d-f63243402ff0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d229c51-0ee1-46f3-9f09-fb4d78c28488", "a851f0fe-e38b-4579-a0d1-66c298c72a0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8295d0ad-8b79-49ad-8cec-7d7a8b2baf85", "8805e33a-8dc7-4c0e-9d53-cb6ddeffd7ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5717f20-1548-4b73-8fb7-c39ff34dc0df", "7d51f89e-2a41-401e-ac7f-44b42f009f40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1b0cf9f-c225-4f6a-9e31-c08287bc552a", "759be445-acf2-4405-83ce-779ed0e89dc9" });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 23, 17, 33, 391, DateTimeKind.Local).AddTicks(5646));
        }
    }
}
