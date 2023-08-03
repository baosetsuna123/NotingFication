namespace Noting_Fication
{
    partial class Categories
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
            flowLayoutPanel2 = new FlowLayoutPanel();
            Note_Categories = new ListView();
            notecategories_scroll = new VScrollBar();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            Categories_flowlayout = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Categories_scroll = new VScrollBar();
            listCate = new TreeView();
            btn_AddCat = new Button();
            btn_DeleteCat = new Button();
            btnExit = new Button();
            btnDeleteNote = new Button();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Categories_flowlayout.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel2.Controls.Add(Note_Categories);
            flowLayoutPanel2.Controls.Add(notecategories_scroll);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Location = new Point(318, 69);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(598, 319);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // Note_Categories
            // 
            Note_Categories.Location = new Point(3, 2);
            Note_Categories.Margin = new Padding(3, 2, 3, 2);
            Note_Categories.Name = "Note_Categories";
            Note_Categories.Size = new Size(567, 315);
            Note_Categories.TabIndex = 2;
            Note_Categories.UseCompatibleStateImageBehavior = false;
            Note_Categories.View = View.Details;
            Note_Categories.SelectedIndexChanged += listView1_SelectedIndexChanged;
            Note_Categories.MouseDoubleClick += Note_Categories_MouseDoubleClick;
            // 
            // notecategories_scroll
            // 
            notecategories_scroll.Cursor = Cursors.Hand;
            notecategories_scroll.Location = new Point(0, 319);
            notecategories_scroll.Name = "notecategories_scroll";
            notecategories_scroll.Size = new Size(26, 314);
            notecategories_scroll.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(29, 321);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(74, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 63);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(325, 6);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Location = new Point(-1, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(69, 452);
            panel2.TabIndex = 0;
            // 
            // Categories_flowlayout
            // 
            Categories_flowlayout.BackColor = Color.Teal;
            Categories_flowlayout.Controls.Add(label1);
            Categories_flowlayout.Location = new Point(3, 2);
            Categories_flowlayout.Margin = new Padding(3, 2, 3, 2);
            Categories_flowlayout.Name = "Categories_flowlayout";
            Categories_flowlayout.Size = new Size(237, 25);
            Categories_flowlayout.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleGreen;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 0;
            label1.Text = "𝙲𝚊𝚝𝚎𝚐𝚘𝚛𝚒𝚎𝚜";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(Categories_flowlayout);
            flowLayoutPanel1.Controls.Add(Categories_scroll);
            flowLayoutPanel1.Controls.Add(listCate);
            flowLayoutPanel1.Location = new Point(74, 69);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(240, 319);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Categories_scroll
            // 
            Categories_scroll.Cursor = Cursors.Hand;
            Categories_scroll.Location = new Point(0, 29);
            Categories_scroll.Name = "Categories_scroll";
            Categories_scroll.Size = new Size(26, 287);
            Categories_scroll.TabIndex = 2;
            Categories_scroll.TabStop = true;
            // 
            // listCate
            // 
            listCate.CheckBoxes = true;
            listCate.Location = new Point(29, 31);
            listCate.Margin = new Padding(3, 2, 3, 2);
            listCate.Name = "listCate";
            listCate.Size = new Size(202, 284);
            listCate.TabIndex = 3;
            listCate.AfterCheck += TreeView1_AfterCheck;
            listCate.AfterSelect += treeView1_AfterSelect;
            // 
            // btn_AddCat
            // 
            btn_AddCat.BackColor = Color.Transparent;
            btn_AddCat.Location = new Point(249, 389);
            btn_AddCat.Margin = new Padding(3, 2, 3, 2);
            btn_AddCat.Name = "btn_AddCat";
            btn_AddCat.Size = new Size(52, 22);
            btn_AddCat.TabIndex = 1;
            btn_AddCat.Text = "Add";
            btn_AddCat.TextAlign = ContentAlignment.TopCenter;
            btn_AddCat.UseVisualStyleBackColor = false;
            btn_AddCat.Click += btn_AddCat_Click;
            // 
            // btn_DeleteCat
            // 
            btn_DeleteCat.Location = new Point(186, 389);
            btn_DeleteCat.Margin = new Padding(3, 2, 3, 2);
            btn_DeleteCat.Name = "btn_DeleteCat";
            btn_DeleteCat.Size = new Size(59, 22);
            btn_DeleteCat.TabIndex = 2;
            btn_DeleteCat.Text = "Delete";
            btn_DeleteCat.UseVisualStyleBackColor = true;
            btn_DeleteCat.Click += btn_DeleteCat_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(851, 392);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(63, 22);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.Location = new Point(786, 392);
            btnDeleteNote.Margin = new Padding(3, 2, 3, 2);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(59, 22);
            btnDeleteNote.TabIndex = 5;
            btnDeleteNote.Text = "Delete";
            btnDeleteNote.UseVisualStyleBackColor = true;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 452);
            Controls.Add(btnDeleteNote);
            Controls.Add(btnExit);
            Controls.Add(btn_DeleteCat);
            Controls.Add(btn_AddCat);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Categories";
            Text = "Categories";
            Load += Categories_Load;
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Categories_flowlayout.ResumeLayout(false);
            Categories_flowlayout.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel Categories_flowlayout;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListView Note_Categories;
        private TreeView listCate;
        private VScrollBar Categories_scroll;
        private VScrollBar notecategories_scroll;
        private Button btn_AddCat;
        private Button btn_DeleteCat;
        private Button button1;
        private Button btnExit;
        private Button btnDeleteNote;
    }
}