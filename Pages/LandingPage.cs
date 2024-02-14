using RecipeDatabase.Pages;

namespace RecipeDatabase
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Login(); 
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Login(); 
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
            this.Close(); 
        }

        private void aboutText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login()
        {
            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                login.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
                this.Dispose();
            }
            else
            {
                this.aboutText.Text = "Login failed. Please try again.";
                this.AboutLbl.Text = "Login failed. Please try again.";
            }
        }
    }
}
