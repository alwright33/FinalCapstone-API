using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cookistry_Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CookTime = table.Column<int>(type: "integer", nullable: false),
                    PrepTime = table.Column<int>(type: "integer", nullable: false),
                    Difficulty = table.Column<string>(type: "text", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    AccountCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "integer", nullable: false),
                    IngredientId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<decimal>(type: "numeric", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    PrepDetails = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.RecipeId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeSteps",
                columns: table => new
                {
                    StepId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RecipeId = table.Column<int>(type: "integer", nullable: false),
                    StepNumber = table.Column<int>(type: "integer", nullable: false),
                    StepInstruction = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeSteps", x => x.StepId);
                    table.ForeignKey(
                        name: "FK_RecipeSteps_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavedRecipes",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RecipeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedRecipes", x => new { x.UserId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_SavedRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavedRecipes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
                    { 1, "Flour" },
                    { 2, "Sugar" },
                    { 3, "Brown Sugar" },
                    { 4, "Salt" },
                    { 5, "Baking Soda" },
                    { 6, "Baking Powder" },
                    { 7, "Yeast" },
                    { 8, "Cornstarch" },
                    { 9, "Olive Oil" },
                    { 10, "Vegetable Oil" },
                    { 11, "Milk" },
                    { 12, "Butter" },
                    { 13, "Heavy Cream" },
                    { 14, "Sour Cream" },
                    { 15, "Yogurt" },
                    { 16, "Cheddar Cheese" },
                    { 17, "Mozzarella Cheese" },
                    { 18, "Cream Cheese" },
                    { 19, "Parmesan Cheese" },
                    { 20, "Eggs" },
                    { 21, "Boneless, Skinless Chicken Breast" },
                    { 22, "Ground Beef" },
                    { 23, "Pork Chops" },
                    { 24, "Salmon" },
                    { 25, "Lobster" },
                    { 26, "Shrimp" },
                    { 27, "Bacon" },
                    { 28, "Turkey" },
                    { 29, "Sausage" },
                    { 30, "Lamb" },
                    { 31, "Onion" },
                    { 32, "Garlic" },
                    { 33, "Carrot" },
                    { 34, "Celery" },
                    { 35, "Tomato" },
                    { 36, "Red Bell Pepper" },
                    { 37, "Green Bell Pepper" },
                    { 38, "Spinach" },
                    { 39, "Broccoli" },
                    { 40, "Zucchini" },
                    { 41, "Cucumber" },
                    { 42, "Potato" },
                    { 43, "Sweet Potato" },
                    { 44, "Mushrooms" },
                    { 45, "Peas" },
                    { 46, "Corn" },
                    { 47, "Lettuce" },
                    { 48, "Cabbage" },
                    { 49, "Chili Pepper" },
                    { 50, "Lime" },
                    { 51, "Lemon" },
                    { 52, "Apple" },
                    { 53, "Banana" },
                    { 54, "Orange" },
                    { 55, "Strawberry" },
                    { 56, "Blueberry" },
                    { 57, "Grapes" },
                    { 58, "Pineapple" },
                    { 59, "Watermelon" },
                    { 60, "Mango" },
                    { 61, "Papaya" },
                    { 62, "Cinnamon" },
                    { 63, "Nutmeg" },
                    { 64, "Ginger" },
                    { 65, "Turmeric" },
                    { 66, "Cumin" },
                    { 67, "Paprika" },
                    { 68, "Coriander" },
                    { 69, "Black Pepper" },
                    { 70, "Red Pepper Flakes" },
                    { 71, "Vanilla Extract" },
                    { 72, "Honey" },
                    { 73, "Soy Sauce" },
                    { 74, "Vinegar" },
                    { 75, "Maple Syrup" },
                    { 76, "Pasta" },
                    { 77, "Tomato Sauce" },
                    { 78, "Bread" },
                    { 79, "Garlic Powder" },
                    { 80, "Fish Stock" },
                    { 81, "White Wine" },
                    { 82, "Tomato Paste" },
                    { 83, "Tortillas" },
                    { 84, "Rice" },
                    { 85, "Puff pastry" },
                    { 86, "Beef tenderloin" },
                    { 87, "Eggplant" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "AuthorId", "CookTime", "CreatedDate", "Description", "Difficulty", "Name", "PrepTime" },
                values: new object[,]
                {
                    { 1, 1, 5, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3166), "Quick and easy scrambled eggs for breakfast.", "Beginner", "Simple Scrambled Eggs", 2 },
                    { 2, 2, 10, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3169), "A golden, cheesy sandwich.", "Beginner", "Classic Grilled Cheese", 5 },
                    { 3, 3, 20, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3171), "A simple pasta dish with a rich tomato sauce.", "Beginner", "Pasta with Tomato Sauce", 10 },
                    { 4, 4, 30, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3173), "Crispy potatoes baked to perfection.", "Beginner", "Oven-Baked Potatoes", 10 },
                    { 5, 5, 5, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3175), "A refreshing mix of seasonal fruits.", "Beginner", "Fruit Salad", 10 },
                    { 6, 6, 20, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3177), "A flavorful stir-fry with tender chicken and crisp vegetables.", "Intermediate", "Chicken Stir-Fry", 15 },
                    { 7, 7, 40, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3178), "A creamy and delicious beef stroganoff.", "Intermediate", "Beef Stroganoff", 20 },
                    { 8, 8, 25, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3180), "A customizable homemade pizza with your favorite toppings.", "Intermediate", "Homemade Pizza", 20 },
                    { 9, 9, 15, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3184), "Delicious shrimp tacos with a zesty lime crema.", "Intermediate", "Shrimp Tacos", 10 },
                    { 10, 10, 45, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3186), "Bell peppers stuffed with a savory mixture of rice, meat, and vegetables.", "Intermediate", "Stuffed Bell Peppers", 25 },
                    { 11, 1, 90, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3188), "A luxurious dish featuring beef tenderloin wrapped in puff pastry.", "Advanced", "Beef Wellington", 60 },
                    { 12, 2, 60, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3190), "A beautifully layered vegetable dish inspired by French cuisine.", "Advanced", "Ratatouille", 30 },
                    { 13, 3, 20, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3191), "Flaky, buttery croissants made from scratch.", "Advanced", "Croissants", 240 },
                    { 14, 4, 120, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3193), "A classic French dish featuring duck with a sweet orange glaze.", "Advanced", "Duck à l'Orange", 40 },
                    { 15, 5, 50, new DateTime(2025, 1, 22, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(3195), "A rich and creamy lobster soup.", "Advanced", "Lobster Bisque", 30 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AccountCreated", "Email", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 14, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(2754), "awright@code.com", "Austin", "Wright", "DtT3pAmyMGn7Egv1u/2nbsZg3fKB4gCC+ukM0nRie5Q=", "alwright33" },
                    { 2, new DateTime(2024, 10, 24, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(2815), "bakersue@example.com", "Sue", "Smith", "uOcDVLptmT9p1wbHDPiiCwv+LCViKPJ9+Z+Kfx6jvik=", "BakerSue" },
                    { 3, new DateTime(2024, 11, 3, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(2825), "grillmaster@example.com", "James", "Brown", "72iPsaCHr4uafyLrFB/Z6HBxYJVOjIVaRavYSONVFuU=", "GrillMaster" },
                    { 4, new DateTime(2024, 11, 13, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(2835), "veggiequeen@example.com", "Emily", "Clark", "KGikZ6W4f1WBalePRo6tlJrAQMzntaBQ7yEoAXhxkSw=", "VeggieQueen" },
                    { 5, new DateTime(2024, 11, 23, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(2846), "quickcook@example.com", "Oliver", "Martinez", "QWeGev5EHzBSj1WtPzFm0DS5WiBlaLZ2d3AViEV7i7c=", "QuickCook" },
                    { 6, new DateTime(2024, 12, 3, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(2859), "dessertlover@example.com", "Sophia", "Johnson", "wfcAOn8hcKoA27v0/upQNo4p/Zm49n83ORc1jqS4Gdw=", "DessertLover" },
                    { 7, new DateTime(2024, 12, 13, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(2866), "homechef@example.com", "William", "Garcia", "cY3PUg7zYmW/61Eq7e2ouhbK3zHke7ILOohE9mDIp5w=", "HomeChef" },
                    { 8, new DateTime(2024, 12, 23, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(2874), "healthyeats@example.com", "Ava", "Hernandez", "jBo1GEUrrv1hh3Iv+oMf9kpMxJE/vmjXYoCfbhC5788=", "HealthyEats" },
                    { 9, new DateTime(2025, 1, 2, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(2881), "spicyfan@example.com", "Ethan", "Lopez", "1G9QiTMpLCmRc5XH8v8KUvtZegMdZBgaCbFYJSlO0/o=", "SpicyFan" },
                    { 10, new DateTime(2025, 1, 12, 9, 46, 24, 484, DateTimeKind.Local).AddTicks(2888), "foodexplorer@example.com", "Isabella", "Gonzalez", "ipDWxJMgygUVBvM36eigRWbP+QiwaCKlrOzA96rrRC8=", "FoodExplorer" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "PrepDetails", "Quantity", "Unit" },
                values: new object[,]
                {
                    { 4, 1, "To taste", 0.25m, "tsp" },
                    { 12, 1, "Melted", 1m, "tbsp" },
                    { 20, 1, "", 2m, "large" },
                    { 69, 1, "Freshly ground", 0.25m, "tsp" },
                    { 12, 2, "Softened", 1m, "tbsp" },
                    { 16, 2, "Thinly sliced", 1m, "slice" },
                    { 17, 2, "Thinly sliced", 1m, "slice" },
                    { 78, 2, "Plain", 2m, "slices" },
                    { 4, 3, "To taste", 0.5m, "tsp" },
                    { 12, 3, "Melted", 1m, "tbsp" },
                    { 32, 3, "Minced", 2m, "cloves" },
                    { 69, 3, "Freshly ground", 0.5m, "tsp" },
                    { 76, 3, "Cooked al dente", 200m, "grams" },
                    { 77, 3, "Heated", 1m, "cup" },
                    { 4, 4, "Sprinkled", 1m, "tsp" },
                    { 9, 4, "Drizzled", 2m, "tbsp" },
                    { 42, 4, "Diced", 3m, "pieces" },
                    { 69, 4, "Freshly ground", 0.5m, "tsp" },
                    { 50, 5, "Juiced", 1m, "piece" },
                    { 55, 5, "Chopped", 1m, "cup" },
                    { 56, 5, "Washed", 1m, "cup" },
                    { 60, 5, "Chopped", 1m, "cup" },
                    { 72, 5, "Drizzled", 1m, "tbsp" },
                    { 4, 6, "To taste", 0.5m, "tsp" },
                    { 9, 6, "Heated", 2m, "tbsp" },
                    { 21, 6, "Diced", 300m, "grams" },
                    { 32, 6, "Minced", 2m, "cloves" },
                    { 36, 6, "Sliced", 1m, "piece" },
                    { 39, 6, "Chopped", 200m, "grams" },
                    { 69, 6, "Freshly ground", 0.5m, "tsp" },
                    { 73, 6, "Mixed", 3m, "tbsp" },
                    { 4, 7, "To taste", 0.5m, "tsp" },
                    { 12, 7, "Melted", 2m, "tbsp" },
                    { 13, 7, "Whipped", 200m, "ml" },
                    { 22, 7, "Sliced", 500m, "grams" },
                    { 31, 7, "Chopped", 1m, "piece" },
                    { 44, 7, "Sliced", 200m, "grams" },
                    { 69, 7, "Freshly ground", 1m, "tsp" },
                    { 73, 7, "Mixed", 2m, "tbsp" },
                    { 1, 8, "All-purpose flour, sifted", 2m, "cups" },
                    { 4, 8, "To taste", 1m, "tsp" },
                    { 7, 8, "Activated in warm water", 1m, "tbsp" },
                    { 11, 8, "Warm", 0.75m, "cup" },
                    { 12, 8, "Melted", 2m, "tbsp" },
                    { 16, 8, "Shredded", 1m, "cup" },
                    { 17, 8, "Shredded", 1m, "cup" },
                    { 31, 8, "Sliced", 1m, "half" },
                    { 37, 8, "Diced", 1m, "whole" },
                    { 44, 8, "Sliced", 0.5m, "cup" },
                    { 69, 8, "Freshly ground", 0.5m, "tsp" },
                    { 77, 8, "Spread on the base", 1m, "cup" },
                    { 4, 9, "To taste", 0.5m, "tsp" },
                    { 9, 9, "For cooking", 2m, "tbsp" },
                    { 13, 9, "Whipped", 0.5m, "cup" },
                    { 26, 9, "Peeled and deveined", 300m, "grams" },
                    { 36, 9, "Sliced", 1m, "whole" },
                    { 47, 9, "Shredded", 1m, "cup" },
                    { 50, 9, "Juiced", 1m, "whole" },
                    { 69, 9, "Freshly ground", 0.5m, "tsp" },
                    { 83, 9, "Small tortillas", 4m, "whole" },
                    { 4, 10, "To taste", 0.5m, "tsp" },
                    { 12, 10, "Melted", 2m, "tbsp" },
                    { 16, 10, "Shredded", 0.5m, "cup" },
                    { 22, 10, "Cooked and crumbled", 300m, "grams" },
                    { 31, 10, "Chopped", 1m, "half" },
                    { 36, 10, "Tops removed, seeds and membranes cleared", 4m, "whole" },
                    { 69, 10, "Freshly ground", 0.5m, "tsp" },
                    { 77, 10, "Heated", 1m, "cup" },
                    { 84, 10, "Cooked", 1m, "cup" },
                    { 4, 11, "To taste", 1m, "tsp" },
                    { 12, 11, "Softened", 100m, "grams" },
                    { 20, 11, "Beaten", 1m, "large" },
                    { 44, 11, "Finely chopped", 200m, "grams" },
                    { 69, 11, "Freshly ground", 0.5m, "tsp" },
                    { 73, 11, "Brushed", 1m, "tbsp" },
                    { 78, 11, "Thawed", 1m, "sheet" },
                    { 86, 11, "Trimmed", 1m, "kg" },
                    { 4, 12, "To taste", 1m, "tsp" },
                    { 9, 12, "For drizzling", 2m, "tbsp" },
                    { 35, 12, "Sliced", 2m, "pieces" },
                    { 40, 12, "Sliced", 1m, "whole" },
                    { 69, 12, "Freshly ground", 0.5m, "tsp" },
                    { 73, 12, "Base layer", 1m, "cup" },
                    { 87, 12, "Sliced", 1m, "whole" },
                    { 1, 13, "All-purpose flour, sifted", 4m, "cups" },
                    { 4, 13, "To taste", 1m, "tsp" },
                    { 7, 13, "Activated in warm water", 2m, "tsp" },
                    { 11, 13, "Warm", 1.25m, "cups" },
                    { 12, 13, "Chilled and cubed", 300m, "grams" },
                    { 20, 13, "Beaten", 1m, "piece" },
                    { 2, 14, "For caramelization", 3m, "tbsp" },
                    { 4, 14, "To taste", 1m, "tsp" },
                    { 28, 14, "Whole duck, cleaned", 1m, "piece" },
                    { 54, 14, "Juiced and zested", 2m, "pieces" },
                    { 69, 14, "Freshly ground", 0.5m, "tsp" },
                    { 73, 14, "For glaze", 2m, "tbsp" },
                    { 74, 14, "White vinegar", 0.25m, "cup" },
                    { 4, 15, "To taste", 1m, "tsp" },
                    { 12, 15, "Melted", 3m, "tbsp" },
                    { 13, 15, "Whipped", 1m, "cup" },
                    { 25, 15, "Cooked and shelled", 2m, "pieces" },
                    { 31, 15, "Chopped", 1m, "half" },
                    { 33, 15, "Chopped", 1m, "whole" },
                    { 34, 15, "Chopped", 1m, "whole" },
                    { 69, 15, "Freshly ground", 1m, "tsp" },
                    { 80, 15, "Used as fish stock", 1m, "cup" },
                    { 81, 15, "Dry", 0.5m, "cup" },
                    { 82, 15, "Mixed into broth", 2m, "tbsp" }
                });

            migrationBuilder.InsertData(
                table: "RecipeSteps",
                columns: new[] { "StepId", "RecipeId", "StepInstruction", "StepNumber" },
                values: new object[,]
                {
                    { 1, 1, "Crack the eggs into a bowl and whisk until the yolks and whites are fully combined.", 1 },
                    { 2, 1, "Heat butter in a non-stick pan over medium heat until melted.", 2 },
                    { 3, 1, "Pour the whisked eggs into the pan and let them cook for a few seconds.", 3 },
                    { 4, 1, "Use a spatula to gently stir the eggs, bringing the cooked edges toward the center.", 4 },
                    { 5, 1, "Continue stirring until the eggs are just set but still soft and slightly runny.", 5 },
                    { 6, 1, "Season with salt and pepper to taste, then serve immediately.", 6 },
                    { 7, 2, "Spread softened butter on one side of each bread slice.", 1 },
                    { 8, 2, "Place a slice of mozzarella cheese between the unbuttered sides of the bread slices to form a sandwich.", 2 },
                    { 9, 2, "Heat a non-stick skillet over medium heat.", 3 },
                    { 10, 2, "Place the sandwich in the skillet, buttered side down.", 4 },
                    { 11, 2, "Cook for 3-4 minutes until the bread is golden and crispy.", 5 },
                    { 12, 2, "Flip the sandwich carefully and cook the other side for an additional 3-4 minutes until golden and the cheese is melted.", 6 },
                    { 13, 2, "Remove from the skillet, let cool slightly, slice, and serve warm.", 7 },
                    { 14, 3, "Bring a pot of salted water to a boil and cook pasta according to package instructions until al dente. Drain and set aside.", 1 },
                    { 15, 3, "In a large skillet, melt butter over medium heat and sauté minced garlic until fragrant, about 1-2 minutes.", 2 },
                    { 16, 3, "Add the tomato sauce to the skillet and stir well. Simmer for 5 minutes to allow the flavors to meld.", 3 },
                    { 17, 3, "Season the sauce with salt and freshly ground black pepper to taste.", 4 },
                    { 18, 3, "Toss the cooked pasta into the sauce and mix until well coated.", 5 },
                    { 19, 3, "Serve warm, garnished with grated Parmesan cheese if desired.", 6 },
                    { 20, 4, "Preheat your oven to 200°C (400°F).", 1 },
                    { 21, 4, "Wash and dice the potatoes into evenly sized pieces.", 2 },
                    { 22, 4, "Place the diced potatoes in a bowl and drizzle with olive oil.", 3 },
                    { 23, 4, "Season with salt and freshly ground black pepper. Toss to coat evenly.", 4 },
                    { 24, 4, "Spread the potatoes in a single layer on a baking sheet.", 5 },
                    { 25, 4, "Bake in the preheated oven for 25-30 minutes, turning halfway through, until golden and crispy.", 6 },
                    { 26, 4, "Remove from the oven and serve hot as a side dish or snack.", 7 },
                    { 27, 5, "Wash and prepare all the fruits by chopping them into bite-sized pieces.", 1 },
                    { 28, 5, "Place the chopped strawberries, blueberries, and mango in a large mixing bowl.", 2 },
                    { 29, 5, "Squeeze fresh lime juice over the fruits.", 3 },
                    { 30, 5, "Drizzle honey over the fruit mixture for added sweetness.", 4 },
                    { 31, 5, "Gently toss all the ingredients together until well combined.", 5 },
                    { 32, 5, "Serve immediately or chill in the refrigerator for 10 minutes before serving.", 6 },
                    { 33, 6, "Heat olive oil in a large skillet or wok over medium-high heat.", 1 },
                    { 34, 6, "Add diced chicken breast to the skillet and cook until browned and fully cooked, about 5-7 minutes.", 2 },
                    { 35, 6, "Remove the chicken from the skillet and set aside.", 3 },
                    { 36, 6, "In the same skillet, add minced garlic and sauté for 1 minute until fragrant.", 4 },
                    { 37, 6, "Add broccoli and red bell pepper to the skillet. Stir-fry for 3-4 minutes until vegetables are tender but crisp.", 5 },
                    { 38, 6, "Return the cooked chicken to the skillet and pour in the soy sauce. Stir well to coat everything evenly.", 6 },
                    { 39, 6, "Season with salt and freshly ground black pepper to taste.", 7 },
                    { 40, 6, "Serve hot over steamed rice or noodles, if desired.", 8 },
                    { 41, 7, "Melt butter in a large skillet over medium-high heat.", 1 },
                    { 42, 7, "Add the sliced beef to the skillet and cook until browned. Remove and set aside.", 2 },
                    { 43, 7, "In the same skillet, sauté chopped onions until translucent, about 3-5 minutes.", 3 },
                    { 44, 7, "Add sliced mushrooms to the skillet and cook for another 5 minutes until softened.", 4 },
                    { 45, 7, "Return the cooked beef to the skillet and stir to combine with the onions and mushrooms.", 5 },
                    { 46, 7, "Pour in the heavy cream and soy sauce. Stir well and bring to a gentle simmer.", 6 },
                    { 47, 7, "Season with salt and freshly ground black pepper to taste.", 7 },
                    { 48, 7, "Simmer for 10-15 minutes, stirring occasionally, until the sauce thickens.", 8 },
                    { 49, 7, "Serve hot over egg noodles or rice, garnished with fresh parsley if desired.", 9 },
                    { 50, 8, "In a large bowl, combine warm milk, yeast, and a pinch of sugar. Let it sit for 5 minutes until frothy.", 1 },
                    { 51, 8, "Add sifted flour, melted butter, and salt to the yeast mixture. Mix until a dough forms.", 2 },
                    { 52, 8, "Knead the dough on a floured surface for 8-10 minutes until smooth and elastic.", 3 },
                    { 53, 8, "Place the dough in a lightly oiled bowl, cover with a clean towel, and let it rise in a warm place for 1 hour or until doubled in size.", 4 },
                    { 54, 8, "Preheat the oven to 220°C (425°F) and prepare a baking sheet or pizza stone.", 5 },
                    { 55, 8, "Punch down the dough and roll it out to your desired pizza size and thickness.", 6 },
                    { 56, 8, "Spread tomato sauce evenly over the pizza base, leaving a small border around the edges.", 7 },
                    { 57, 8, "Sprinkle shredded cheddar and mozzarella cheese over the sauce.", 8 },
                    { 58, 8, "Add toppings such as sliced onions, diced green bell pepper, and mushrooms.", 9 },
                    { 59, 8, "Bake in the preheated oven for 20-25 minutes or until the crust is golden and the cheese is bubbly.", 10 },
                    { 60, 8, "Remove from the oven, let it cool for a few minutes, slice, and serve hot.", 11 },
                    { 61, 9, "In a bowl, toss the shrimp with lime juice, salt, and pepper. Let it marinate for 5 minutes.", 1 },
                    { 62, 9, "Heat olive oil in a skillet over medium-high heat.", 2 },
                    { 63, 9, "Add the shrimp to the skillet and cook for 2-3 minutes per side until pink and fully cooked. Remove from heat.", 3 },
                    { 64, 9, "In a small bowl, mix sour cream with a squeeze of lime juice to create the lime crema.", 4 },
                    { 65, 9, "Warm the tortillas in a dry skillet or microwave.", 5 },
                    { 66, 9, "Assemble the tacos by layering shredded lettuce, cooked shrimp, and sliced red bell peppers onto the tortillas.", 6 },
                    { 67, 9, "Drizzle with lime crema and serve immediately.", 7 },
                    { 68, 10, "Preheat the oven to 190°C (375°F).", 1 },
                    { 69, 10, "Prepare the bell peppers by cutting off the tops and removing seeds and membranes.", 2 },
                    { 70, 10, "In a skillet, melt butter over medium heat and sauté the chopped onion until translucent.", 3 },
                    { 71, 10, "Add the ground beef to the skillet and cook until browned. Drain excess fat if necessary.", 4 },
                    { 72, 10, "Stir in the cooked rice, tomato sauce, salt, and pepper. Mix until well combined.", 5 },
                    { 73, 10, "Stuff the bell peppers with the beef and rice mixture, pressing it down gently.", 6 },
                    { 74, 10, "Place the stuffed peppers upright in a baking dish and cover with foil.", 7 },
                    { 75, 10, "Bake in the preheated oven for 30 minutes.", 8 },
                    { 76, 10, "Remove the foil, sprinkle shredded cheddar cheese on top, and bake for an additional 10-15 minutes until the cheese is melted and bubbly.", 9 },
                    { 77, 10, "Serve warm, garnished with fresh parsley if desired.", 10 },
                    { 78, 11, "Season the beef tenderloin with salt and pepper, then sear it in olive oil over high heat until browned on all sides.", 1 },
                    { 79, 11, "Allow the beef to cool, then spread softened butter over its surface.", 2 },
                    { 80, 11, "Cook the finely chopped mushrooms in a dry skillet until moisture evaporates, then cool.", 3 },
                    { 81, 11, "Spread the mushrooms over the beef and wrap it in plastic wrap tightly. Chill for 20 minutes.", 4 },
                    { 82, 11, "Roll out the puff pastry and wrap it around the beef, sealing the edges.", 5 },
                    { 83, 11, "Brush the pastry with beaten egg and make a few slits for ventilation.", 6 },
                    { 84, 11, "Bake in a preheated oven at 200°C (400°F) for 40 minutes or until the pastry is golden brown.", 7 },
                    { 85, 11, "Rest for 10 minutes before slicing and serving.", 8 },
                    { 86, 12, "Preheat the oven to 190°C (375°F).", 1 },
                    { 87, 12, "Spread tomato sauce evenly over the bottom of a baking dish.", 2 },
                    { 88, 12, "Layer sliced tomatoes, zucchini, and eggplant alternately in the dish, slightly overlapping each piece.", 3 },
                    { 89, 12, "Drizzle olive oil over the layered vegetables and season with salt and pepper.", 4 },
                    { 90, 12, "Cover the dish with foil and bake for 40 minutes.", 5 },
                    { 91, 12, "Remove the foil and bake for an additional 10-15 minutes until the vegetables are tender and slightly browned.", 6 },
                    { 92, 12, "Serve warm as a side dish or main course.", 7 },
                    { 93, 13, "In a bowl, dissolve yeast in warm milk and let it sit for 5 minutes until frothy.", 1 },
                    { 94, 13, "Add flour, salt, and a small amount of butter. Knead into a smooth dough.", 2 },
                    { 95, 13, "Roll out the dough into a rectangle and chill in the refrigerator for 30 minutes.", 3 },
                    { 96, 13, "Layer chilled butter over the dough and fold it in thirds. Roll out and repeat 3 times.", 4 },
                    { 97, 13, "Chill the dough for another 30 minutes, then roll out and cut into triangles.", 5 },
                    { 98, 13, "Roll each triangle tightly into a crescent shape and place on a baking sheet.", 6 },
                    { 99, 13, "Let the croissants rise in a warm place for 1 hour until doubled in size.", 7 },
                    { 100, 13, "Brush with beaten egg and bake in a preheated oven at 200°C (400°F) for 20 minutes until golden brown.", 8 },
                    { 101, 13, "Cool slightly before serving warm.", 9 },
                    { 102, 14, "Preheat the oven to 180°C (350°F).", 1 },
                    { 103, 14, "Season the duck with salt and pepper inside and out.", 2 },
                    { 104, 14, "Place the duck in a roasting pan and roast for 1 hour and 30 minutes, basting occasionally.", 3 },
                    { 105, 14, "In a saucepan, combine orange juice, orange zest, sugar, and vinegar. Simmer until reduced to a syrupy consistency.", 4 },
                    { 106, 14, "Add soy sauce to the glaze and mix well. Set aside.", 5 },
                    { 107, 14, "Brush the glaze over the duck during the last 20 minutes of roasting.", 6 },
                    { 108, 14, "Remove the duck from the oven and let it rest for 10 minutes before carving.", 7 },
                    { 109, 14, "Serve warm with additional orange glaze on the side.", 8 },
                    { 110, 15, "Remove the lobster from the pot, let it cool, and then extract the meat from the shells.", 2 },
                    { 111, 15, "Reserve the shells and chop the lobster meat into bite-sized pieces.", 3 },
                    { 112, 15, "In a large pot, heat butter over medium heat and sauté onions, celery, and carrots until soft.", 4 },
                    { 113, 15, "Add the reserved lobster shells and cook for 5 minutes to release their flavor.", 5 },
                    { 114, 15, "Pour in the fish stock, white wine, and tomato paste. Simmer for 20 minutes.", 6 },
                    { 115, 15, "Strain the mixture through a fine mesh sieve, discarding the solids, and return the liquid to the pot.", 7 },
                    { 116, 15, "Stir in heavy cream and simmer gently for another 10 minutes, seasoning with salt and pepper to taste.", 8 },
                    { 117, 15, "Add the chopped lobster meat back into the pot and heat through without boiling.", 9 },
                    { 118, 15, "Serve the lobster bisque hot, garnished with fresh parsley or chives if desired.", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeSteps_RecipeId",
                table: "RecipeSteps",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedRecipes_RecipeId",
                table: "SavedRecipes",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "RecipeSteps");

            migrationBuilder.DropTable(
                name: "SavedRecipes");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
