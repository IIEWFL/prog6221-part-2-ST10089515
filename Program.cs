/**using System;

namespace RecipeApp
{
    class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }

    class RecipeStep
    {
        public string Description { get; set; }
    }

    class Recipe
    {
        public Ingredient[] Ingredients { get; set; }
        public RecipeStep[] Steps { get; set; }

        public Recipe(int ingredientCount, int stepCount)
        {
            Ingredients = new Ingredient[ingredientCount];
            Steps = new RecipeStep[stepCount];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = null;

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset quantities");
                Console.WriteLine("5. Clear all data");
                Console.WriteLine("6. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        recipe = EnterRecipeDetails();
                        break;
                    case "2":
                        DisplayRecipe(recipe);
                        break;
                    case "3":
                        ScaleRecipe(recipe);
                        break;
                    case "4":
                        ResetQuantities(recipe);
                        break;
                    case "5":
                        recipe = null;
                        Console.WriteLine("All data cleared.");
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static Recipe EnterRecipeDetails()
        {
            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            Recipe recipe = new Recipe(ingredientCount, stepCount);

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Ingredient #{i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit of Measurement: ");
                string unit = Console.ReadLine();

                recipe.Ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
            }

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Step #{i + 1}:");
                Console.Write("Description: ");
                string description = Console.ReadLine();

                recipe.Steps[i] = new RecipeStep { Description = description };
            }

            Console.WriteLine("Recipe details entered.");
            return recipe;
        }

        static void DisplayRecipe(Recipe recipe)
        {
            if (recipe == null)
            {
                Console.WriteLine("No recipe details available.");
                return;
            }

            Console.WriteLine("Recipe Details:");
            Console.WriteLine("Ingredients:");
            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("Steps:");
            foreach (RecipeStep step in recipe.Steps)
            {
                Console.WriteLine(step.Description);
            }
        }

        static void ScaleRecipe(Recipe recipe)
        {
            if (recipe == null)
            {
                Console.WriteLine("No recipe details available.");
                return;
            }

            Console.Write("Enter the scaling factor (0.5, 2, or 3): ");
            double factor = double.Parse(Console.ReadLine());

            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                ingredient.Quantity *= factor;
            }

            Console.WriteLine("Recipe scaled.");
        }

        static void ResetQuantities(Recipe recipe)
        {
            if (recipe == null)
            {
                Console.WriteLine("No recipe details available.");
                return;
            }

            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                ingredient.Quantity = GetOriginalQuantity(ingredient.Name);
            }

            Console.WriteLine("Quantities reset.");
        }

        static double GetOriginalQuantity(string ingredientName)
        {
            // Your logic to retrieve the original quantity based on the ingredient name
            // ...
            return 0; // Default value if original quantity is not found
        }
    }
}
**/

/**using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeApp
{
    class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }
    }

    class RecipeStep
    {
        public string Description { get; set; }
    }

    class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<RecipeStep> Steps { get; set; }

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
            Steps = new List<RecipeStep>();
        }

        public int GetTotalCalories()
        {
            return Ingredients.Sum(i => i.Calories);
        }
    }

    class Program
    {
        static List<Recipe> recipes = new List<Recipe>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe list");
                Console.WriteLine("3. Display recipe details");
                Console.WriteLine("4. Scale recipe");
                Console.WriteLine("5. Reset quantities");
                Console.WriteLine("6. Clear all data");
                Console.WriteLine("7. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        EnterRecipeDetails();
                        break;
                    case "2":
                        DisplayRecipeList();
                        break;
                    case "3":
                        DisplayRecipeDetails();
                        break;
                    case "4":
                        ScaleRecipe();
                        break;
                    case "5":
                        ResetQuantities();
                        break;
                    case "6":
                        ClearAllData();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void EnterRecipeDetails()
        {
            Console.Write("Enter the name of the recipe: ");
            string name = Console.ReadLine();

            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            Recipe recipe = new Recipe(name);

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Ingredient #{i + 1}:");
                Console.Write("Name: ");
                string ingredientName = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit of Measurement: ");
                string unit = Console.ReadLine();
                Console.Write("Calories: ");
                int calories = int.Parse(Console.ReadLine());
                Console.Write("Food Group: ");
                string foodGroup = Console.ReadLine();

                recipe.Ingredients.Add(new Ingredient
                {
                    Name = ingredientName,
                    Quantity = quantity,
                    Unit = unit,
                    Calories = calories,
                    FoodGroup = foodGroup
                });
            }

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Step #{i + 1}:");
                Console.Write("Description: ");
                string description = Console.ReadLine();

                recipe.Steps.Add(new RecipeStep { Description = description });
            }

            recipes.Add(recipe);
            Console.WriteLine("Recipe details entered.");
        }

        static void DisplayRecipeList()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            Console.WriteLine("Recipe List (Alphabetical Order):");
            List<string> recipeNames = recipes.Select(r => r.Name).OrderBy(name => name).ToList();
            foreach (string name in recipeNames)
            {
                Console.WriteLine(name);
            }
        }

        static void DisplayRecipeDetails()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            Console.WriteLine("Select a recipe to display:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].Name}");
            }

            string input = Console.ReadLine();
            if (int.TryParse(input, out int recipeIndex) && recipeIndex >= 1 && recipeIndex <= recipes.Count)
            {
                Recipe selectedRecipe = recipes[recipeIndex - 1];
                Console.WriteLine("Recipe Details:");
                Console.WriteLine($"Name: {selectedRecipe.Name}");
                Console.WriteLine("Ingredients:");
                foreach (Ingredient ingredient in selectedRecipe.Ingredients)
                {
                    Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
                }
                Console.WriteLine("Steps:");
                foreach (RecipeStep step in selectedRecipe.Steps)
                {
                    Console.WriteLine(step.Description);
                }
                Console.WriteLine($"Total Calories: {selectedRecipe.GetTotalCalories()}");
                if (selectedRecipe.GetTotalCalories() > 300)
                {
                    Console.WriteLine("Warning: The total calories of this recipe exceed 300.");
                }
            }
            else
            {
                Console.WriteLine("Invalid recipe selection.");
            }
        }

        static void ScaleRecipe()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            Console.WriteLine("Select a recipe to scale:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].Name}");
            }

            string input = Console.ReadLine();
            if (int.TryParse(input, out int recipeIndex) && recipeIndex >= 1 && recipeIndex <= recipes.Count)
            {
                Recipe selectedRecipe = recipes[recipeIndex - 1];
                Console.Write("Enter the scaling factor (0.5, 2, or 3): ");
                double factor = double.Parse(Console.ReadLine());

                foreach (Ingredient ingredient in selectedRecipe.Ingredients)
                {
                    ingredient.Quantity *= factor;
                }

                Console.WriteLine("Recipe scaled.");
            }
            else
            {
                Console.WriteLine("Invalid recipe selection.");
            }
        }

        static void ResetQuantities()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            Console.WriteLine("Select a recipe to reset quantities:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].Name}");
            }

            string input = Console.ReadLine();
            if (int.TryParse(input, out int recipeIndex) && recipeIndex >= 1 && recipeIndex <= recipes.Count)
            {
                Recipe selectedRecipe = recipes[recipeIndex - 1];
                foreach (Ingredient ingredient in selectedRecipe.Ingredients)
                {
                    ingredient.Quantity = GetOriginalQuantity(ingredient.Name);
                }

                Console.WriteLine("Quantities reset.");
            }
            else
            {
                Console.WriteLine("Invalid recipe selection.");
            }
        }

        static double GetOriginalQuantity(string ingredientName)
        {
            // Your logic to retrieve the original quantity based on the ingredient name
            // ...
            return 0; // Default value if original quantity is not found
        }

        static void ClearAllData()
        {
            recipes.Clear();
            Console.WriteLine("All data cleared.");
        }
    }
}**/
using System;
using System.Collections.Generic;
using System.Linq;
//using NUnit.Framework;



namespace RecipeApp


{


    public delegate void StringDelegate(string warning);
    class Ingredient
    {
        public string Name { get; set; } // Name of the ingredient
        public double Quantity { get; set; } // Quantity of the ingredient
        public string Unit { get; set; } // Unit of measurement for the ingredient
        public int Calories { get; set; } // Number of calories in the ingredient
        public string FoodGroup { get; set; } // Food group to which the ingredient belongs
    }

    class RecipeStep
    {
        public string Description { get; set; } // Description of a recipe step
    }

    class Recipe
    {
        public string Name { get; set; } // Name of the recipe
        public List<Ingredient> Ingredients { get; set; } // List of ingredients in the recipe
        public List<RecipeStep> Steps { get; set; } // List of steps in the recipe

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
            Steps = new List<RecipeStep>();
        }

        public int GetTotalCalories()
        {
            return Ingredients.Sum(i => i.Calories); // Calculates the total calories of all ingredients in the recipe
        }
    }

    class Program
    {
        static List<Recipe> recipes = new List<Recipe>(); // List to store recipes

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe list");
                Console.WriteLine("3. Display recipe details");
                Console.WriteLine("4. Scale recipe");
                Console.WriteLine("5. Reset quantities");
                Console.WriteLine("6. Clear all data");
                Console.WriteLine("7. Exit");

                string input = Console.ReadLine(); // Read user input

                switch (input)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Red;

                        EnterRecipeDetails(); // Call method to enter recipe details
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Blue;

                        DisplayRecipeList(); // Call method to display recipe list
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        DisplayRecipeDetails(); // Call method to display recipe details
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        ScaleRecipe(); // Call method to scale a recipe
                        break;
                    case "5":
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        ResetQuantities(); // Call method to reset ingredient quantities
                        break;
                    case "6":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        ClearAllData(); // Call method to clear all data
                        break;
                    case "7":
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
           
        static void EnterRecipeDetails()
        {
            Console.Write("Enter the name of the recipe: ");
            string name = Console.ReadLine(); // Read the name of the recipe from the user

            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine()); // Read the number of ingredients from the user

            Console.Write("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine()); // Read the number of steps from the user

            Recipe recipe = new Recipe(name); // Create a new recipe instance

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter Ingredient(s) #{i + 1}:");
                Console.Write("Enter Name: ");
                string ingredientName = Console.ReadLine(); // Read the name of the ingredient from the user
                Console.Write("Enter Quantity: ");
                double quantity = double.Parse(Console.ReadLine()); // Read the quantity of the ingredient from the user
                Console.Write("Enter Unit of Measurement: ");
                string unit = Console.ReadLine(); // Read the unit of measurement for the ingredient from the user
                Console.Write("Enter Calories: ");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("What are calories in food?\r\nA calorie is a measurement, just like a teaspoon or an inch. Calories are the amount of energy released when your body breaks down (digests and absorbs) food. The more calories a food has, the more energy it can provide to your body");
                int calories = int.Parse(Console.ReadLine()); // Read the number of calories in the ingredient from the user
                if (calories > 300)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    StringDelegate warning = ToUpperCase;
                    warning("WARNING! THE CALORIES AMOUNT HAS EXCEEDED THE MAX CALORIES(300) TRY ALTERNATIVES THAT WILL DECREASE THIS AMMOUNT. ");
                    //Console.WriteLine("WARNING! THE CALORIES AMOUNT HAS EXCEEDED THE MAX CALORIES(300) TRY ALTERNATIVES THAT WILL DECREASE THIS AMMOUNT. ");
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.Write("Food Group:\r\n1)Fruit and vegetables.\r\n2)Starchy food.\r\n3)Dairy.\r\n4)Protein.\r\n5)Fat. ");
                Console.WriteLine("Food group mean where on the food pyramid does the food fall under and can be categoried in accordance to the groups mentioned above.");
                string foodGroup = Console.ReadLine(); // Read the food group to which the ingredient belongs from the user
                Console.ForegroundColor = ConsoleColor.Red;


                Ingredient ingredient = new Ingredient
                {
                    Name = ingredientName,
                    Quantity = quantity,
                    Unit = unit,
                    Calories = calories,
                    FoodGroup = foodGroup
                };

                recipe.Ingredients.Add(ingredient); // Add the ingredient to the recipe's list of ingredients

                if (calories > 300)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    StringDelegate warning = ToUpperCase;
                    warning("WARNING! THE CALORIES AMOUNT HAS EXCEEDED THE MAX CALORIES(300) TRY ALTERNATIVES THAT WILL DECREASE THIS AMMOUNT. ");
                    //Console.WriteLine("WARNING! THE CALORIES AMOUNT HAS EXCEEDED THE MAX CALORIES(300) TRY ALTERNATIVES THAT WILL DECREASE THIS AMMOUNT. ");
                }
            }

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Step #{i + 1}:");
                Console.Write("Description: ");
                string description = Console.ReadLine(); // Read the description of the recipe step from the user

                RecipeStep step = new RecipeStep
                {
                    Description = description
                };

                recipe.Steps.Add(step); // Add the step to the recipe's list of steps
            }

            recipes.Add(recipe); // Add the recipe to the list of recipes

            Console.WriteLine("Recipe details entered.");
        }

        static void DisplayRecipeList()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            Console.WriteLine("Recipe List (Alphabetical Order):");
            List<string> recipeNames = recipes.Select(r => r.Name).OrderBy(name => name).ToList();
            foreach (string name in recipeNames)
            {
                Console.WriteLine(name); // Display the names of all the recipes in alphabetical order
            }
        }

        static void DisplayRecipeDetails()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            Console.WriteLine("Select a recipe to display:");
            for (int i = 0; i < recipes.Count; i++)
                
            {
                Console.WriteLine($"{i + 1}. {recipes[i].Name}"); // Display the index and name of each recipe
            }

            string input = Console.ReadLine();
            if (int.TryParse(input, out int recipeIndex) && recipeIndex >= 1 && recipeIndex <= recipes.Count)
            {
                Recipe selectedRecipe = recipes[recipeIndex - 1];
                Console.WriteLine("Recipe Details:");
                Console.WriteLine($"Name: {selectedRecipe.Name}");
                Console.WriteLine("Ingredients:");
                foreach (Ingredient ingredient in selectedRecipe.Ingredients)
                {
                    Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
                }
                Console.WriteLine("Steps:");
                foreach (RecipeStep step in selectedRecipe.Steps)
                {
                    Console.WriteLine(step.Description);
                }
                Console.WriteLine($"Total Calories: {selectedRecipe.GetTotalCalories()}");
                if (selectedRecipe.GetTotalCalories() > 300)
                {
                 
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        
                    
                    Console.WriteLine("Warning: The total calories of this recipe exceed 300.");
                }
            }
            else
            {
                Console.WriteLine("Invalid recipe selection.");
            }
        }

        static void ScaleRecipe()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            Console.WriteLine("Select a recipe to scale:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].Name}"); // Display the index and name of each recipe
            }

            string input = Console.ReadLine();
            if (int.TryParse(input, out int recipeIndex) && recipeIndex >= 1 && recipeIndex <= recipes.Count)
            {
                Recipe selectedRecipe = recipes[recipeIndex - 1];
                Console.Write("Enter the scaling factor (0.5, 2, or 3): ");
                double factor = double.Parse(Console.ReadLine()); // Read the scaling factor from the user

                foreach (Ingredient ingredient in selectedRecipe.Ingredients)
                {
                    ingredient.Quantity *= factor; // Scale the quantity of each ingredient in the selected recipe
                }

                Console.WriteLine("Recipe scaled.");
            }
            else
            {
                Console.WriteLine("Invalid recipe selection.");
            }
        }

        static void ResetQuantities()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            Console.WriteLine("Select a recipe to reset quantities:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].Name}"); // Display the index and name of each recipe
            }

            string input = Console.ReadLine();
            if (int.TryParse(input, out int recipeIndex) && recipeIndex >= 1 && recipeIndex <= recipes.Count)
            {
                Recipe selectedRecipe = recipes[recipeIndex - 1];

                foreach (Ingredient ingredient in selectedRecipe.Ingredients)
                {
                    ingredient.Quantity = GetOriginalQuantity(ingredient.Name); // Reset the quantity of each ingredient in the selected recipe
                }

                Console.WriteLine("Quantities reset.");
            }
            else
            {
                Console.WriteLine("Invalid recipe selection.");
            }
        }

        static double GetOriginalQuantity(string ingredientName)
        {
            // Your logic to retrieve the original quantity based on the ingredient name
            // ...
            return 0; // Default value if original quantity is not found
        }

        static void ClearAllData()
        {
            recipes.Clear(); // Clear all recipes from the list
            Console.WriteLine("All data cleared.");
        }
        static void ToUpperCase(string warning) => Console.WriteLine(warning);

    }

}
/**using NUnit.Framework;

namespace RecipeApp.Tests
{
    [TestFixture]
    public class RecipeTests
    {
        [Test]
        public void CalculateTotalCalories_ReturnsCorrectSum()
        {
            // Arrange
            Recipe recipe = new Recipe();
            Ingredient ingredient1 = new Ingredient { Name = "Ingredient 1", Calories = 100 };
            Ingredient ingredient2 = new Ingredient { Name = "Ingredient 2", Calories = 200 };
            recipe.Ingredients.Add(ingredient1);
            recipe.Ingredients.Add(ingredient2);

            // Act
            int totalCalories = recipe.GetTotalCalories();

            // Assert
            Assert.AreEqual(300, totalCalories);
        }
    }
}**/
