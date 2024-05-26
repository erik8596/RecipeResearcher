using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectGUI
{
    public partial class EnterPreferences : Form
    {
        public EnterPreferences()
        {
            InitializeComponent();
            this.FormClosed += Form_Closed;
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void buttonGenerateRec_Click(object sender, EventArgs e)
        {
            //Store the number of recipes the user desires
            int numRecipes = (int)numericUpDown1.Value;
            string recipeType = "";
            //use recipefactoryIF to create a recipe based on which checkbox is checked and how many recipes the user desires
            if(checkBoxKeto.Checked)
            {
                recipeType = "Keto";
            }
            else if(checkBoxVegan.Checked)
            {
                recipeType = "Vegan";
            }
            else if(checkBoxGlutenFree.Checked)
            {
                recipeType = "GlutenFree";
            }
            else
            {
                recipeType = "Regular";
            }
            RecipeFactoryIF recipeFactory = new RecipeFactory();
            RecipeIF recipe = recipeFactory.selectRecipeType(recipeType);
            await recipe.GenerateRecipesAsync(numRecipes);
        }

        private void buttonViewMyRecipes_Click(object sender, EventArgs e)
        {
            //Open the MyRecipes form
            MyRecipes myRecipes = new MyRecipes();
            myRecipes.Show();
            //Hide the current form
            this.Hide();
        }
    }
}
