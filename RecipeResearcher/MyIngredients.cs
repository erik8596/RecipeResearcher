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
    public partial class MyIngredients : Form, FileObserver
    {
        public MyIngredients()
        {
            InitializeComponent();
            AddIngredients.IngredientsChanged += LoadIngredientsIntoListBox;
            LoadIngredientsIntoListBox();
            listBoxMyIngredients.MouseDoubleClick += listBoxMyIngredients_MouseDoubleClick;
            this.FormClosed += Form_Closed;
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddIng_Click(object sender, EventArgs e)
        {
            //Open the AddIngredients form
            AddIngredients addIngredients = new AddIngredients();
            addIngredients.Show();
            //Hide the current form
            this.Hide();
        }

        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            //Open the SelectOption form
            SelectOption selectOption = new SelectOption();
            selectOption.Show();
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

        //Load the user's ingredients into the ListBox
        private void LoadIngredientsIntoListBox()
        {
            string filePath = "MyIngredients.txt"; // Path to the text file

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream) // Read the text file
                    {
                        string line = reader.ReadLine().Trim(); // Read and trim spaces

                        // Add the entire line to the ListBox without additional formatting
                        listBoxMyIngredients.Items.Add(line); // Store the exact line in the ListBox
                    }
                }
            }
            else
            {
                MessageBox.Show("The ingredients list file was not found."); // Handle missing file
            }
        }

        private void listBoxMyIngredients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBoxMyIngredients.SelectedIndex; // Get the selected index

            if (selectedIndex >= 0) // Ensure there's a valid selection
            {
                string selectedItem = listBoxMyIngredients.SelectedItem.ToString(); // Get the selected item

                // Confirm deletion with the user
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this ingredient?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    listBoxMyIngredients.Items.RemoveAt(selectedIndex); // Remove the item from the ListBox

                    // Update the text file
                    string filePath = "MyIngredients.txt"; // Path to the text file
                    List<string> updatedIngredients = new List<string>();

                    if (File.Exists(filePath))
                    {
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null) // Read existing lines
                            {
                                line = line.Trim(); // Read and trim spaces
                                if (line != selectedItem) // Check for exact match
                                {
                                    updatedIngredients.Add(line); // Add non-matching lines to the list
                                }
                            }
                        }

                        // Rewrite the text file with the updated list
                        using (StreamWriter writer = new StreamWriter(filePath, false)) // 'false' to overwrite
                        {
                            foreach (var ingredient in updatedIngredients)
                            {
                                writer.WriteLine(ingredient); // Write each updated item
                            }
                        }
                    }
                }
            }
        }

    }
}
