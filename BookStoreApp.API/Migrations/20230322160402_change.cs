using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7e870c6-5908-4af1-9706-d6135d64d50b",
                column: "ConcurrencyStamp",
                value: "b4a8d4a0-4126-4ca6-878e-32d8732a8686");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e32ee6db-a7e7-4d64-9fd6-032c0460e5f0",
                column: "ConcurrencyStamp",
                value: "36dda550-e541-49f4-8bfb-153fd9bdcff7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "377a5c55-a855-419c-93c5-b4bae9ac44e1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e01bec64-57a1-446d-8d29-8134488dcbd9", "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAELjvosAnaI+DY4EGtw6cqAdoxaoiPvudYguJzuGp4GQ809F4rmQVlQ6MQUXQkNmfqA==", "64d69eef-4f6f-4a2f-b265-2fb7ab91e4d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0ca56cb-6762-450c-b618-bf9219c28dbf",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "778e4eef-4e5f-419d-8cbd-7efcb9203cf5", "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEJdYv8YQOm0oYXQm2ktFe/aq08WT118ZR/3PrOO0pG1aJcUsipMEahYHmktMqKwYpQ==", "715349e2-8108-4b84-bbcc-bbde4353ec31" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7e870c6-5908-4af1-9706-d6135d64d50b",
                column: "ConcurrencyStamp",
                value: "9c2986a2-a760-413e-bbda-d714412a0426");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e32ee6db-a7e7-4d64-9fd6-032c0460e5f0",
                column: "ConcurrencyStamp",
                value: "fca7ff88-d32b-441e-b3e5-00f8a1fee1ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "377a5c55-a855-419c-93c5-b4bae9ac44e1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e34b8f43-64a9-4bfe-bd94-b5168f929892", null, "AQAAAAEAACcQAAAAEJgm7Mrn4ZRNI9Qx8Ylng4T3y7lbbl0DCmeyKloGBzqkaKLwu5WBPrAz/84i5c0dtw==", "4e599925-e8fc-4aa9-acba-5876501edafc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0ca56cb-6762-450c-b618-bf9219c28dbf",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a51afe7e-3546-4bf3-901b-45f5d70a80bf", null, "AQAAAAEAACcQAAAAEAvK8hXDhsORkiC/uAnap5ErA8ynPwoo+pdxpZijnSUx6DauRym/mOT9yNjkYcQAsg==", "c041da8d-caff-4c95-b446-013d3962fe1f" });
        }
    }
}
