using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cookistry_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSavedRecipeDTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 8, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 18, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 28, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 7, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 17, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 27, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 7, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 17, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 27, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "AccountCreated",
                value: new DateTime(2025, 1, 6, 15, 48, 50, 626, DateTimeKind.Local).AddTicks(9161));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 16, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 8, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 18, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "AccountCreated",
                value: new DateTime(2024, 10, 28, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 7, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 17, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "AccountCreated",
                value: new DateTime(2024, 11, 27, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 7, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 17, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "AccountCreated",
                value: new DateTime(2024, 12, 27, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "AccountCreated",
                value: new DateTime(2025, 1, 6, 13, 34, 10, 15, DateTimeKind.Local).AddTicks(4130));
        }
    }
}
