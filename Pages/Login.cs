using RecipeDatabase.Backend.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeDatabase.Pages
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void loginValidate_Click(object sender, EventArgs e)
        {
            User user = LoginHandler.ValidateLogin(this.UsernameInput.Text, this.passwordIn.Text);
            if (user != null && user.Role != Role.Guest)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error" + user.Username + user.Role, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
