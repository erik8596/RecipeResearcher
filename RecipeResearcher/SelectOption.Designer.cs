namespace FinalProjectGUI
{
    partial class SelectOption
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
            labelSelectAnOption = new Label();
            buttonViewIngredients = new Button();
            buttonViewRecipes = new Button();
            buttonAddIngredients = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelSelectAnOption
            // 
            labelSelectAnOption.AutoSize = true;
            labelSelectAnOption.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSelectAnOption.Location = new Point(280, 147);
            labelSelectAnOption.Margin = new Padding(6, 0, 6, 0);
            labelSelectAnOption.Name = "labelSelectAnOption";
            labelSelectAnOption.Size = new Size(571, 97);
            labelSelectAnOption.TabIndex = 2;
            labelSelectAnOption.Text = "Select an Option:";
            labelSelectAnOption.Click += labelRecipeResearcher_Click;
            // 
            // buttonViewIngredients
            // 
            buttonViewIngredients.BackColor = Color.LightCoral;
            buttonViewIngredients.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewIngredients.Location = new Point(357, 294);
            buttonViewIngredients.Margin = new Padding(6);
            buttonViewIngredients.Name = "buttonViewIngredients";
            buttonViewIngredients.Size = new Size(355, 143);
            buttonViewIngredients.TabIndex = 3;
            buttonViewIngredients.Text = "View My Ingredients";
            buttonViewIngredients.UseVisualStyleBackColor = false;
            buttonViewIngredients.Click += buttonViewIngredients_Click;
            // 
            // buttonViewRecipes
            // 
            buttonViewRecipes.BackColor = Color.LightCoral;
            buttonViewRecipes.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewRecipes.Location = new Point(357, 482);
            buttonViewRecipes.Margin = new Padding(6);
            buttonViewRecipes.Name = "buttonViewRecipes";
            buttonViewRecipes.Size = new Size(355, 143);
            buttonViewRecipes.TabIndex = 4;
            buttonViewRecipes.Text = "View My Recipes";
            buttonViewRecipes.UseVisualStyleBackColor = false;
            buttonViewRecipes.Click += buttonViewRecipes_Click;
            // 
            // buttonAddIngredients
            // 
            buttonAddIngredients.BackColor = Color.LightCoral;
            buttonAddIngredients.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddIngredients.Location = new Point(357, 668);
            buttonAddIngredients.Margin = new Padding(6);
            buttonAddIngredients.Name = "buttonAddIngredients";
            buttonAddIngredients.Size = new Size(355, 143);
            buttonAddIngredients.TabIndex = 5;
            buttonAddIngredients.Text = "Add Ingredients";
            buttonAddIngredients.UseVisualStyleBackColor = false;
            buttonAddIngredients.Click += buttonAddIngredients_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.groceries;
            pictureBox1.Location = new Point(880, 350);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 348);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // SelectOption
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1486, 960);
            Controls.Add(pictureBox1);
            Controls.Add(buttonAddIngredients);
            Controls.Add(buttonViewRecipes);
            Controls.Add(buttonViewIngredients);
            Controls.Add(labelSelectAnOption);
            Margin = new Padding(6);
            Name = "SelectOption";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectOption";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSelectAnOption;
        private Button buttonViewIngredients;
        private Button buttonViewRecipes;
        private Button buttonAddIngredients;
        private PictureBox pictureBox1;
    }
}