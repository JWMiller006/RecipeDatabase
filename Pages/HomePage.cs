using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeDatabase.Pages
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.OK;
            this.currentUser.Text = "Current User: " + Backend.AppData.CurrentUser.Username;
            if (Backend.AppData.CurrentUser.Role == Backend.Controls.Role.Admin)
            {
                this.currentUser.Text += " (Admin Mode)";
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
            this.Close(); 
        }
    }
}
