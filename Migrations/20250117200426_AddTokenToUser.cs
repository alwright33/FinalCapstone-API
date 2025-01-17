using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cookistry_Server.Migrations
{
    /// <inheritdoc />
    public partial class AddTokenToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Users",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "AccountCreated", "Token" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2618), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "AccountCreated", "Token" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2681), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "AccountCreated", "Token" },
                values: new object[] { new DateTime(2024, 10, 29, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2692), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "AccountCreated", "Token" },
                values: new object[] { new DateTime(2024, 11, 8, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2700), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "AccountCreated", "Token" },
                values: new object[] { new DateTime(2024, 11, 18, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2707), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "AccountCreated", "Token" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2715), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "AccountCreated", "Token" },
                values: new object[] { new DateTime(2024, 12, 8, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2725), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "AccountCreated", "Token" },
                values: new object[] { new DateTime(2024, 12, 18, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2732), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "AccountCreated", "Token" },
                values: new object[] { new DateTime(2024, 12, 28, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2740), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "AccountCreated", "Token" },
                values: new object[] { new DateTime(2025, 1, 7, 14, 4, 25, 817, DateTimeKind.Local).AddTicks(2747), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 9, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 19, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 29, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 8, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 18, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 28, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 8, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 18, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 28, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "AccountCreated",
                value: new DateTime(2025, 1, 7, 11, 38, 49, 784, DateTimeKind.Local).AddTicks(1961));
        }
    }
}
