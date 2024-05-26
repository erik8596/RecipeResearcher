using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGUI
{
    internal interface RecipeIF
    {
        Task GenerateRecipesAsync(int numRecipes);
    }
}
