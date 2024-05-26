using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace FinalProjectGUI
{
    public partial class AddIngredients : Form, FileObserver
    {

        public static event Action IngredientsChanged;

        public AddIngredients()
        {
            InitializeComponent();
            LoadIngredients();
            this.FormClosed += Form_Closed;
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewMyIngredients_Click(object sender, EventArgs e)
        {
            //Open the MyIngredients form
            MyIngredients myIngredients = new MyIngredients();
            myIngredients.Show();
            //Hide the current form
            this.Hide();
        }

        //Add the selected ingredient to the user's list of ingredients
        private void buttonAddIng_Click(object sender, EventArgs e)
        {
            string ingredient = comboBoxSelectIng.SelectedItem?.ToString();

            //Ensure an ingredient is selected
            if (string.IsNullOrEmpty(ingredient))
            {
                MessageBox.Show("Please select an ingredient."); 
                return;
            }

            //Read the selected ingredient from the ComboBox and add it to the user's list of ingredients
            string userIngredientsFile = "MyIngredients.txt";
            List<string> existingIngredients = new List<string>();

            if (File.Exists(userIngredientsFile))
            {
                using (StreamReader reader = new StreamReader(userIngredientsFile))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        existingIngredients.Add(line.Split(',')[0].Trim()); 
                    }
                }
            }

            //Check if the new ingredient already exists in the list
            if (existingIngredients.Contains(ingredient))
            {
                MessageBox.Show("This ingredient already exists.");
                return;
            }

            //Get expiration date information if the user has selected it
            string expDateInfo = string.Empty;

            if (checkBoxExpDates.Checked)
            {
                string year = comboBoxYear.SelectedItem?.ToString();
                string month = comboBoxMonth.SelectedItem?.ToString();
                string day = comboBoxDay.SelectedItem?.ToString();

                if (year != null && month != null && day != null)
                {
                    expDateInfo = $"{year}-{month}-{day}";
                }
            }

            string outputLine = ingredient;

            if (!string.IsNullOrEmpty(expDateInfo))
            {
                outputLine += $", {expDateInfo}";
            }

            //Append the new ingredient to the text file
            using (StreamWriter writer = new StreamWriter(userIngredientsFile, true))
            {
                writer.WriteLine(outputLine); // Write the new ingredient
                MessageBox.Show("Ingredient added successfully.");
            }

            IngredientsChanged?.Invoke();

        }

        private void checkBoxExpDates_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxYear.Enabled = (checkBoxExpDates.CheckState == CheckState.Checked);
            comboBoxMonth.Enabled = (checkBoxExpDates.CheckState == CheckState.Checked);
            comboBoxDay.Enabled = (checkBoxExpDates.CheckState == CheckState.Checked);
        }

        //load ingredients from embedded resource
        private void LoadIngredients()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "FinalProjectGUI.ingredientDB.txt"; 

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null) 
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            string ingredient = reader.ReadLine();
                            comboBoxSelectIng.Items.Add(ingredient);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: Embedded resource not found.");
                }
            }

            //configure autocomplete feature for ComboBox
            comboBoxSelectIng.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSelectIng.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
