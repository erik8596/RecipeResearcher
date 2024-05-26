namespace FinalProjectGUI
{
    partial class AddIngredients
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
            labelAddIngredients = new Label();
            comboBoxSelectIng = new ComboBox();
            comboBoxYear = new ComboBox();
            labelSelectIng = new Label();
            labelOptionalDate = new Label();
            labelYear = new Label();
            labelMonth = new Label();
            labelDay = new Label();
            checkBoxExpDates = new CheckBox();
            comboBoxMonth = new ComboBox();
            comboBoxDay = new ComboBox();
            buttonAddIng = new Button();
            labelAddToInv = new Label();
            buttonViewMyIngredients = new Button();
            SuspendLayout();
            // 
            // labelAddIngredients
            // 
            labelAddIngredients.AutoSize = true;
            labelAddIngredients.Font = new Font("Segoe Script", 22F, FontStyle.Bold);
            labelAddIngredients.Location = new Point(110, 73);
            labelAddIngredients.Margin = new Padding(6, 0, 6, 0);
            labelAddIngredients.Name = "labelAddIngredients";
            labelAddIngredients.Size = new Size(558, 98);
            labelAddIngredients.TabIndex = 13;
            labelAddIngredients.Text = "Add Ingredients:";
            // 
            // comboBoxSelectIng
            // 
            comboBoxSelectIng.FormattingEnabled = true;
            comboBoxSelectIng.Location = new Point(110, 303);
            comboBoxSelectIng.Margin = new Padding(6);
            comboBoxSelectIng.Name = "comboBoxSelectIng";
            comboBoxSelectIng.Size = new Size(699, 40);
            comboBoxSelectIng.Sorted = true;
            comboBoxSelectIng.TabIndex = 10;
            // 
            // comboBoxYear
            // 
            comboBoxYear.Enabled = false;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Items.AddRange(new object[] { "2024", "2025", "2026", "2027", "2028", "2029", "2030" });
            comboBoxYear.Location = new Point(461, 531);
            comboBoxYear.Margin = new Padding(6);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(104, 40);
            comboBoxYear.TabIndex = 15;
            // 
            // labelSelectIng
            // 
            labelSelectIng.AutoSize = true;
            labelSelectIng.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSelectIng.Location = new Point(110, 243);
            labelSelectIng.Margin = new Padding(6, 0, 6, 0);
            labelSelectIng.Name = "labelSelectIng";
            labelSelectIng.Size = new Size(704, 40);
            labelSelectIng.TabIndex = 16;
            labelSelectIng.Text = "1) Select your ingredient from the drop-down list:";
            // 
            // labelOptionalDate
            // 
            labelOptionalDate.AutoSize = true;
            labelOptionalDate.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOptionalDate.Location = new Point(110, 414);
            labelOptionalDate.Margin = new Padding(6, 0, 6, 0);
            labelOptionalDate.Name = "labelOptionalDate";
            labelOptionalDate.Size = new Size(977, 40);
            labelOptionalDate.TabIndex = 17;
            labelOptionalDate.Text = "2) (Optionally) Enable expiration dates to prioritize recipe generation:";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelYear.Location = new Point(479, 493);
            labelYear.Margin = new Padding(6, 0, 6, 0);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(71, 32);
            labelYear.TabIndex = 22;
            labelYear.Text = "Year:";
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMonth.Location = new Point(643, 493);
            labelMonth.Margin = new Padding(6, 0, 6, 0);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(97, 32);
            labelMonth.TabIndex = 23;
            labelMonth.Text = "Month:";
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDay.Location = new Point(835, 493);
            labelDay.Margin = new Padding(6, 0, 6, 0);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(65, 32);
            labelDay.TabIndex = 24;
            labelDay.Text = "Day:";
            // 
            // checkBoxExpDates
            // 
            checkBoxExpDates.AutoSize = true;
            checkBoxExpDates.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxExpDates.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxExpDates.Location = new Point(158, 531);
            checkBoxExpDates.Margin = new Padding(6);
            checkBoxExpDates.Name = "checkBoxExpDates";
            checkBoxExpDates.Size = new Size(245, 36);
            checkBoxExpDates.TabIndex = 26;
            checkBoxExpDates.Text = "Expiration Dates?";
            checkBoxExpDates.UseVisualStyleBackColor = true;
            checkBoxExpDates.CheckedChanged += checkBoxExpDates_CheckedChanged;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.Enabled = false;
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBoxMonth.Location = new Point(615, 531);
            comboBoxMonth.Margin = new Padding(6);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(158, 40);
            comboBoxMonth.TabIndex = 27;
            // 
            // comboBoxDay
            // 
            comboBoxDay.Enabled = false;
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBoxDay.Location = new Point(825, 531);
            comboBoxDay.Margin = new Padding(6);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(84, 40);
            comboBoxDay.TabIndex = 28;
            // 
            // buttonAddIng
            // 
            buttonAddIng.BackColor = Color.LightCoral;
            buttonAddIng.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddIng.Location = new Point(158, 717);
            buttonAddIng.Margin = new Padding(6);
            buttonAddIng.Name = "buttonAddIng";
            buttonAddIng.Size = new Size(273, 175);
            buttonAddIng.TabIndex = 35;
            buttonAddIng.Text = "Add New Ingredient";
            buttonAddIng.UseVisualStyleBackColor = false;
            buttonAddIng.Click += buttonAddIng_Click;
            // 
            // labelAddToInv
            // 
            labelAddToInv.AutoSize = true;
            labelAddToInv.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddToInv.Location = new Point(110, 636);
            labelAddToInv.Margin = new Padding(6, 0, 6, 0);
            labelAddToInv.Name = "labelAddToInv";
            labelAddToInv.Size = new Size(767, 40);
            labelAddToInv.TabIndex = 36;
            labelAddToInv.Text = "3) Click below to add the ingredient to your inventory:";
            labelAddToInv.Click += label1_Click;
            // 
            // buttonViewMyIngredients
            // 
            buttonViewMyIngredients.BackColor = Color.LightCoral;
            buttonViewMyIngredients.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewMyIngredients.Location = new Point(1106, 773);
            buttonViewMyIngredients.Margin = new Padding(6);
            buttonViewMyIngredients.Name = "buttonViewMyIngredients";
            buttonViewMyIngredients.Size = new Size(345, 151);
            buttonViewMyIngredients.TabIndex = 37;
            buttonViewMyIngredients.Text = "View My Ingredients -->";
            buttonViewMyIngredients.UseVisualStyleBackColor = false;
            buttonViewMyIngredients.Click += buttonViewMyIngredients_Click;
            // 
            // AddIngredients
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1486, 960);
            Controls.Add(buttonViewMyIngredients);
            Controls.Add(labelAddToInv);
            Controls.Add(buttonAddIng);
            Controls.Add(comboBoxDay);
            Controls.Add(comboBoxMonth);
            Controls.Add(checkBoxExpDates);
            Controls.Add(labelDay);
            Controls.Add(labelMonth);
            Controls.Add(labelYear);
            Controls.Add(labelOptionalDate);
            Controls.Add(labelSelectIng);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxSelectIng);
            Controls.Add(labelAddIngredients);
            Margin = new Padding(6);
            Name = "AddIngredients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddIngredients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddIngredients;
        private ComboBox comboBoxSelectIng;
        private ComboBox comboBoxYear;
        private Label labelSelectIng;
        private Label labelOptionalDate;
        private Label labelYear;
        private Label labelMonth;
        private Label labelDay;
        private CheckBox checkBoxExpDates;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxDay;
        private Button buttonAddIng;
        private Label labelAddToInv;
        private Button buttonViewMyIngredients;
    }
}