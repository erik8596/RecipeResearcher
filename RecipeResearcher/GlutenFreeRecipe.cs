using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGUI
{
    internal class GlutenFreeRecipe : RecipeIF
    {
        public async Task GenerateRecipesAsync(int numRecipes)
        {
            await Task.Run(() =>
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "FinalProjectGUI.recipesDB.txt";

                //Read all lines from the embedded resource
                List<string> allRecipes = new List<string>();
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (stream == null) throw new Exception("Resource not found.");
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            allRecipes.Add(reader.ReadLine());
                        }
                    }
                }

                //Extract header
                string header = allRecipes[0];

                //Find all gluten-free recipes, skipping header
                List<string> glutenFreeRecipes = allRecipes.Skip(1).Where(line => line.Contains("GlutenFree")).ToList();

                //Shuffle the list to get random recipes
                Random random = new Random();
                var selectedRecipes = glutenFreeRecipes.OrderBy(r => random.Next()).Take(numRecipes).ToList();

                //Write the selected recipes to 'UnfilteredRecipes.txt'
                string outputPath = "UnfilteredRecipes.txt";
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    
                    writer.WriteLine(header);

                    foreach (var recipe in selectedRecipes)
                    {
                        writer.WriteLine(recipe);
                    }
                }

                MessageBox.Show($"Created {numRecipes} gluten-free recipe(s).");
            });
        }
    }
}
