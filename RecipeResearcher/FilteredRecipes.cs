using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectGUI
{
    internal class FilteredRecipes : FilteredRecipesDecoratorIF
    {
        private RecipeSourceIF source;

        public FilteredRecipes(RecipeSourceIF source)
        {
            this.source = source;
        }

        public List<string> GetFormattedRecipeTexts()
        {
            var recipes = source.GetUnfilteredRecipes(); // Fetch filtered recipes
            List<string> formattedRecipes = new List<string>();

            foreach (var recipe in recipes)
            {
                List<string> ingredientTexts = new List<string>();
                foreach (var ingredient in recipe.Ingredients)
                {
                    // Check if the ingredient is missing
                    if (recipe.UnavailableIngredients.Contains(ingredient))
                    {
                        ingredientTexts.Add($"[red]{ingredient}[/red]");
                    }
                    else
                    {
                        ingredientTexts.Add(ingredient);
                    }
                }

                string formattedText = $"{recipe.Name} - {recipe.Type} | Ingredients: {string.Join(", ", ingredientTexts)} | URL: {recipe.Url}";
                formattedRecipes.Add(formattedText);
            }

            return formattedRecipes;
        }


    }
}

