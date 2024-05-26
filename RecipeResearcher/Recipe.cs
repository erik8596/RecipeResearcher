using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGUI
{
    internal class Recipe
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();  // Ensure non-null initialization
        public string Url { get; set; }
        public List<string> UnavailableIngredients { get; set; } = new List<string>();
    }
}
