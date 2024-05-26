﻿using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGUI
{
    internal interface RecipeFactoryIF
    {
         RecipeIF selectRecipeType(string recipeType);
    }
}
