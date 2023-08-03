namespace Noting_Fication
{
    partial class List
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            listNote = new ListView();
            panel1 = new Panel();
            btnDelete = new Button();
            btnExit = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(261, 46);
            label1.TabIndex = 0;
            label1.Text = "ⒶⓁⓁ ⓃⓄⓉⒺⓈ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(listNote);
            flowLayoutPanel1.Location = new Point(12, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(696, 380);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // listNote
            // 
            listNote.Location = new Point(3, 3);
            listNote.Name = "listNote";
            listNote.Size = new Size(690, 377);
            listNote.TabIndex = 0;
            listNote.UseCompatibleStateImageBehavior = false;
            listNote.SelectedIndexChanged += listNote_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnDelete);
            panel1.Location = new Point(714, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(74, 380);
            panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(71, 29);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(0, 35);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(74, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // List
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "List";
            Text = "List";
            Load += List_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListView listNote;
        private Panel panel1;
        private Button btnDelete;
        private Button btnExit;
    }
}