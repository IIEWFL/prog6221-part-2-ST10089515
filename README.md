# Recipe App

The Recipe App is a console-based application that allows users to manage recipes, including entering recipe details, displaying recipes, scaling recipes, resetting ingredient quantities, and clearing all data.

## Features

The Recipe App provides the following features:

1. **Enter recipe details**: Users can enter the name of the recipe, the number of ingredients, and the number of steps. They can then input the details for each ingredient and step, including the name, quantity, unit of measurement, calories, and food group.

2. **Display recipe list**: Users can view a list of all the entered recipes in alphabetical order. The list displays the names of the recipes.

3. **Display recipe details**: Users can select a recipe from the list and view its details, including the name, ingredients (with quantity, unit, and name), steps, and the total calories of the recipe. If the total calories exceed 300, a warning message is displayed.

4. **Scale recipe**: Users can select a recipe and scale it by entering a scaling factor of 0.5, 2, or 3. This scales the quantities of all ingredients in the recipe accordingly.

5. **Reset quantities**: Users can select a recipe and reset the quantities of all ingredients to their original values. The original quantities are retrieved based on the ingredient names.

6. **Clear all data**: Users can clear all entered recipe data, including recipes, ingredients, and steps.

## Usage

1. Run the program and follow the instructions in the console.

2. Select an option from the menu by entering the corresponding number.

3. Enter recipe details by providing the necessary information for each ingredient and step.

4. Display the recipe list to view the names of all entered recipes.

5. Display recipe details to view the complete details of a specific recipe, including ingredients, steps, and total calories.

6. Scale a recipe by selecting it and entering a scaling factor.

7. Reset ingredient quantities to their original values for a specific recipe.

8. Clear all data to remove all entered recipes.

9. Exit the program by selecting the "Exit" option from the menu.

## Requirements

- .NET Framework 4.7.2 or later

## Future Improvements

The Recipe App can be enhanced with the following features in the future:

1. Allow users to edit and delete recipes, ingredients, and steps.

2. Implement a search functionality to search for specific recipes or ingredients.

3. Provide nutritional information, such as fat, protein, and carbohydrates, for each ingredient and the overall recipe.

4. Add the ability to save and load recipes from external files, such as JSON or XML.

## Contribution

Contributions to the Recipe App are welcome! If you have any suggestions, bug reports, or feature requests, please open an issue or submit a pull request.
## UPDATES FROM PART 1
1. Added a new property `Calories` to the `Ingredient` class:
   - The `Calories` property represents the number of calories in the ingredient.

2. Added a new method `GetTotalCalories()` to the `Recipe` class:
   - The `GetTotalCalories()` method calculates the total calories of all the ingredients in the recipe.
   - It uses LINQ's `Sum()` method to calculate the sum of calories for all ingredients.

3. Updated the `Recipe` class constructor:
   - The constructor now takes a `name` parameter and initializes the `Name` property of the recipe.

4. Changed the `Ingredients` and `Steps` properties in the `Recipe` class to use `List<T>` instead of arrays:
   - This allows for dynamic resizing of the lists as ingredients and steps are added to the recipe.

5. Replaced the `EnterRecipeDetails()` method:
   - The updated `EnterRecipeDetails()` method prompts the user to enter the name, ingredient count, and step count for the recipe.
   - It creates a new `Recipe` instance with the provided name.
   - It then prompts the user to enter details for each ingredient and step, and adds them to the recipe using the `Add()` method of the `Ingredients` and `Steps` lists.

6. Updated the `DisplayRecipeDetails()` method:
   - The method now displays the total calories of the selected recipe using the `GetTotalCalories()` method.
   - It also displays a warning message if the total calories exceed 300.

7. Updated the `ScaleRecipe()` method:
   - The method now uses a scaling factor entered by the user to adjust the quantity of each ingredient in the selected recipe.

8. Updated the `ResetQuantities()` method:
   - The method sets the quantity of each ingredient in the selected recipe to the original quantity obtained from the `GetOriginalQuantity()` method.

9. Added a new `ClearAllData()` method:
   - The `ClearAllData()` method clears the `recipes` list, removing all recipe data.

---

Thank you for using the Recipe App! We hope it simplifies your recipe management and cooking experience.
