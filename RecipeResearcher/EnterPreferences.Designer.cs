namespace FinalProjectGUI
{
    partial class EnterPreferences
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
            labelEnterPreferences = new Label();
            labelMaxRecipes = new Label();
            numericUpDown1 = new NumericUpDown();
            labelOptional = new Label();
            checkBoxVegan = new CheckBox();
            checkBoxKeto = new CheckBox();
            checkBoxGlutenFree = new CheckBox();
            buttonViewMyRecipes = new Button();
            buttonGenerateRec = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // labelEnterPreferences
            // 
            labelEnterPreferences.AutoSize = true;
            labelEnterPreferences.Font = new Font("Segoe Script", 22F, FontStyle.Bold);
            labelEnterPreferences.Location = new Point(353, 102);
            labelEnterPreferences.Margin = new Padding(6, 0, 6, 0);
            labelEnterPreferences.Name = "labelEnterPreferences";
            labelEnterPreferences.Size = new Size(775, 98);
            labelEnterPreferences.TabIndex = 12;
            labelEnterPreferences.Text = "Enter Your Preferences:";
            // 
            // labelMaxRecipes
            // 
            labelMaxRecipes.AutoSize = true;
            labelMaxRecipes.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMaxRecipes.Location = new Point(482, 293);
            labelMaxRecipes.Margin = new Padding(6, 0, 6, 0);
            labelMaxRecipes.Name = "labelMaxRecipes";
            labelMaxRecipes.Size = new Size(492, 40);
            labelMaxRecipes.TabIndex = 13;
            labelMaxRecipes.Text = "How many reicpes would you like?";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(611, 354);
            numericUpDown1.Margin = new Padding(6);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(223, 39);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelOptional
            // 
            labelOptional.AutoSize = true;
            labelOptional.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOptional.Location = new Point(466, 448);
            labelOptional.Margin = new Padding(6, 0, 6, 0);
            labelOptional.Name = "labelOptional";
            labelOptional.Size = new Size(531, 40);
            labelOptional.TabIndex = 15;
            labelOptional.Text = "Optional Preferences (Select up to 1):";
            // 
            // checkBoxVegan
            // 
            checkBoxVegan.AutoSize = true;
            checkBoxVegan.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold);
            checkBoxVegan.Location = new Point(635, 510);
            checkBoxVegan.Margin = new Padding(6);
            checkBoxVegan.Name = "checkBoxVegan";
            checkBoxVegan.Size = new Size(147, 44);
            checkBoxVegan.TabIndex = 16;
            checkBoxVegan.Text = "Vegan?";
            checkBoxVegan.UseVisualStyleBackColor = true;
            // 
            // checkBoxKeto
            // 
            checkBoxKeto.AutoSize = true;
            checkBoxKeto.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold);
            checkBoxKeto.Location = new Point(635, 587);
            checkBoxKeto.Margin = new Padding(6);
            checkBoxKeto.Name = "checkBoxKeto";
            checkBoxKeto.Size = new Size(126, 44);
            checkBoxKeto.TabIndex = 17;
            checkBoxKeto.Text = "Keto?";
            checkBoxKeto.UseVisualStyleBackColor = true;
            // 
            // checkBoxGlutenFree
            // 
            checkBoxGlutenFree.AutoSize = true;
            checkBoxGlutenFree.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold);
            checkBoxGlutenFree.Location = new Point(635, 663);
            checkBoxGlutenFree.Margin = new Padding(6);
            checkBoxGlutenFree.Name = "checkBoxGlutenFree";
            checkBoxGlutenFree.Size = new Size(221, 44);
            checkBoxGlutenFree.TabIndex = 18;
            checkBoxGlutenFree.Text = "Gluten Free?";
            checkBoxGlutenFree.UseVisualStyleBackColor = true;
            // 
            // buttonViewMyRecipes
            // 
            buttonViewMyRecipes.BackColor = Color.LightCoral;
            buttonViewMyRecipes.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewMyRecipes.Location = new Point(65, 661);
            buttonViewMyRecipes.Margin = new Padding(6);
            buttonViewMyRecipes.Name = "buttonViewMyRecipes";
            buttonViewMyRecipes.Size = new Size(396, 201);
            buttonViewMyRecipes.TabIndex = 19;
            buttonViewMyRecipes.Text = "View My Recipes\n<--";
            buttonViewMyRecipes.UseVisualStyleBackColor = false;
            buttonViewMyRecipes.Click += buttonViewMyRecipes_Click;
            // 
            // buttonGenerateRec
            // 
            buttonGenerateRec.BackColor = Color.LightCoral;
            buttonGenerateRec.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGenerateRec.Location = new Point(1027, 661);
            buttonGenerateRec.Margin = new Padding(6);
            buttonGenerateRec.Name = "buttonGenerateRec";
            buttonGenerateRec.Size = new Size(396, 201);
            buttonGenerateRec.TabIndex = 20;
            buttonGenerateRec.Text = "Give me New Recipes!";
            buttonGenerateRec.UseVisualStyleBackColor = false;
            buttonGenerateRec.Click += buttonGenerateRec_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(1038, 623);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(362, 32);
            label1.TabIndex = 21;
            label1.Text = "(click below to generate recipes)";
            // 
            // EnterPreferences
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1486, 960);
            Controls.Add(label1);
            Controls.Add(buttonGenerateRec);
            Controls.Add(buttonViewMyRecipes);
            Controls.Add(checkBoxGlutenFree);
            Controls.Add(checkBoxKeto);
            Controls.Add(checkBoxVegan);
            Controls.Add(labelOptional);
            Controls.Add(numericUpDown1);
            Controls.Add(labelMaxRecipes);
            Controls.Add(labelEnterPreferences);
            Margin = new Padding(6);
            Name = "EnterPreferences";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnterPreferences";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEnterPreferences;
        private Label labelMaxRecipes;
        private NumericUpDown numericUpDown1;
        private Label labelOptional;
        private CheckBox checkBoxVegan;
        private CheckBox checkBoxKeto;
        private CheckBox checkBoxGlutenFree;
        private Button buttonViewMyRecipes;
        private Button buttonGenerateRec;
        private Label label1;
    }
}