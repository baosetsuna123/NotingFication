namespace Noting_Fication
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            btnRegister = new Button();
            txtRegisterName = new TextBox();
            txtRegisterPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtRegisterEmail = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            richTextBox4 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(185, 473);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(177, 74);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtRegisterName
            // 
            txtRegisterName.Location = new Point(338, 295);
            txtRegisterName.Name = "txtRegisterName";
            txtRegisterName.Size = new Size(125, 27);
            txtRegisterName.TabIndex = 6;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(338, 335);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(125, 27);
            txtRegisterPassword.TabIndex = 7;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(338, 377);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(125, 27);
            txtConfirmPassword.TabIndex = 8;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.Location = new Point(338, 420);
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.Size = new Size(125, 27);
            txtRegisterEmail.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(113, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 229);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(richTextBox4);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtRegisterEmail);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(txtRegisterPassword);
            panel1.Controls.Add(txtRegisterName);
            panel1.Location = new Point(180, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 598);
            panel1.TabIndex = 12;
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = SystemColors.HighlightText;
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox4.Location = new Point(224, 418);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox4.Size = new Size(70, 35);
            richTextBox4.TabIndex = 15;
            richTextBox4.Text = "Email :";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.HighlightText;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox3.Location = new Point(76, 377);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox3.Size = new Size(207, 35);
            richTextBox3.TabIndex = 14;
            richTextBox3.Text = "Confirm your password*:";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.HighlightText;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox2.Location = new Point(189, 336);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox2.Size = new Size(94, 35);
            richTextBox2.TabIndex = 13;
            richTextBox2.Text = "Password*:";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.HighlightText;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(185, 295);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(109, 35);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "Username*:";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(907, 618);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private TextBox txtRegisterName;
        private TextBox txtRegisterPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtRegisterEmail;
        private PictureBox pictureBox1;
        private Panel panel1;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
    }
}