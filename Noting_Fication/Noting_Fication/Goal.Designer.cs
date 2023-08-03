namespace Noting_Fication
{
    partial class Goal
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
            dTP_Deadline = new DateTimePicker();
            panel2 = new Panel();
            txtNote = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleGreen;
            label1.Location = new Point(130, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 45);
            label1.TabIndex = 0;
            label1.Text = "ⓈⒺⓉ ⒼⓄⒶⓁ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 72);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 1;
            label2.Text = "𝙳𝚎𝚊𝚍𝚕𝚒𝚗𝚎";
            // 
            // dTP_Deadline
            // 
            dTP_Deadline.Location = new Point(179, 73);
            dTP_Deadline.Margin = new Padding(3, 2, 3, 2);
            dTP_Deadline.Name = "dTP_Deadline";
            dTP_Deadline.Size = new Size(196, 23);
            dTP_Deadline.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtNote);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dTP_Deadline);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(10, 48);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 162);
            panel2.TabIndex = 3;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(179, 24);
            txtNote.Margin = new Padding(3, 2, 3, 2);
            txtNote.Name = "txtNote";
            txtNote.ReadOnly = true;
            txtNote.Size = new Size(252, 23);
            txtNote.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(89, 24);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 7;
            label3.Text = "𝙽𝚘𝚝𝚎";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(332, 230);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(62, 28);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(428, 230);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(69, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Goal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 268);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Goal";
            Text = "Goal";
            Load += Goal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private DateTimePicker dTP_Deadline;
        private Panel panel2;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtNote;
        private Label label3;
    }
}