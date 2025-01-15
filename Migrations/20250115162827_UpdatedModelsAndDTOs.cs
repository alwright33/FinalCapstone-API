using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cookistry_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModelsAndDTOs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 15, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 7, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 17, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 27, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 6, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 16, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 26, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 6, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 16, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 26, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "AccountCreated",
                value: new DateTime(2025, 1, 5, 10, 28, 27, 397, DateTimeKind.Local).AddTicks(3348));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
