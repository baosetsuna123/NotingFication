namespace Noting_Fication
{
    partial class CreateNote
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
            lblTitle = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(3, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 16);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            lblTitle.Click += lblTitle_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 19);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 55);
            label3.Name = "label3";
            label3.Size = new Size(73, 16);
            label3.TabIndex = 5;
            label3.Text = "Category:";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 15;
            comboBox1.Location = new Point(148, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 108);
            label4.Name = "label4";
            label4.Size = new Size(106, 16);
            label4.TabIndex = 7;
            label4.Text = "Date(optional):";
            label4.Click += label4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(148, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(329, 20);
            dateTimePicker1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(121, 154);
            button1.Name = "button1";
            button1.Size = new Size(218, 54);
            button1.TabIndex = 9;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 215);
            panel1.TabIndex = 11;
            // 
            // CreateNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(486, 216);
            Controls.Add(panel1);
            Name = "CreateNote";
            Text = "CreateNote";
            Load += CreateNote_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Panel panel1;
    }
}