namespace Noting_Fication
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            lblRegister = new LinkLabel();
            errorProvider = new ErrorProvider(components);
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(373, 256);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(373, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(373, 296);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(373, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ActiveCaption;
            btnLogin.Location = new Point(341, 337);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(265, 79);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 419);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 5;
            label3.Text = "Don't have an account? ";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Location = new Point(493, 419);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(112, 20);
            lblRegister.TabIndex = 7;
            lblRegister.TabStop = true;
            lblRegister.Text = "Sign up for free";
            lblRegister.LinkClicked += lblRegister_LinkClicked_1;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // richTextBox1
            // 
            richTextBox1.AcceptsTab = true;
            richTextBox1.BackColor = SystemColors.HighlightText;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(69, 224);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(139, 23);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "Enter username:";
            // 
            // richTextBox2
            // 
            richTextBox2.AcceptsTab = true;
            richTextBox2.BackColor = SystemColors.HighlightText;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox2.Location = new Point(69, 264);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox2.Size = new Size(194, 44);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "Enter password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(114, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 237);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(159, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(631, 421);
            panel1.TabIndex = 12;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1021, 560);
            Controls.Add(lblRegister);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load_1;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label3;
        private LinkLabel lblRegister;
        private ErrorProvider errorProvider;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}