using System;
using System.Collections.Generic;
using System.IO;  // Make sure to include System.IO for file operations

namespace FinalProjectGUI
{
    internal class UnfilteredRecipesSource : RecipeSourceIF
    {
        public List<Recipe> GetUnfilteredRecipes()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UnfilteredRecipes.txt");
            List<Recipe> unfilteredRecipes = new List<Recipe>();

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The file 'UnfilteredRecipes.txt' was not found.");
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                reader.ReadLine(); // Skip the header line

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var fields = line.Split(',');
                    if (fields.Length >= 4) // Ensure there are at least four fields
                    {
                        string recipeName = fields[0];
                        string type = fields[1];
                        string url = fields.Last(); // The URL is the last element
                        List<string> ingredients = fields.Skip(2).Take(fields.Length - 3).ToList(); // Skip name and type, and exclude the URL

                        Recipe recipe = new Recipe
                        {
                            Name = recipeName,
                            Type = type,
                            Ingredients = ingredients,
                            Url = url
                        };
                        unfilteredRecipes.Add(recipe);
                    }
                }
            }

            return unfilteredRecipes;
        }

    }
}
