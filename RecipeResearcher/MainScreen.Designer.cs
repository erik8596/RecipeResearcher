namespace FinalProjectGUI
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelWelcomeTo = new Label();
            labelRecipeResearcher = new Label();
            pictureBoxPie = new PictureBox();
            buttonLogin = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPie).BeginInit();
            SuspendLayout();
            // 
            // labelWelcomeTo
            // 
            labelWelcomeTo.AutoSize = true;
            labelWelcomeTo.Font = new Font("Segoe Print", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelWelcomeTo.Location = new Point(48, 90);
            labelWelcomeTo.Margin = new Padding(6, 0, 6, 0);
            labelWelcomeTo.Name = "labelWelcomeTo";
            labelWelcomeTo.Size = new Size(317, 85);
            labelWelcomeTo.TabIndex = 0;
            labelWelcomeTo.Text = "Welcome to";
            labelWelcomeTo.Click += label1_Click;
            // 
            // labelRecipeResearcher
            // 
            labelRecipeResearcher.AutoSize = true;
            labelRecipeResearcher.Font = new Font("Segoe Script", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRecipeResearcher.Location = new Point(138, 174);
            labelRecipeResearcher.Margin = new Padding(6, 0, 6, 0);
            labelRecipeResearcher.Name = "labelRecipeResearcher";
            labelRecipeResearcher.Size = new Size(778, 124);
            labelRecipeResearcher.TabIndex = 1;
            labelRecipeResearcher.Text = "Recipe Researcher";
            // 
            // pictureBoxPie
            // 
            pictureBoxPie.BackColor = Color.Transparent;
            pictureBoxPie.Image = Properties.Resources.apple_pie_small;
            pictureBoxPie.Location = new Point(985, 174);
            pictureBoxPie.Margin = new Padding(6);
            pictureBoxPie.Name = "pictureBoxPie";
            pictureBoxPie.Size = new Size(418, 447);
            pictureBoxPie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPie.TabIndex = 2;
            pictureBoxPie.TabStop = false;
            pictureBoxPie.Click += pictureBox1_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.LightCoral;
            buttonLogin.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(209, 619);
            buttonLogin.Margin = new Padding(6);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(552, 210);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "Let's Get Cookin'!";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 576);
            label1.Name = "label1";
            label1.Size = new Size(481, 37);
            label1.TabIndex = 9;
            label1.Text = "(Click the button below to get started!)";
            label1.Click += label1_Click_1;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1486, 960);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Controls.Add(labelRecipeResearcher);
            Controls.Add(pictureBoxPie);
            Controls.Add(labelWelcomeTo);
            Margin = new Padding(6);
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcomeTo;
        private Label labelRecipeResearcher;
        private PictureBox pictureBoxPie;
        private Button buttonLogin;
        private Label label1;
    }
}
