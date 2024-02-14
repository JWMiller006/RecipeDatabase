namespace RecipeDatabase
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            menu = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            closeApplicationToolStripMenuItem = new ToolStripMenuItem();
            aboutText = new RichTextBox();
            loginButton = new Button();
            AboutLbl = new Label();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, closeApplicationToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(450, 24);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // closeApplicationToolStripMenuItem
            // 
            closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            closeApplicationToolStripMenuItem.Size = new Size(112, 20);
            closeApplicationToolStripMenuItem.Text = "Close Application";
            closeApplicationToolStripMenuItem.Click += closeApplicationToolStripMenuItem_Click;
            // 
            // aboutText
            // 
            aboutText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aboutText.BackColor = Color.SteelBlue;
            aboutText.BorderStyle = BorderStyle.None;
            aboutText.Location = new Point(104, 142);
            aboutText.Name = "aboutText";
            aboutText.ReadOnly = true;
            aboutText.Size = new Size(237, 140);
            aboutText.TabIndex = 1;
            aboutText.Text = "This application is a recipe database where a user can login and view their recipes along with those that are shared with them. To get started, login or create an account";
            aboutText.TextChanged += aboutText_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Bottom;
            loginButton.BackColor = Color.SteelBlue;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(177, 313);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(91, 37);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // AboutLbl
            // 
            AboutLbl.AutoSize = true;
            AboutLbl.ForeColor = Color.White;
            AboutLbl.Location = new Point(195, 109);
            AboutLbl.Name = "AboutLbl";
            AboutLbl.Size = new Size(40, 15);
            AboutLbl.TabIndex = 3;
            AboutLbl.Text = "About";
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(450, 450);
            Controls.Add(AboutLbl);
            Controls.Add(loginButton);
            Controls.Add(aboutText);
            Controls.Add(menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Name = "LandingPage";
            Text = "Landing Page";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem closeApplicationToolStripMenuItem;
        private RichTextBox aboutText;
        private Button loginButton;
        private Label AboutLbl;
    }
}
