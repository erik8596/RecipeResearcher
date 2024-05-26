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
    public partial class MyRecipes : Form, FileObserver
    {
        private FileWatcher _fileWatcher;
        public MyRecipes()
        {
            InitializeComponent();
            DisplayRecipes();
            this.FormClosed += Form_Closed;

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyIngredients.txt");
            _fileWatcher = new FileWatcher(filePath);
            _fileWatcher.RegisterObserver(this);
        }
        public void Update()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(DisplayRecipes));
            }
            else
            {
                DisplayRecipes();
            }
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            _fileWatcher.UnregisterObserver(this);
            _fileWatcher.StopWatching();
            Application.Exit();
        }

        private void buttonViewOptionsMenu_Click(object sender, EventArgs e)
        {
            //Open the SelectOption form
            SelectOption selectOption = new SelectOption();
            selectOption.Show();
            //Hide the current form
            this.Hide();
        }

        private void buttonGenerateRec_Click(object sender, EventArgs e)
        {
            //Open the EnterPreferences form
            EnterPreferences enterPreferences = new EnterPreferences();
            enterPreferences.Show();
            //Hide the current form
            this.Hide();
        }

        public void DisplayRecipes()
        {
            listBoxMyRecipes.Items.Clear();
            var recipeSource = new UnfilteredRecipesSource();
            var availabilityFilter = new IngredientAvailabilityPullFilter();
            availabilityFilter.create(recipeSource);

            var filteredRecipes = new FilteredRecipes(availabilityFilter);
            var formattedRecipes = filteredRecipes.GetFormattedRecipeTexts();

            foreach (var recipeText in formattedRecipes)
            {
                listBoxMyRecipes.Items.Add(recipeText);
            }

            UpdateHorizontalExtent();
        }

        private void ListBoxMyRecipes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;

            string text = listBoxMyRecipes.Items[e.Index].ToString();
            e.DrawBackground();
            e.DrawFocusRectangle();


            string[] parts = text.Split(new string[] { "[red]", "[/red]" }, StringSplitOptions.None);
            bool isRed = false;
            float xPos = e.Bounds.X;

            foreach (var part in parts)
            {
                using (Brush brush = isRed ? new SolidBrush(Color.Red) : new SolidBrush(e.ForeColor))
                {
                    SizeF size = e.Graphics.MeasureString(part, e.Font);
                    e.Graphics.DrawString(part, e.Font, brush, xPos, e.Bounds.Y);
                    xPos += size.Width; // Move xPos for the next part
                }
                isRed = !isRed; // Toggle red on/off
            }
        }

        public void UpdateHorizontalExtent()
        {
            int maxWidth = 0;
            using (Graphics g = listBoxMyRecipes.CreateGraphics())
            {
                foreach (var item in listBoxMyRecipes.Items)
                {
                    maxWidth = Math.Max(maxWidth, (int)g.MeasureString(item.ToString(), listBoxMyRecipes.Font).Width);
                }
            }
            listBoxMyRecipes.HorizontalExtent = maxWidth;
        }
    }
}
