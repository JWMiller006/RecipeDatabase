namespace RecipeDatabase.Pages
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            UsernameInput = new TextBox();
            usernameLbl = new Label();
            label1 = new Label();
            passwordIn = new TextBox();
            loginValidate = new Button();
            SuspendLayout();
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(58, 130);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(345, 23);
            UsernameInput.TabIndex = 0;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.ForeColor = Color.White;
            usernameLbl.Location = new Point(188, 104);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(90, 15);
            usernameLbl.TabIndex = 1;
            usernameLbl.Text = "Enter Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(180, 218);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter Password";
            // 
            // passwordIn
            // 
            passwordIn.Location = new Point(58, 245);
            passwordIn.Name = "passwordIn";
            passwordIn.PasswordChar = '*';
            passwordIn.Size = new Size(345, 23);
            passwordIn.TabIndex = 3;
            // 
            // loginValidate
            // 
            loginValidate.Location = new Point(169, 325);
            loginValidate.Name = "loginValidate";
            loginValidate.Size = new Size(98, 32);
            loginValidate.TabIndex = 4;
            loginValidate.Text = "Login";
            loginValidate.UseVisualStyleBackColor = true;
            loginValidate.Click += loginValidate_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(450, 450);
            Controls.Add(loginValidate);
            Controls.Add(passwordIn);
            Controls.Add(label1);
            Controls.Add(usernameLbl);
            Controls.Add(UsernameInput);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(450, 450);
            MinimumSize = new Size(450, 450);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameInput;
        private Label usernameLbl;
        private Label label1;
        private TextBox passwordIn;
        private Button loginValidate;
    }
}