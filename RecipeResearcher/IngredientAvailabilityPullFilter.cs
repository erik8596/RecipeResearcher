using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace FinalProjectGUI
{
    internal class IngredientAvailabilityPullFilter : AbstractPullFilter
    {
        private RecipeSourceIF recipeSource;
        private HashSet<string> availableIngredients;

        public IngredientAvailabilityPullFilter()
        {
            this.availableIngredients = new HashSet<string>();
            ParseInventory();
        }

        public override void create(RecipeSourceIF recipeSource)
        {
            this.recipeSource = recipeSource;
        }

        public override List<Recipe> GetUnfilteredRecipes()
        {
            if (recipeSource == null)
            {
                throw new InvalidOperationException("Recipe source not initialized.");
            }

            var allRecipes = recipeSource.GetUnfilteredRecipes();
            foreach (var recipe in allRecipes)
            {
                recipe.UnavailableIngredients = recipe.Ingredients
                    .Where(ingredient => !availableIngredients.Contains(ingredient))
                    .ToList();
            }

            return allRecipes.Where(recipe => recipe.UnavailableIngredients.Any()).ToList();
        }

        private void ParseInventory()
        {
            string filePath = "MyIngredients.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Ingredient inventory file not found.");
                return;
            }

            availableIngredients.Clear(); //Ensures the list is cleared before reloading

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Trim();
                    var parts = line.Split(',');
                    string ingredient = parts[0].Trim();
                    availableIngredients.Add(ingredient);
                }
            }
        }
    }
}
