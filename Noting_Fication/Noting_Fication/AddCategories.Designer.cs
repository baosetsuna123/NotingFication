namespace Noting_Fication
{
    partial class AddCategories
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtNew = new TextBox();
            btnADD = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 29);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleGreen;
            label1.Location = new Point(117, 7);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 0;
            label1.Text = "𝙰𝙳𝙳 𝙲𝙰𝚃𝙴𝙶𝙾𝚁𝚈";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 40);
            label2.Name = "label2";
            label2.Size = new Size(129, 19);
            label2.TabIndex = 1;
            label2.Text = "𝙽𝚊𝚖𝚎 𝚘𝚏 𝙲𝚊𝚝𝚎𝚐𝚘𝚛𝚢";
            // 
            // txtNew
            // 
            txtNew.Location = new Point(145, 37);
            txtNew.Margin = new Padding(3, 2, 3, 2);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(247, 23);
            txtNew.TabIndex = 2;
            // 
            // btnADD
            // 
            btnADD.Location = new Point(310, 62);
            btnADD.Margin = new Padding(3, 2, 3, 2);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(82, 22);
            btnADD.TabIndex = 3;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click;
            // 
            // AddCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 104);
            Controls.Add(btnADD);
            Controls.Add(txtNew);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCategories";
            Text = "AddCategories";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtNew;
        private Button btnADD;
    }
}