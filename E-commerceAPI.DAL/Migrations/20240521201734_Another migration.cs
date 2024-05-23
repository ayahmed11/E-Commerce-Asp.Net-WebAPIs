using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_commerceAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Anothermigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b536351c-96ca-4ece-a43a-3064f0f88105", "17f68623-41bd-407d-be11-f0df8ec5f0e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3e7015b3-a34f-4dc7-9fde-98c9283ddf7b", "e195cccb-4ae9-4b45-99e1-3e984209cdcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d08f051d-81b4-4b31-a56d-a9b1da0665a5", "622640d1-ef87-48ac-ac37-19baac9ab07a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1594d27d-c40c-4477-8918-79c22a2968ea", "bc2e0626-b242-4a80-bb42-36ca97421241" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7bfc79b1-f141-4a88-93c1-7ad5755eb298", "72ae3f43-48ec-42a1-869e-98ea65343383" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa03b2c3-6187-49eb-a084-7a4389e1af0a", "94231814-c56e-4236-a070-c1867aeb5e50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "71230616-5d18-4eaa-82f5-e921da03c0db", "3d76b3c2-7038-40da-a620-da89d79b302e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46c1d958-ee29-4bfc-89ed-39094dbd8388", "6e692e62-c631-4128-b979-92de0b7d751e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "691745e0-9b1b-4b4f-9565-9f39991bdbdc", "869fd797-c571-4073-849b-676a6fe070f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad57dd19-e5da-41c3-bcc2-9db579189faf", "d2786240-441a-4222-b5eb-9dc018244d69" });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2024, 5, 21, 15, 28, 14, 758, DateTimeKind.Local).AddTicks(7717));
        }
    }
}
