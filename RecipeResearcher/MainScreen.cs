using System.Reflection;

namespace FinalProjectGUI
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            CheckEmbeddedResources();
            this.FormClosed += Form_Closed;
        }
        private void CheckEmbeddedResources()
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine("Available resources:");
            foreach (var res in assembly.GetManifestResourceNames())
            {
                Console.WriteLine(res);
            }
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Open the SelectOption form
            SelectOption selectOption = new SelectOption();
            selectOption.Show();
            //Hide the current form
            this.Hide();
        }
    }
}
