using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGUI
{
    internal class RecipeFactory : RecipeFactoryIF
    {
        public RecipeIF selectRecipeType(string recipeType)
        {
            switch (recipeType)
            {
                case "Regular":
                    return new RegularRecipe();
                case "Vegan":
                    return new VeganRecipe();
                case "Keto":
                    return new KetoRecipe();
                case "GlutenFree":
                    return new GlutenFreeRecipe();
                default:
                    return null;
            }
        }
    }
}
