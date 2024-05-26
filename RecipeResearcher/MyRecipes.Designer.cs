
namespace FinalProjectGUI
{
    partial class MyRecipes
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
            buttonGenerateRec = new Button();
            buttonViewOptionsMenu = new Button();
            label1 = new Label();
            listBoxMyRecipes = new ListBox();
            labelMyRecipes = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonGenerateRec
            // 
            buttonGenerateRec.BackColor = Color.LightCoral;
            buttonGenerateRec.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGenerateRec.Location = new Point(1118, 715);
            buttonGenerateRec.Margin = new Padding(6);
            buttonGenerateRec.Name = "buttonGenerateRec";
            buttonGenerateRec.Size = new Size(315, 201);
            buttonGenerateRec.TabIndex = 16;
            buttonGenerateRec.Text = "Generate New Recipes";
            buttonGenerateRec.UseVisualStyleBackColor = false;
            buttonGenerateRec.Click += buttonGenerateRec_Click;
            // 
            // buttonViewOptionsMenu
            // 
            buttonViewOptionsMenu.BackColor = Color.LightCoral;
            buttonViewOptionsMenu.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewOptionsMenu.Location = new Point(65, 715);
            buttonViewOptionsMenu.Margin = new Padding(6);
            buttonViewOptionsMenu.Name = "buttonViewOptionsMenu";
            buttonViewOptionsMenu.Size = new Size(310, 201);
            buttonViewOptionsMenu.TabIndex = 15;
            buttonViewOptionsMenu.Text = "Options Menu\r\n<--";
            buttonViewOptionsMenu.UseVisualStyleBackColor = false;
            buttonViewOptionsMenu.Click += buttonViewOptionsMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 218);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 13;
            // 
            // listBoxMyRecipes
            // 
            listBoxMyRecipes.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxMyRecipes.FormattingEnabled = true;
            listBoxMyRecipes.HorizontalScrollbar = true;
            listBoxMyRecipes.Location = new Point(65, 315);
            listBoxMyRecipes.Margin = new Padding(6);
            listBoxMyRecipes.Name = "listBoxMyRecipes";
            listBoxMyRecipes.Size = new Size(1368, 388);
            listBoxMyRecipes.TabIndex = 12;
            listBoxMyRecipes.DrawItem += ListBoxMyRecipes_DrawItem;
            // 
            // labelMyRecipes
            // 
            labelMyRecipes.AutoSize = true;
            labelMyRecipes.Font = new Font("Segoe Script", 22F, FontStyle.Bold);
            labelMyRecipes.Location = new Point(65, 79);
            labelMyRecipes.Margin = new Padding(6, 0, 6, 0);
            labelMyRecipes.Name = "labelMyRecipes";
            labelMyRecipes.Size = new Size(415, 98);
            labelMyRecipes.TabIndex = 11;
            labelMyRecipes.Text = "My Recipes:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.food;
            pictureBox2.Location = new Point(962, -64);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(454, 373);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(144, 269);
            label2.Name = "label2";
            label2.Size = new Size(753, 40);
            label2.TabIndex = 20;
            label2.Text = "(Ingredients in RED means they're not in your inventory)";
            // 
            // MyRecipes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1486, 960);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(buttonGenerateRec);
            Controls.Add(buttonViewOptionsMenu);
            Controls.Add(label1);
            Controls.Add(listBoxMyRecipes);
            Controls.Add(labelMyRecipes);
            Margin = new Padding(6);
            Name = "MyRecipes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyRecipes";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAddIng;
        private Button buttonGenerateRec;
        private Button buttonViewOptionsMenu;
        private Label label1;
        private ListBox listBoxMyRecipes;
        private Label labelMyRecipes;
        private PictureBox pictureBox2;
        private Label label2;
    }
}