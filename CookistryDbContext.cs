using Microsoft.EntityFrameworkCore;
using Cookistry.Models;
using System.Security.Cryptography;
using System.Text;


public class CookistryDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    public DbSet<SavedRecipe> SavedRecipes { get; set; }
    public DbSet<RecipeStep> RecipeSteps { get; set; }

    public CookistryDbContext(DbContextOptions<CookistryDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<SavedRecipe>()
             .HasKey(sr => new { sr.UserId, sr.RecipeId });

        modelBuilder.Entity<SavedRecipe>()
            .HasOne(sr => sr.Recipe)
            .WithMany()
            .HasForeignKey(sr => sr.RecipeId);

        modelBuilder.Entity<SavedRecipe>()
            .HasOne(sr => sr.User)
            .WithMany()
            .HasForeignKey(sr => sr.UserId);


        modelBuilder.Entity<RecipeIngredient>()
            .HasKey(ri => new { ri.RecipeId, ri.IngredientId });

        modelBuilder.Entity<RecipeIngredient>()
            .HasOne(ri => ri.Ingredient)
            .WithMany()
            .HasForeignKey(ri => ri.IngredientId);

        modelBuilder.Entity<RecipeStep>()
            .HasKey(rs => rs.StepId);

        modelBuilder.Entity<RecipeStep>()
            .HasOne<Recipe>()
            .WithMany(r => r.RecipeSteps)
            .HasForeignKey(rs => rs.RecipeId);


        //Users
        modelBuilder.Entity<User>().HasData(new User[]

        {
        new User
        {
            UserId = 1,
            Username = "alwright33",
            FirstName = "Austin",
            LastName = "Wright",
            Email = "awright@code.com",
            PasswordHash = HashPassword("austin1"),
            AccountCreated = DateTime.Now.AddDays(-100)
        },
        new User
        {
            UserId = 2,
            Username = "BakerSue",
            FirstName = "Sue",
            LastName = "Smith",
            Email = "bakersue@example.com",
            PasswordHash = HashPassword("hashedpassword2"),
            AccountCreated = DateTime.Now.AddDays(-90)
        },
        new User
        {
            UserId = 3,
            Username = "GrillMaster",
            FirstName = "James",
            LastName = "Brown",
            Email = "grillmaster@example.com",
            PasswordHash = HashPassword("hashedpassword3"),
            AccountCreated = DateTime.Now.AddDays(-80)
        },
        new User
        {
            UserId = 4,
            Username = "VeggieQueen",
            FirstName = "Emily",
            LastName = "Clark",
            Email = "veggiequeen@example.com",
            PasswordHash = HashPassword("hashedpassword4"),
            AccountCreated = DateTime.Now.AddDays(-70)
        },
        new User
        {
            UserId = 5,
            Username = "QuickCook",
            FirstName = "Oliver",
            LastName = "Martinez",
            Email = "quickcook@example.com",
            PasswordHash = HashPassword("hashedpassword5"),
            AccountCreated = DateTime.Now.AddDays(-60)
        },
        new User
        {
            UserId = 6,
            Username = "DessertLover",
            FirstName = "Sophia",
            LastName = "Johnson",
            Email = "dessertlover@example.com",
            PasswordHash = HashPassword("hashedpassword6"),
            AccountCreated = DateTime.Now.AddDays(-50)
        },
        new User
        {
            UserId = 7,
            Username = "HomeChef",
            FirstName = "William",
            LastName = "Garcia",
            Email = "homechef@example.com",
            PasswordHash = HashPassword("hashedpassword7"),
            AccountCreated = DateTime.Now.AddDays(-40)
        },
        new User
        {
            UserId = 8,
            Username = "HealthyEats",
            FirstName = "Ava",
            LastName = "Hernandez",
            Email = "healthyeats@example.com",
            PasswordHash = HashPassword("hashedpassword8"),
            AccountCreated = DateTime.Now.AddDays(-30)
        },
        new User
        {
            UserId = 9,
            Username = "SpicyFan",
            FirstName = "Ethan",
            LastName = "Lopez",
            Email = "spicyfan@example.com",
            PasswordHash = HashPassword("hashedpassword9"),
            AccountCreated = DateTime.Now.AddDays(-20)
        },
        new User
        {
            UserId = 10,
            Username = "FoodExplorer",
            FirstName = "Isabella",
            LastName = "Gonzalez",
            Email = "foodexplorer@example.com",
            PasswordHash = HashPassword("hashedpassword1"),
            AccountCreated = DateTime.Now.AddDays(-10)
        }
        });



        //Ingredients
        modelBuilder.Entity<Ingredient>().HasData(
            new Ingredient { IngredientId = 1, Name = "Flour" },
            new Ingredient { IngredientId = 2, Name = "Sugar" },
            new Ingredient { IngredientId = 3, Name = "Brown Sugar" },
            new Ingredient { IngredientId = 4, Name = "Salt" },
            new Ingredient { IngredientId = 5, Name = "Baking Soda" },
            new Ingredient { IngredientId = 6, Name = "Baking Powder" },
            new Ingredient { IngredientId = 7, Name = "Yeast" },
            new Ingredient { IngredientId = 8, Name = "Cornstarch" },
            new Ingredient { IngredientId = 9, Name = "Olive Oil" },
            new Ingredient { IngredientId = 10, Name = "Vegetable Oil" },
            new Ingredient { IngredientId = 11, Name = "Milk" },
            new Ingredient { IngredientId = 12, Name = "Butter" },
            new Ingredient { IngredientId = 13, Name = "Heavy Cream" },
            new Ingredient { IngredientId = 14, Name = "Sour Cream" },
            new Ingredient { IngredientId = 15, Name = "Yogurt" },
            new Ingredient { IngredientId = 16, Name = "Cheddar Cheese" },
            new Ingredient { IngredientId = 17, Name = "Mozzarella Cheese" },
            new Ingredient { IngredientId = 18, Name = "Cream Cheese" },
            new Ingredient { IngredientId = 19, Name = "Parmesan Cheese" },
            new Ingredient { IngredientId = 20, Name = "Eggs" },
            new Ingredient { IngredientId = 21, Name = "Boneless, Skinless Chicken Breast" },
            new Ingredient { IngredientId = 22, Name = "Ground Beef" },
            new Ingredient { IngredientId = 23, Name = "Pork Chops" },
            new Ingredient { IngredientId = 24, Name = "Salmon" },
            new Ingredient { IngredientId = 25, Name = "Lobster" },
            new Ingredient { IngredientId = 26, Name = "Shrimp" },
            new Ingredient { IngredientId = 27, Name = "Bacon" },
            new Ingredient { IngredientId = 28, Name = "Turkey" },
            new Ingredient { IngredientId = 29, Name = "Sausage" },
            new Ingredient { IngredientId = 30, Name = "Lamb" },
            new Ingredient { IngredientId = 31, Name = "Onion" },
            new Ingredient { IngredientId = 32, Name = "Garlic" },
            new Ingredient { IngredientId = 33, Name = "Carrot" },
            new Ingredient { IngredientId = 34, Name = "Celery" },
            new Ingredient { IngredientId = 35, Name = "Tomato" },
            new Ingredient { IngredientId = 36, Name = "Red Bell Pepper" },
            new Ingredient { IngredientId = 37, Name = "Green Bell Pepper" },
            new Ingredient { IngredientId = 38, Name = "Spinach" },
            new Ingredient { IngredientId = 39, Name = "Broccoli" },
            new Ingredient { IngredientId = 40, Name = "Zucchini" },
            new Ingredient { IngredientId = 41, Name = "Cucumber" },
            new Ingredient { IngredientId = 42, Name = "Potato" },
            new Ingredient { IngredientId = 43, Name = "Sweet Potato" },
            new Ingredient { IngredientId = 44, Name = "Mushrooms" },
            new Ingredient { IngredientId = 45, Name = "Peas" },
            new Ingredient { IngredientId = 46, Name = "Corn" },
            new Ingredient { IngredientId = 47, Name = "Lettuce" },
            new Ingredient { IngredientId = 48, Name = "Cabbage" },
            new Ingredient { IngredientId = 49, Name = "Chili Pepper" },
            new Ingredient { IngredientId = 50, Name = "Lime" },
            new Ingredient { IngredientId = 51, Name = "Lemon" },
            new Ingredient { IngredientId = 52, Name = "Apple" },
            new Ingredient { IngredientId = 53, Name = "Banana" },
            new Ingredient { IngredientId = 54, Name = "Orange" },
            new Ingredient { IngredientId = 55, Name = "Strawberry" },
            new Ingredient { IngredientId = 56, Name = "Blueberry" },
            new Ingredient { IngredientId = 57, Name = "Grapes" },
            new Ingredient { IngredientId = 58, Name = "Pineapple" },
            new Ingredient { IngredientId = 59, Name = "Watermelon" },
            new Ingredient { IngredientId = 60, Name = "Mango" },
            new Ingredient { IngredientId = 61, Name = "Papaya" },
            new Ingredient { IngredientId = 62, Name = "Cinnamon" },
            new Ingredient { IngredientId = 63, Name = "Nutmeg" },
            new Ingredient { IngredientId = 64, Name = "Ginger" },
            new Ingredient { IngredientId = 65, Name = "Turmeric" },
            new Ingredient { IngredientId = 66, Name = "Cumin" },
            new Ingredient { IngredientId = 67, Name = "Paprika" },
            new Ingredient { IngredientId = 68, Name = "Coriander" },
            new Ingredient { IngredientId = 69, Name = "Black Pepper" },
            new Ingredient { IngredientId = 70, Name = "Red Pepper Flakes" },
            new Ingredient { IngredientId = 71, Name = "Vanilla Extract" },
            new Ingredient { IngredientId = 72, Name = "Honey" },
            new Ingredient { IngredientId = 73, Name = "Soy Sauce" },
            new Ingredient { IngredientId = 74, Name = "Vinegar" },
            new Ingredient { IngredientId = 75, Name = "Maple Syrup" },
            new Ingredient { IngredientId = 76, Name = "Pasta" },
            new Ingredient { IngredientId = 77, Name = "Tomato Sauce" },
            new Ingredient { IngredientId = 78, Name = "Bread" },
            new Ingredient { IngredientId = 79, Name = "Garlic Powder" },
            new Ingredient { IngredientId = 80, Name = "Fish Stock" },
            new Ingredient { IngredientId = 81, Name = "White Wine" },
            new Ingredient { IngredientId = 82, Name = "Tomato Paste" },
            new Ingredient { IngredientId = 83, Name = "Tortillas" },
            new Ingredient { IngredientId = 84, Name = "Rice" },
            new Ingredient { IngredientId = 85, Name = "Puff pastry" },
            new Ingredient { IngredientId = 86, Name = "Beef tenderloin" },
            new Ingredient { IngredientId = 87, Name = "Eggplant" }
        );

        //Recipes
        modelBuilder.Entity<Recipe>().HasData(
           new Recipe
           {
               RecipeId = 1,
               Name = "Simple Scrambled Eggs",
               Description = "Quick and easy scrambled eggs for breakfast.",
               CookTime = 5,
               PrepTime = 2,
               Difficulty = "Beginner",
               AuthorId = 1,
               CreatedDate = DateTime.Now
           },
           new Recipe
           {
               RecipeId = 2,
               Name = "Classic Grilled Cheese",
               Description = "A golden, cheesy sandwich.",
               CookTime = 10,
               PrepTime = 5,
               Difficulty = "Beginner",
               AuthorId = 2,
               CreatedDate = DateTime.Now
           },
           new Recipe
           {
               RecipeId = 3,
               Name = "Pasta with Tomato Sauce",
               Description = "A simple pasta dish with a rich tomato sauce.",
               CookTime = 20,
               PrepTime = 10,
               Difficulty = "Beginner",
               AuthorId = 3,
               CreatedDate = DateTime.Now
           },
           new Recipe
           {
               RecipeId = 4,
               Name = "Oven-Baked Potatoes",
               Description = "Crispy potatoes baked to perfection.",
               CookTime = 30,
               PrepTime = 10,
               Difficulty = "Beginner",
               AuthorId = 4,
               CreatedDate = DateTime.Now
           },
           new Recipe
           {
               RecipeId = 5,
               Name = "Fruit Salad",
               Description = "A refreshing mix of seasonal fruits.",
               CookTime = 5,
               PrepTime = 10,
               Difficulty = "Beginner",
               AuthorId = 5,
               CreatedDate = DateTime.Now
           },
            new Recipe
            {
                RecipeId = 6,
                Name = "Chicken Stir-Fry",
                Description = "A flavorful stir-fry with tender chicken and crisp vegetables.",
                CookTime = 20,
                PrepTime = 15,
                Difficulty = "Intermediate",
                AuthorId = 6,
                CreatedDate = DateTime.Now
            },
            new Recipe
            {
                RecipeId = 7,
                Name = "Beef Stroganoff",
                Description = "A creamy and delicious beef stroganoff.",
                CookTime = 40,
                PrepTime = 20,
                Difficulty = "Intermediate",
                AuthorId = 7,
                CreatedDate = DateTime.Now
            },
            new Recipe
            {
                RecipeId = 8,
                Name = "Homemade Pizza",
                Description = "A customizable homemade pizza with your favorite toppings.",
                CookTime = 25,
                PrepTime = 20,
                Difficulty = "Intermediate",
                AuthorId = 8,
                CreatedDate = DateTime.Now
            },
            new Recipe
            {
                RecipeId = 9,
                Name = "Shrimp Tacos",
                Description = "Delicious shrimp tacos with a zesty lime crema.",
                CookTime = 15,
                PrepTime = 10,
                Difficulty = "Intermediate",
                AuthorId = 9,
                CreatedDate = DateTime.Now
            },
            new Recipe
            {
                RecipeId = 10,
                Name = "Stuffed Bell Peppers",
                Description = "Bell peppers stuffed with a savory mixture of rice, meat, and vegetables.",
                CookTime = 45,
                PrepTime = 25,
                Difficulty = "Intermediate",
                AuthorId = 10,
                CreatedDate = DateTime.Now
            },

            new Recipe
            {
                RecipeId = 11,
                Name = "Beef Wellington",
                Description = "A luxurious dish featuring beef tenderloin wrapped in puff pastry.",
                CookTime = 90,
                PrepTime = 60,
                Difficulty = "Advanced",
                AuthorId = 1,
                CreatedDate = DateTime.Now
            },
            new Recipe
            {
                RecipeId = 12,
                Name = "Ratatouille",
                Description = "A beautifully layered vegetable dish inspired by French cuisine.",
                CookTime = 60,
                PrepTime = 30,
                Difficulty = "Advanced",
                AuthorId = 2,
                CreatedDate = DateTime.Now
            },
            new Recipe
            {
                RecipeId = 13,
                Name = "Croissants",
                Description = "Flaky, buttery croissants made from scratch.",
                CookTime = 20,
                PrepTime = 240,
                Difficulty = "Advanced",
                AuthorId = 3,
                CreatedDate = DateTime.Now
            },
            new Recipe
            {
                RecipeId = 14,
                Name = "Duck à l'Orange",
                Description = "A classic French dish featuring duck with a sweet orange glaze.",
                CookTime = 120,
                PrepTime = 40,
                Difficulty = "Advanced",
                AuthorId = 4,
                CreatedDate = DateTime.Now
            },
            new Recipe
            {
                RecipeId = 15,
                Name = "Lobster Bisque",
                Description = "A rich and creamy lobster soup.",
                CookTime = 50,
                PrepTime = 30,
                Difficulty = "Advanced",
                AuthorId = 5,
                CreatedDate = DateTime.Now
            }
        );


        modelBuilder.Entity<RecipeIngredient>().HasData(

            // Beginner Recipe Ingredients

            new RecipeIngredient { RecipeId = 1, IngredientId = 20, Quantity = 2, Unit = "large", PrepDetails = "" }, // Eggs
            new RecipeIngredient { RecipeId = 1, IngredientId = 12, Quantity = 1, Unit = "tbsp", PrepDetails = "Melted" }, // Butter
            new RecipeIngredient { RecipeId = 1, IngredientId = 4, Quantity = 0.25m, Unit = "tsp", PrepDetails = "To taste" }, // Salt
            new RecipeIngredient { RecipeId = 1, IngredientId = 69, Quantity = 0.25m, Unit = "tsp", PrepDetails = "Freshly ground" }, // Black Pepper

            new RecipeIngredient { RecipeId = 2, IngredientId = 78, Quantity = 2, Unit = "slices", PrepDetails = "Plain" }, // Bread
            new RecipeIngredient { RecipeId = 2, IngredientId = 12, Quantity = 1, Unit = "tbsp", PrepDetails = "Softened" }, // Butter
            new RecipeIngredient { RecipeId = 2, IngredientId = 17, Quantity = 1, Unit = "slice", PrepDetails = "Thinly sliced" }, // Mozzarella Cheese
            new RecipeIngredient { RecipeId = 2, IngredientId = 16, Quantity = 1, Unit = "slice", PrepDetails = "Thinly sliced" }, // Cheddar Cheese

            new RecipeIngredient { RecipeId = 3, IngredientId = 76, Quantity = 200, Unit = "grams", PrepDetails = "Cooked al dente" }, // Pasta
            new RecipeIngredient { RecipeId = 3, IngredientId = 77, Quantity = 1, Unit = "cup", PrepDetails = "Heated" }, // Tomato Sauce
            new RecipeIngredient { RecipeId = 3, IngredientId = 12, Quantity = 1, Unit = "tbsp", PrepDetails = "Melted" }, // Butter
            new RecipeIngredient { RecipeId = 3, IngredientId = 32, Quantity = 2, Unit = "cloves", PrepDetails = "Minced" }, // Garlic
            new RecipeIngredient { RecipeId = 3, IngredientId = 69, Quantity = 0.5m, Unit = "tsp", PrepDetails = "Freshly ground" }, // Black Pepper
            new RecipeIngredient { RecipeId = 3, IngredientId = 4, Quantity = 0.5m, Unit = "tsp", PrepDetails = "To taste" }, // Salt,

            new RecipeIngredient { RecipeId = 4, IngredientId = 42, Quantity = 3, Unit = "pieces", PrepDetails = "Diced" }, // Potatoes
            new RecipeIngredient { RecipeId = 4, IngredientId = 9, Quantity = 2, Unit = "tbsp", PrepDetails = "Drizzled" }, // Olive Oil
            new RecipeIngredient { RecipeId = 4, IngredientId = 4, Quantity = 1, Unit = "tsp", PrepDetails = "Sprinkled" }, // Salt
            new RecipeIngredient { RecipeId = 4, IngredientId = 69, Quantity = 0.5m, Unit = "tsp", PrepDetails = "Freshly ground" }, // Black Pepper,

            new RecipeIngredient { RecipeId = 5, IngredientId = 55, Quantity = 1, Unit = "cup", PrepDetails = "Chopped" }, // Strawberries
            new RecipeIngredient { RecipeId = 5, IngredientId = 56, Quantity = 1, Unit = "cup", PrepDetails = "Washed" }, // Blueberries
            new RecipeIngredient { RecipeId = 5, IngredientId = 60, Quantity = 1, Unit = "cup", PrepDetails = "Chopped" }, // Mango
            new RecipeIngredient { RecipeId = 5, IngredientId = 50, Quantity = 1, Unit = "piece", PrepDetails = "Juiced" }, // Lime
            new RecipeIngredient { RecipeId = 5, IngredientId = 72, Quantity = 1, Unit = "tbsp", PrepDetails = "Drizzled" }, // Honey,

            // Intermediate Recipe Ingredients 

            new RecipeIngredient { RecipeId = 6, IngredientId = 21, Quantity = 300, Unit = "grams", PrepDetails = "Diced" }, // Boneless, Skinless Chicken Breast
            new RecipeIngredient { RecipeId = 6, IngredientId = 39, Quantity = 200, Unit = "grams", PrepDetails = "Chopped" }, // Broccoli
            new RecipeIngredient { RecipeId = 6, IngredientId = 36, Quantity = 1, Unit = "piece", PrepDetails = "Sliced" }, // Red Bell Pepper
            new RecipeIngredient { RecipeId = 6, IngredientId = 73, Quantity = 3, Unit = "tbsp", PrepDetails = "Mixed" }, // Soy Sauce
            new RecipeIngredient { RecipeId = 6, IngredientId = 9, Quantity = 2, Unit = "tbsp", PrepDetails = "Heated" }, // Olive Oil
            new RecipeIngredient { RecipeId = 6, IngredientId = 32, Quantity = 2, Unit = "cloves", PrepDetails = "Minced" }, // Garlic
            new RecipeIngredient { RecipeId = 6, IngredientId = 4, Quantity = 0.5m, Unit = "tsp", PrepDetails = "To taste" }, // Salt
            new RecipeIngredient { RecipeId = 6, IngredientId = 69, Quantity = 0.5m, Unit = "tsp", PrepDetails = "Freshly ground" }, // Black Pepper,

            new RecipeIngredient { RecipeId = 7, IngredientId = 22, Quantity = 500, Unit = "grams", PrepDetails = "Sliced" }, // Ground Beef
            new RecipeIngredient { RecipeId = 7, IngredientId = 31, Quantity = 1, Unit = "piece", PrepDetails = "Chopped" }, // Onion
            new RecipeIngredient { RecipeId = 7, IngredientId = 44, Quantity = 200, Unit = "grams", PrepDetails = "Sliced" }, // Mushrooms
            new RecipeIngredient { RecipeId = 7, IngredientId = 12, Quantity = 2, Unit = "tbsp", PrepDetails = "Melted" }, // Butter
            new RecipeIngredient { RecipeId = 7, IngredientId = 13, Quantity = 200, Unit = "ml", PrepDetails = "Whipped" }, // Heavy Cream
            new RecipeIngredient { RecipeId = 7, IngredientId = 73, Quantity = 2, Unit = "tbsp", PrepDetails = "Mixed" }, // Soy Sauce
            new RecipeIngredient { RecipeId = 7, IngredientId = 69, Quantity = 1, Unit = "tsp", PrepDetails = "Freshly ground" }, // Black Pepper
            new RecipeIngredient { RecipeId = 7, IngredientId = 4, Quantity = 0.5m, Unit = "tsp", PrepDetails = "To taste" }, // Salt,

            new RecipeIngredient { RecipeId = 8, IngredientId = 1, Quantity = 2, Unit = "cups", PrepDetails = "All-purpose flour, sifted" }, // Flour
            new RecipeIngredient { RecipeId = 8, IngredientId = 7, Quantity = 1, Unit = "tbsp", PrepDetails = "Activated in warm water" }, // Yeast
            new RecipeIngredient { RecipeId = 8, IngredientId = 12, Quantity = 2, Unit = "tbsp", PrepDetails = "Melted" }, // Butter
            new RecipeIngredient { RecipeId = 8, IngredientId = 11, Quantity = 0.75m, Unit = "cup", PrepDetails = "Warm" }, // Milk
            new RecipeIngredient { RecipeId = 8, IngredientId = 77, Quantity = 1, Unit = "cup", PrepDetails = "Spread on the base" }, // Tomato Sauce
            new RecipeIngredient { RecipeId = 8, IngredientId = 16, Quantity = 1, Unit = "cup", PrepDetails = "Shredded" }, // Cheddar Cheese
            new RecipeIngredient { RecipeId = 8, IngredientId = 17, Quantity = 1, Unit = "cup", PrepDetails = "Shredded" }, // Mozzarella Cheese
            new RecipeIngredient { RecipeId = 8, IngredientId = 31, Quantity = 1, Unit = "half", PrepDetails = "Sliced" }, // Onion
            new RecipeIngredient { RecipeId = 8, IngredientId = 37, Quantity = 1, Unit = "whole", PrepDetails = "Diced" }, // Green Bell Pepper
            new RecipeIngredient { RecipeId = 8, IngredientId = 44, Quantity = 0.5m, Unit = "cup", PrepDetails = "Sliced" }, // Mushrooms
            new RecipeIngredient { RecipeId = 8, IngredientId = 4, Quantity = 1, Unit = "tsp", PrepDetails = "To taste" }, // Salt
            new RecipeIngredient { RecipeId = 8, IngredientId = 69, Quantity = 0.5m, Unit = "tsp", PrepDetails = "Freshly ground" }, // Black Pepper

            new RecipeIngredient { RecipeId = 9, IngredientId = 26, Quantity = 300, Unit = "grams", PrepDetails = "Peeled and deveined" }, // Shrimp
            new RecipeIngredient { RecipeId = 9, IngredientId = 50, Quantity = 1, Unit = "whole", PrepDetails = "Juiced" }, // Lime
            new RecipeIngredient { RecipeId = 9, IngredientId = 9, Quantity = 2, Unit = "tbsp", PrepDetails = "For cooking" }, // Olive Oil
            new RecipeIngredient { RecipeId = 9, IngredientId = 4, Quantity = 0.5m, Unit = "tsp", PrepDetails = "To taste" }, // Salt
            new RecipeIngredient { RecipeId = 9, IngredientId = 69, Quantity = 0.5m, Unit = "tsp", PrepDetails = "Freshly ground" }, // Black Pepper
            new RecipeIngredient { RecipeId = 9, IngredientId = 36, Quantity = 1, Unit = "whole", PrepDetails = "Sliced" }, // Red Bell Pepper
            new RecipeIngredient { RecipeId = 9, IngredientId = 47, Quantity = 1, Unit = "cup", PrepDetails = "Shredded" }, // Lettuce
            new RecipeIngredient { RecipeId = 9, IngredientId = 83, Quantity = 4, Unit = "whole", PrepDetails = "Small tortillas" }, // Tortillas
            new RecipeIngredient { RecipeId = 9, IngredientId = 13, Quantity = 0.5m, Unit = "cup", PrepDetails = "Whipped" }, // Sour Cream

            new RecipeIngredient { RecipeId = 10, IngredientId = 36, Quantity = 4, Unit = "whole", PrepDetails = "Tops removed, seeds and membranes cleared" }, // Red Bell Peppers
            new RecipeIngredient { RecipeId = 10, IngredientId = 22, Quantity = 300, Unit = "grams", PrepDetails = "Cooked and crumbled" }, // Ground Beef
            new RecipeIngredient { RecipeId = 10, IngredientId = 84, Quantity = 1, Unit = "cup", PrepDetails = "Cooked" }, // Rice
            new RecipeIngredient { RecipeId = 10, IngredientId = 31, Quantity = 1, Unit = "half", PrepDetails = "Chopped" }, // Onion
            new RecipeIngredient { RecipeId = 10, IngredientId = 77, Quantity = 1, Unit = "cup", PrepDetails = "Heated" }, // Tomato Sauce
            new RecipeIngredient { RecipeId = 10, IngredientId = 12, Quantity = 2, Unit = "tbsp", PrepDetails = "Melted" }, // Butter
            new RecipeIngredient { RecipeId = 10, IngredientId = 69, Quantity = 0.5m, Unit = "tsp", PrepDetails = "Freshly ground" }, // Black Pepper
            new RecipeIngredient { RecipeId = 10, IngredientId = 4, Quantity = 0.5m, Unit = "tsp", PrepDetails = "To taste" }, // Salt
            new RecipeIngredient { RecipeId = 10, IngredientId = 16, Quantity = 0.5m, Unit = "cup", PrepDetails = "Shredded" }, // Cheddar Cheese

            // Advanced Recipe Ingredients

            new RecipeIngredient { RecipeId = 11, IngredientId = 86, Quantity = 1, Unit = "kg", PrepDetails = "Trimmed" }, // Beef Tenderloin
            new RecipeIngredient { RecipeId = 11, IngredientId = 12, Quantity = 100, Unit = "grams", PrepDetails = "Softened" }, // Butter
            new RecipeIngredient { RecipeId = 11, IngredientId = 44, Quantity = 200, Unit = "grams", PrepDetails = "Finely chopped" }, // Mushrooms
            new RecipeIngredient { RecipeId = 11, IngredientId = 78, Quantity = 1, Unit = "sheet", PrepDetails = "Thawed" }, // Puff Pastry
            new RecipeIngredient { RecipeId = 11, IngredientId = 20, Quantity = 1, Unit = "large", PrepDetails = "Beaten" }, // Egg
            new RecipeIngredient { RecipeId = 11, IngredientId = 73, Quantity = 1, Unit = "tbsp", PrepDetails = "Brushed" }, // Olive Oil
            new RecipeIngredient { RecipeId = 11, IngredientId = 4, Quantity = 1, Unit = "tsp", PrepDetails = "To taste" }, // Salt
            new RecipeIngredient { RecipeId = 11, IngredientId = 69, Quantity = 0.5m, Unit = "tsp", PrepDetails = "Freshly ground" }, // Black Pepper,

            new RecipeIngredient { RecipeId = 12, IngredientId = 35, Quantity = 2, Unit = "pieces", PrepDetails = "Sliced" }, // Tomato
            new RecipeIngredient { RecipeId = 12, IngredientId = 40, Quantity = 1, Unit = "whole", PrepDetails = "Sliced" }, // Zucchini
            new RecipeIngredient { RecipeId = 12, IngredientId = 87, Quantity = 1, Unit = "whole", PrepDetails = "Sliced" }, // Eggplant
            new RecipeIngredient { RecipeId = 12, IngredientId = 9, Quantity = 2, Unit = "tbsp", PrepDetails = "For drizzling" }, // Olive Oil
            new RecipeIngredient { RecipeId = 12, IngredientId = 73, Quantity = 1, Unit = "cup", PrepDetails = "Base layer" }, // Tomato Sauce
            new RecipeIngredient { RecipeId = 12, IngredientId = 4, Quantity = 1, Unit = "tsp", PrepDetails = "To taste" }, // Salt
            new RecipeIngredient { RecipeId = 12, IngredientId = 69, Quantity = 0.5m, Unit = "tsp", PrepDetails = "Freshly ground" }, // Black Pepper,

            new RecipeIngredient { RecipeId = 13, IngredientId = 1, Quantity = 4, Unit = "cups", PrepDetails = "All-purpose flour, sifted" }, // Flour
            new RecipeIngredient { RecipeId = 13, IngredientId = 7, Quantity = 2, Unit = "tsp", PrepDetails = "Activated in warm water" }, // Yeast
            new RecipeIngredient { RecipeId = 13, IngredientId = 12, Quantity = 300, Unit = "grams", PrepDetails = "Chilled and cubed" }, // Butter
            new RecipeIngredient { RecipeId = 13, IngredientId = 20, Quantity = 1, Unit = "piece", PrepDetails = "Beaten" }, // Egg
            new RecipeIngredient { RecipeId = 13, IngredientId = 4, Quantity = 1, Unit = "tsp", PrepDetails = "To taste" }, // Salt
            new RecipeIngredient { RecipeId = 13, IngredientId = 11, Quantity = 1.25m, Unit = "cups", PrepDetails = "Warm" }, // Milk

            new RecipeIngredient { RecipeId = 14, IngredientId = 28, Quantity = 1, Unit = "piece", PrepDetails = "Whole duck, cleaned" }, // Duck
            new RecipeIngredient { RecipeId = 14, IngredientId = 54, Quantity = 2, Unit = "pieces", PrepDetails = "Juiced and zested" }, // Oranges
            new RecipeIngredient { RecipeId = 14, IngredientId = 2, Quantity = 3, Unit = "tbsp", PrepDetails = "For caramelization" }, // Sugar
            new RecipeIngredient { RecipeId = 14, IngredientId = 74, Quantity = 0.25m, Unit = "cup", PrepDetails = "White vinegar" }, // Vinegar
            new RecipeIngredient { RecipeId = 14, IngredientId = 73, Quantity = 2, Unit = "tbsp", PrepDetails = "For glaze" }, // Soy Sauce
            new RecipeIngredient { RecipeId = 14, IngredientId = 4, Quantity = 1, Unit = "tsp", PrepDetails = "To taste" }, // Salt
            new RecipeIngredient { RecipeId = 14, IngredientId = 69, Quantity = 0.5m, Unit = "tsp", PrepDetails = "Freshly ground" }, // Black Pepper

            new RecipeIngredient { RecipeId = 15, IngredientId = 25, Quantity = 2, Unit = "pieces", PrepDetails = "Cooked and shelled" }, // Lobster
            new RecipeIngredient { RecipeId = 15, IngredientId = 31, Quantity = 1, Unit = "half", PrepDetails = "Chopped" }, // Onion
            new RecipeIngredient { RecipeId = 15, IngredientId = 33, Quantity = 1, Unit = "whole", PrepDetails = "Chopped" }, // Carrot
            new RecipeIngredient { RecipeId = 15, IngredientId = 34, Quantity = 1, Unit = "whole", PrepDetails = "Chopped" }, // Celery
            new RecipeIngredient { RecipeId = 15, IngredientId = 13, Quantity = 1, Unit = "cup", PrepDetails = "Whipped" }, // Heavy Cream
            new RecipeIngredient { RecipeId = 15, IngredientId = 80, Quantity = 1, Unit = "cup", PrepDetails = "Used as fish stock" }, // Fish Stock
            new RecipeIngredient { RecipeId = 15, IngredientId = 81, Quantity = 0.5m, Unit = "cup", PrepDetails = "Dry" }, // White Wine
            new RecipeIngredient { RecipeId = 15, IngredientId = 82, Quantity = 2, Unit = "tbsp", PrepDetails = "Mixed into broth" }, // Tomato Paste
            new RecipeIngredient { RecipeId = 15, IngredientId = 12, Quantity = 3, Unit = "tbsp", PrepDetails = "Melted" }, // Butter
            new RecipeIngredient { RecipeId = 15, IngredientId = 69, Quantity = 1, Unit = "tsp", PrepDetails = "Freshly ground" }, // Black Pepper
            new RecipeIngredient { RecipeId = 15, IngredientId = 4, Quantity = 1, Unit = "tsp", PrepDetails = "To taste" } // Salt


        );


        modelBuilder.Entity<RecipeStep>().HasData(


            // Beginner RecipeSteps

            new RecipeStep { StepId = 1, RecipeId = 1, StepNumber = 1, StepInstruction = "Crack the eggs into a bowl and whisk until the yolks and whites are fully combined." },
            new RecipeStep { StepId = 2, RecipeId = 1, StepNumber = 2, StepInstruction = "Heat butter in a non-stick pan over medium heat until melted." },
            new RecipeStep { StepId = 3, RecipeId = 1, StepNumber = 3, StepInstruction = "Pour the whisked eggs into the pan and let them cook for a few seconds." },
            new RecipeStep { StepId = 4, RecipeId = 1, StepNumber = 4, StepInstruction = "Use a spatula to gently stir the eggs, bringing the cooked edges toward the center." },
            new RecipeStep { StepId = 5, RecipeId = 1, StepNumber = 5, StepInstruction = "Continue stirring until the eggs are just set but still soft and slightly runny." },
            new RecipeStep { StepId = 6, RecipeId = 1, StepNumber = 6, StepInstruction = "Season with salt and pepper to taste, then serve immediately." },

            new RecipeStep { StepId = 7, RecipeId = 2, StepNumber = 1, StepInstruction = "Spread softened butter on one side of each bread slice." },
            new RecipeStep { StepId = 8, RecipeId = 2, StepNumber = 2, StepInstruction = "Place a slice of mozzarella cheese between the unbuttered sides of the bread slices to form a sandwich." },
            new RecipeStep { StepId = 9, RecipeId = 2, StepNumber = 3, StepInstruction = "Heat a non-stick skillet over medium heat." },
            new RecipeStep { StepId = 10, RecipeId = 2, StepNumber = 4, StepInstruction = "Place the sandwich in the skillet, buttered side down." },
            new RecipeStep { StepId = 11, RecipeId = 2, StepNumber = 5, StepInstruction = "Cook for 3-4 minutes until the bread is golden and crispy." },
            new RecipeStep { StepId = 12, RecipeId = 2, StepNumber = 6, StepInstruction = "Flip the sandwich carefully and cook the other side for an additional 3-4 minutes until golden and the cheese is melted." },
            new RecipeStep { StepId = 13, RecipeId = 2, StepNumber = 7, StepInstruction = "Remove from the skillet, let cool slightly, slice, and serve warm." },


            new RecipeStep { StepId = 14, RecipeId = 3, StepNumber = 1, StepInstruction = "Bring a pot of salted water to a boil and cook pasta according to package instructions until al dente. Drain and set aside." },
            new RecipeStep { StepId = 15, RecipeId = 3, StepNumber = 2, StepInstruction = "In a large skillet, melt butter over medium heat and sauté minced garlic until fragrant, about 1-2 minutes." },
            new RecipeStep { StepId = 16, RecipeId = 3, StepNumber = 3, StepInstruction = "Add the tomato sauce to the skillet and stir well. Simmer for 5 minutes to allow the flavors to meld." },
            new RecipeStep { StepId = 17, RecipeId = 3, StepNumber = 4, StepInstruction = "Season the sauce with salt and freshly ground black pepper to taste." },
            new RecipeStep { StepId = 18, RecipeId = 3, StepNumber = 5, StepInstruction = "Toss the cooked pasta into the sauce and mix until well coated." },
            new RecipeStep { StepId = 19, RecipeId = 3, StepNumber = 6, StepInstruction = "Serve warm, garnished with grated Parmesan cheese if desired." },

            new RecipeStep { StepId = 20, RecipeId = 4, StepNumber = 1, StepInstruction = "Preheat your oven to 200°C (400°F)." },
            new RecipeStep { StepId = 21, RecipeId = 4, StepNumber = 2, StepInstruction = "Wash and dice the potatoes into evenly sized pieces." },
            new RecipeStep { StepId = 22, RecipeId = 4, StepNumber = 3, StepInstruction = "Place the diced potatoes in a bowl and drizzle with olive oil." },
            new RecipeStep { StepId = 23, RecipeId = 4, StepNumber = 4, StepInstruction = "Season with salt and freshly ground black pepper. Toss to coat evenly." },
            new RecipeStep { StepId = 24, RecipeId = 4, StepNumber = 5, StepInstruction = "Spread the potatoes in a single layer on a baking sheet." },
            new RecipeStep { StepId = 25, RecipeId = 4, StepNumber = 6, StepInstruction = "Bake in the preheated oven for 25-30 minutes, turning halfway through, until golden and crispy." },
            new RecipeStep { StepId = 26, RecipeId = 4, StepNumber = 7, StepInstruction = "Remove from the oven and serve hot as a side dish or snack." },

            new RecipeStep { StepId = 27, RecipeId = 5, StepNumber = 1, StepInstruction = "Wash and prepare all the fruits by chopping them into bite-sized pieces." },
            new RecipeStep { StepId = 28, RecipeId = 5, StepNumber = 2, StepInstruction = "Place the chopped strawberries, blueberries, and mango in a large mixing bowl." },
            new RecipeStep { StepId = 29, RecipeId = 5, StepNumber = 3, StepInstruction = "Squeeze fresh lime juice over the fruits." },
            new RecipeStep { StepId = 30, RecipeId = 5, StepNumber = 4, StepInstruction = "Drizzle honey over the fruit mixture for added sweetness." },
            new RecipeStep { StepId = 31, RecipeId = 5, StepNumber = 5, StepInstruction = "Gently toss all the ingredients together until well combined." },
            new RecipeStep { StepId = 32, RecipeId = 5, StepNumber = 6, StepInstruction = "Serve immediately or chill in the refrigerator for 10 minutes before serving." },

            // Intermediate RecipesSteps

            new RecipeStep { StepId = 33, RecipeId = 6, StepNumber = 1, StepInstruction = "Heat olive oil in a large skillet or wok over medium-high heat." },
            new RecipeStep { StepId = 34, RecipeId = 6, StepNumber = 2, StepInstruction = "Add diced chicken breast to the skillet and cook until browned and fully cooked, about 5-7 minutes." },
            new RecipeStep { StepId = 35, RecipeId = 6, StepNumber = 3, StepInstruction = "Remove the chicken from the skillet and set aside." },
            new RecipeStep { StepId = 36, RecipeId = 6, StepNumber = 4, StepInstruction = "In the same skillet, add minced garlic and sauté for 1 minute until fragrant." },
            new RecipeStep { StepId = 37, RecipeId = 6, StepNumber = 5, StepInstruction = "Add broccoli and red bell pepper to the skillet. Stir-fry for 3-4 minutes until vegetables are tender but crisp." },
            new RecipeStep { StepId = 38, RecipeId = 6, StepNumber = 6, StepInstruction = "Return the cooked chicken to the skillet and pour in the soy sauce. Stir well to coat everything evenly." },
            new RecipeStep { StepId = 39, RecipeId = 6, StepNumber = 7, StepInstruction = "Season with salt and freshly ground black pepper to taste." },
            new RecipeStep { StepId = 40, RecipeId = 6, StepNumber = 8, StepInstruction = "Serve hot over steamed rice or noodles, if desired." },

            new RecipeStep { StepId = 41, RecipeId = 7, StepNumber = 1, StepInstruction = "Melt butter in a large skillet over medium-high heat." },
            new RecipeStep { StepId = 42, RecipeId = 7, StepNumber = 2, StepInstruction = "Add the sliced beef to the skillet and cook until browned. Remove and set aside." },
            new RecipeStep { StepId = 43, RecipeId = 7, StepNumber = 3, StepInstruction = "In the same skillet, sauté chopped onions until translucent, about 3-5 minutes." },
            new RecipeStep { StepId = 44, RecipeId = 7, StepNumber = 4, StepInstruction = "Add sliced mushrooms to the skillet and cook for another 5 minutes until softened." },
            new RecipeStep { StepId = 45, RecipeId = 7, StepNumber = 5, StepInstruction = "Return the cooked beef to the skillet and stir to combine with the onions and mushrooms." },
            new RecipeStep { StepId = 46, RecipeId = 7, StepNumber = 6, StepInstruction = "Pour in the heavy cream and soy sauce. Stir well and bring to a gentle simmer." },
            new RecipeStep { StepId = 47, RecipeId = 7, StepNumber = 7, StepInstruction = "Season with salt and freshly ground black pepper to taste." },
            new RecipeStep { StepId = 48, RecipeId = 7, StepNumber = 8, StepInstruction = "Simmer for 10-15 minutes, stirring occasionally, until the sauce thickens." },
            new RecipeStep { StepId = 49, RecipeId = 7, StepNumber = 9, StepInstruction = "Serve hot over egg noodles or rice, garnished with fresh parsley if desired." },

            new RecipeStep { StepId = 50, RecipeId = 8, StepNumber = 1, StepInstruction = "In a large bowl, combine warm milk, yeast, and a pinch of sugar. Let it sit for 5 minutes until frothy." },
            new RecipeStep { StepId = 51, RecipeId = 8, StepNumber = 2, StepInstruction = "Add sifted flour, melted butter, and salt to the yeast mixture. Mix until a dough forms." },
            new RecipeStep { StepId = 52, RecipeId = 8, StepNumber = 3, StepInstruction = "Knead the dough on a floured surface for 8-10 minutes until smooth and elastic." },
            new RecipeStep { StepId = 53, RecipeId = 8, StepNumber = 4, StepInstruction = "Place the dough in a lightly oiled bowl, cover with a clean towel, and let it rise in a warm place for 1 hour or until doubled in size." },
            new RecipeStep { StepId = 54, RecipeId = 8, StepNumber = 5, StepInstruction = "Preheat the oven to 220°C (425°F) and prepare a baking sheet or pizza stone." },
            new RecipeStep { StepId = 55, RecipeId = 8, StepNumber = 6, StepInstruction = "Punch down the dough and roll it out to your desired pizza size and thickness." },
            new RecipeStep { StepId = 56, RecipeId = 8, StepNumber = 7, StepInstruction = "Spread tomato sauce evenly over the pizza base, leaving a small border around the edges." },
            new RecipeStep { StepId = 57, RecipeId = 8, StepNumber = 8, StepInstruction = "Sprinkle shredded cheddar and mozzarella cheese over the sauce." },
            new RecipeStep { StepId = 58, RecipeId = 8, StepNumber = 9, StepInstruction = "Add toppings such as sliced onions, diced green bell pepper, and mushrooms." },
            new RecipeStep { StepId = 59, RecipeId = 8, StepNumber = 10, StepInstruction = "Bake in the preheated oven for 20-25 minutes or until the crust is golden and the cheese is bubbly." },
            new RecipeStep { StepId = 60, RecipeId = 8, StepNumber = 11, StepInstruction = "Remove from the oven, let it cool for a few minutes, slice, and serve hot." },

            new RecipeStep { StepId = 61, RecipeId = 9, StepNumber = 1, StepInstruction = "In a bowl, toss the shrimp with lime juice, salt, and pepper. Let it marinate for 5 minutes." },
            new RecipeStep { StepId = 62, RecipeId = 9, StepNumber = 2, StepInstruction = "Heat olive oil in a skillet over medium-high heat." },
            new RecipeStep { StepId = 63, RecipeId = 9, StepNumber = 3, StepInstruction = "Add the shrimp to the skillet and cook for 2-3 minutes per side until pink and fully cooked. Remove from heat." },
            new RecipeStep { StepId = 64, RecipeId = 9, StepNumber = 4, StepInstruction = "In a small bowl, mix sour cream with a squeeze of lime juice to create the lime crema." },
            new RecipeStep { StepId = 65, RecipeId = 9, StepNumber = 5, StepInstruction = "Warm the tortillas in a dry skillet or microwave." },
            new RecipeStep { StepId = 66, RecipeId = 9, StepNumber = 6, StepInstruction = "Assemble the tacos by layering shredded lettuce, cooked shrimp, and sliced red bell peppers onto the tortillas." },
            new RecipeStep { StepId = 67, RecipeId = 9, StepNumber = 7, StepInstruction = "Drizzle with lime crema and serve immediately." },

            new RecipeStep { StepId = 68, RecipeId = 10, StepNumber = 1, StepInstruction = "Preheat the oven to 190°C (375°F)." },
            new RecipeStep { StepId = 69, RecipeId = 10, StepNumber = 2, StepInstruction = "Prepare the bell peppers by cutting off the tops and removing seeds and membranes." },
            new RecipeStep { StepId = 70, RecipeId = 10, StepNumber = 3, StepInstruction = "In a skillet, melt butter over medium heat and sauté the chopped onion until translucent." },
            new RecipeStep { StepId = 71, RecipeId = 10, StepNumber = 4, StepInstruction = "Add the ground beef to the skillet and cook until browned. Drain excess fat if necessary." },
            new RecipeStep { StepId = 72, RecipeId = 10, StepNumber = 5, StepInstruction = "Stir in the cooked rice, tomato sauce, salt, and pepper. Mix until well combined." },
            new RecipeStep { StepId = 73, RecipeId = 10, StepNumber = 6, StepInstruction = "Stuff the bell peppers with the beef and rice mixture, pressing it down gently." },
            new RecipeStep { StepId = 74, RecipeId = 10, StepNumber = 7, StepInstruction = "Place the stuffed peppers upright in a baking dish and cover with foil." },
            new RecipeStep { StepId = 75, RecipeId = 10, StepNumber = 8, StepInstruction = "Bake in the preheated oven for 30 minutes." },
            new RecipeStep { StepId = 76, RecipeId = 10, StepNumber = 9, StepInstruction = "Remove the foil, sprinkle shredded cheddar cheese on top, and bake for an additional 10-15 minutes until the cheese is melted and bubbly." },
            new RecipeStep { StepId = 77, RecipeId = 10, StepNumber = 10, StepInstruction = "Serve warm, garnished with fresh parsley if desired." },

            // Advanced RecipesSteps

            new RecipeStep { StepId = 78, RecipeId = 11, StepNumber = 1, StepInstruction = "Season the beef tenderloin with salt and pepper, then sear it in olive oil over high heat until browned on all sides." },
            new RecipeStep { StepId = 79, RecipeId = 11, StepNumber = 2, StepInstruction = "Allow the beef to cool, then spread softened butter over its surface." },
            new RecipeStep { StepId = 80, RecipeId = 11, StepNumber = 3, StepInstruction = "Cook the finely chopped mushrooms in a dry skillet until moisture evaporates, then cool." },
            new RecipeStep { StepId = 81, RecipeId = 11, StepNumber = 4, StepInstruction = "Spread the mushrooms over the beef and wrap it in plastic wrap tightly. Chill for 20 minutes." },
            new RecipeStep { StepId = 82, RecipeId = 11, StepNumber = 5, StepInstruction = "Roll out the puff pastry and wrap it around the beef, sealing the edges." },
            new RecipeStep { StepId = 83, RecipeId = 11, StepNumber = 6, StepInstruction = "Brush the pastry with beaten egg and make a few slits for ventilation." },
            new RecipeStep { StepId = 84, RecipeId = 11, StepNumber = 7, StepInstruction = "Bake in a preheated oven at 200°C (400°F) for 40 minutes or until the pastry is golden brown." },
            new RecipeStep { StepId = 85, RecipeId = 11, StepNumber = 8, StepInstruction = "Rest for 10 minutes before slicing and serving." },

            new RecipeStep { StepId = 86, RecipeId = 12, StepNumber = 1, StepInstruction = "Preheat the oven to 190°C (375°F)." },
            new RecipeStep { StepId = 87, RecipeId = 12, StepNumber = 2, StepInstruction = "Spread tomato sauce evenly over the bottom of a baking dish." },
            new RecipeStep { StepId = 88, RecipeId = 12, StepNumber = 3, StepInstruction = "Layer sliced tomatoes, zucchini, and eggplant alternately in the dish, slightly overlapping each piece." },
            new RecipeStep { StepId = 89, RecipeId = 12, StepNumber = 4, StepInstruction = "Drizzle olive oil over the layered vegetables and season with salt and pepper." },
            new RecipeStep { StepId = 90, RecipeId = 12, StepNumber = 5, StepInstruction = "Cover the dish with foil and bake for 40 minutes." },
            new RecipeStep { StepId = 91, RecipeId = 12, StepNumber = 6, StepInstruction = "Remove the foil and bake for an additional 10-15 minutes until the vegetables are tender and slightly browned." },
            new RecipeStep { StepId = 92, RecipeId = 12, StepNumber = 7, StepInstruction = "Serve warm as a side dish or main course." },

            new RecipeStep { StepId = 93, RecipeId = 13, StepNumber = 1, StepInstruction = "In a bowl, dissolve yeast in warm milk and let it sit for 5 minutes until frothy." },
            new RecipeStep { StepId = 94, RecipeId = 13, StepNumber = 2, StepInstruction = "Add flour, salt, and a small amount of butter. Knead into a smooth dough." },
            new RecipeStep { StepId = 95, RecipeId = 13, StepNumber = 3, StepInstruction = "Roll out the dough into a rectangle and chill in the refrigerator for 30 minutes." },
            new RecipeStep { StepId = 96, RecipeId = 13, StepNumber = 4, StepInstruction = "Layer chilled butter over the dough and fold it in thirds. Roll out and repeat 3 times." },
            new RecipeStep { StepId = 97, RecipeId = 13, StepNumber = 5, StepInstruction = "Chill the dough for another 30 minutes, then roll out and cut into triangles." },
            new RecipeStep { StepId = 98, RecipeId = 13, StepNumber = 6, StepInstruction = "Roll each triangle tightly into a crescent shape and place on a baking sheet." },
            new RecipeStep { StepId = 99, RecipeId = 13, StepNumber = 7, StepInstruction = "Let the croissants rise in a warm place for 1 hour until doubled in size." },
            new RecipeStep { StepId = 100, RecipeId = 13, StepNumber = 8, StepInstruction = "Brush with beaten egg and bake in a preheated oven at 200°C (400°F) for 20 minutes until golden brown." },
            new RecipeStep { StepId = 101, RecipeId = 13, StepNumber = 9, StepInstruction = "Cool slightly before serving warm." },

            new RecipeStep { StepId = 102, RecipeId = 14, StepNumber = 1, StepInstruction = "Preheat the oven to 180°C (350°F)." },
            new RecipeStep { StepId = 103, RecipeId = 14, StepNumber = 2, StepInstruction = "Season the duck with salt and pepper inside and out." },
            new RecipeStep { StepId = 104, RecipeId = 14, StepNumber = 3, StepInstruction = "Place the duck in a roasting pan and roast for 1 hour and 30 minutes, basting occasionally." },
            new RecipeStep { StepId = 105, RecipeId = 14, StepNumber = 4, StepInstruction = "In a saucepan, combine orange juice, orange zest, sugar, and vinegar. Simmer until reduced to a syrupy consistency." },
            new RecipeStep { StepId = 106, RecipeId = 14, StepNumber = 5, StepInstruction = "Add soy sauce to the glaze and mix well. Set aside." },
            new RecipeStep { StepId = 107, RecipeId = 14, StepNumber = 6, StepInstruction = "Brush the glaze over the duck during the last 20 minutes of roasting." },
            new RecipeStep { StepId = 108, RecipeId = 14, StepNumber = 7, StepInstruction = "Remove the duck from the oven and let it rest for 10 minutes before carving." },
            new RecipeStep { StepId = 109, RecipeId = 14, StepNumber = 8, StepInstruction = "Serve warm with additional orange glaze on the side." },

            new RecipeStep { StepId = 110, RecipeId = 15, StepNumber = 2, StepInstruction = "Remove the lobster from the pot, let it cool, and then extract the meat from the shells." },
            new RecipeStep { StepId = 111, RecipeId = 15, StepNumber = 3, StepInstruction = "Reserve the shells and chop the lobster meat into bite-sized pieces." },
            new RecipeStep { StepId = 112, RecipeId = 15, StepNumber = 4, StepInstruction = "In a large pot, heat butter over medium heat and sauté onions, celery, and carrots until soft." },
            new RecipeStep { StepId = 113, RecipeId = 15, StepNumber = 5, StepInstruction = "Add the reserved lobster shells and cook for 5 minutes to release their flavor." },
            new RecipeStep { StepId = 114, RecipeId = 15, StepNumber = 6, StepInstruction = "Pour in the fish stock, white wine, and tomato paste. Simmer for 20 minutes." },
            new RecipeStep { StepId = 115, RecipeId = 15, StepNumber = 7, StepInstruction = "Strain the mixture through a fine mesh sieve, discarding the solids, and return the liquid to the pot." },
            new RecipeStep { StepId = 116, RecipeId = 15, StepNumber = 8, StepInstruction = "Stir in heavy cream and simmer gently for another 10 minutes, seasoning with salt and pepper to taste." },
            new RecipeStep { StepId = 117, RecipeId = 15, StepNumber = 9, StepInstruction = "Add the chopped lobster meat back into the pot and heat through without boiling." },
            new RecipeStep { StepId = 118, RecipeId = 15, StepNumber = 10, StepInstruction = "Serve the lobster bisque hot, garnished with fresh parsley or chives if desired." }

);

    }
    private static string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));
    }
}

