using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cookistry_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 7, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 17, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 27, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 6, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 16, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 26, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 6, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 16, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 26, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "AccountCreated",
                value: new DateTime(2025, 1, 5, 9, 52, 36, 157, DateTimeKind.Local).AddTicks(3827));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 9, 45, 25, 389, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 7, 9, 45, 25, 388, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 17, 9, 45, 25, 388, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 27, 9, 45, 25, 388, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 6, 9, 45, 25, 388, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 16, 9, 45, 25, 388, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 26, 9, 45, 25, 388, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 6, 9, 45, 25, 388, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 16, 9, 45, 25, 388, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 26, 9, 45, 25, 388, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "AccountCreated",
                value: new DateTime(2025, 1, 5, 9, 45, 25, 388, DateTimeKind.Local).AddTicks(9957));
        }
    }
}
