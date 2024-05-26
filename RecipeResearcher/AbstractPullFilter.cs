using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGUI
{
    internal abstract class AbstractPullFilter : RecipeSourceIF
    {
        abstract public List<Recipe> GetUnfilteredRecipes();
        abstract public void create(RecipeSourceIF recipeSource);
    }
}
