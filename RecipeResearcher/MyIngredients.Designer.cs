namespace FinalProjectGUI
{
    partial class MyIngredients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelMyIngredients = new Label();
            listBoxMyIngredients = new ListBox();
            label1 = new Label();
            labelDeleteIng = new Label();
            buttonOptionsMenu = new Button();
            buttonViewRecipes = new Button();
            buttonAddIng = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelMyIngredients
            // 
            labelMyIngredients.AutoSize = true;
            labelMyIngredients.Font = new Font("Segoe Script", 22F, FontStyle.Bold);
            labelMyIngredients.Location = new Point(63, 79);
            labelMyIngredients.Margin = new Padding(6, 0, 6, 0);
            labelMyIngredients.Name = "labelMyIngredients";
            labelMyIngredients.Size = new Size(520, 98);
            labelMyIngredients.TabIndex = 3;
            labelMyIngredients.Text = "My Ingredients:";
            // 
            // listBoxMyIngredients
            // 
            listBoxMyIngredients.FormattingEnabled = true;
            listBoxMyIngredients.Location = new Point(63, 290);
            listBoxMyIngredients.Margin = new Padding(6);
            listBoxMyIngredients.Name = "listBoxMyIngredients";
            listBoxMyIngredients.Size = new Size(793, 388);
            listBoxMyIngredients.TabIndex = 4;
            listBoxMyIngredients.MouseDoubleClick += listBoxMyIngredients_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 218);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 5;
            // 
            // labelDeleteIng
            // 
            labelDeleteIng.AutoSize = true;
            labelDeleteIng.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDeleteIng.Location = new Point(140, 247);
            labelDeleteIng.Margin = new Padding(6, 0, 6, 0);
            labelDeleteIng.Name = "labelDeleteIng";
            labelDeleteIng.Size = new Size(638, 37);
            labelDeleteIng.TabIndex = 6;
            labelDeleteIng.Text = "(to remove an ingredient, simply double-click on it)";
            // 
            // buttonOptionsMenu
            // 
            buttonOptionsMenu.AccessibleRole = AccessibleRole.None;
            buttonOptionsMenu.BackColor = Color.LightCoral;
            buttonOptionsMenu.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOptionsMenu.Location = new Point(63, 715);
            buttonOptionsMenu.Margin = new Padding(6);
            buttonOptionsMenu.Name = "buttonOptionsMenu";
            buttonOptionsMenu.Size = new Size(234, 201);
            buttonOptionsMenu.TabIndex = 7;
            buttonOptionsMenu.Text = "Options Menu\r\n<--";
            buttonOptionsMenu.UseVisualStyleBackColor = false;
            buttonOptionsMenu.Click += buttonPrevPage_Click;
            // 
            // buttonViewRecipes
            // 
            buttonViewRecipes.BackColor = Color.LightCoral;
            buttonViewRecipes.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewRecipes.Location = new Point(626, 715);
            buttonViewRecipes.Margin = new Padding(6);
            buttonViewRecipes.Name = "buttonViewRecipes";
            buttonViewRecipes.Size = new Size(234, 201);
            buttonViewRecipes.TabIndex = 8;
            buttonViewRecipes.Text = "My Recipes\r\n-->";
            buttonViewRecipes.UseVisualStyleBackColor = false;
            buttonViewRecipes.Click += buttonViewRecipes_Click;
            // 
            // buttonAddIng
            // 
            buttonAddIng.BackColor = Color.LightCoral;
            buttonAddIng.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddIng.Location = new Point(345, 715);
            buttonAddIng.Margin = new Padding(6);
            buttonAddIng.Name = "buttonAddIng";
            buttonAddIng.Size = new Size(234, 201);
            buttonAddIng.TabIndex = 9;
            buttonAddIng.Text = "Add Ingredients";
            buttonAddIng.UseVisualStyleBackColor = false;
            buttonAddIng.Click += buttonAddIng_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chef;
            pictureBox1.Location = new Point(989, 218);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 523);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // MyIngredients
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1486, 960);
            Controls.Add(pictureBox1);
            Controls.Add(buttonAddIng);
            Controls.Add(buttonViewRecipes);
            Controls.Add(buttonOptionsMenu);
            Controls.Add(labelDeleteIng);
            Controls.Add(label1);
            Controls.Add(listBoxMyIngredients);
            Controls.Add(labelMyIngredients);
            Margin = new Padding(6);
            Name = "MyIngredients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyIngredients";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMyIngredients;
        private ListBox listBoxMyIngredients;
        private Label label1;
        private Label labelDeleteIng;
        private Button buttonOptionsMenu;
        private Button buttonViewRecipes;
        private Button buttonAddIng;
        private PictureBox pictureBox1;
    }
}