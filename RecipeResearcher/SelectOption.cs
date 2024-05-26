using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectGUI
{
    public partial class SelectOption : Form
    {
        public SelectOption()
        {
            InitializeComponent();
            this.FormClosed += Form_Closed;
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void labelRecipeResearcher_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewIngredients_Click(object sender, EventArgs e)
        {
            //Open the MyIngredients form
            MyIngredients myIngredients = new MyIngredients();
            myIngredients.Show();
            //Hide the current form
            this.Hide();
        }

        private void buttonViewRecipes_Click(object sender, EventArgs e)
        {
            //Open the MyRecipes form
            MyRecipes myRecipes = new MyRecipes();
            myRecipes.Show();
            //Hide the current form
            this.Hide();
        }

        private void buttonAddIngredients_Click(object sender, EventArgs e)
        {
            //Open the AddIngredients form
            AddIngredients addIngredients = new AddIngredients();
            addIngredients.Show();
            //Hide the current form
            this.Hide();
        }
    }
}
