namespace Noting_Fication
{
    partial class Form1
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
            sidebar = new FlowLayoutPanel();
            MenuContainer = new Panel();
            btnMenu = new Button();
            SearchContainer = new Panel();
            NewContainer = new Panel();
            btnGoals = new Button();
            TasksContainer = new Panel();
            btnNew = new Button();
            panel1 = new Panel();
            btnTags = new Button();
            panel3 = new Panel();
            btnList = new Button();
            panel2 = new Panel();
            sidebar.SuspendLayout();
            MenuContainer.SuspendLayout();
            NewContainer.SuspendLayout();
            TasksContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(MenuContainer);
            sidebar.Controls.Add(SearchContainer);
            sidebar.Controls.Add(NewContainer);
            sidebar.Controls.Add(TasksContainer);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel3);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(284, 681);
            sidebar.MinimumSize = new Size(57, 681);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(284, 681);
            sidebar.TabIndex = 0;
            // 
            // MenuContainer
            // 
            MenuContainer.Controls.Add(btnMenu);
            MenuContainer.Location = new Point(3, 3);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Size = new Size(281, 74);
            MenuContainer.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(0, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(275, 68);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // SearchContainer
            // 
            SearchContainer.Location = new Point(3, 83);
            SearchContainer.Name = "SearchContainer";
            SearchContainer.Size = new Size(281, 74);
            SearchContainer.TabIndex = 2;
            // 
            // NewContainer
            // 
            NewContainer.Controls.Add(btnGoals);
            NewContainer.Location = new Point(3, 163);
            NewContainer.Name = "NewContainer";
            NewContainer.Size = new Size(281, 52);
            NewContainer.TabIndex = 2;
            // 
            // btnGoals
            // 
            btnGoals.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoals.Location = new Point(3, 3);
            btnGoals.Name = "btnGoals";
            btnGoals.Size = new Size(278, 45);
            btnGoals.TabIndex = 0;
            btnGoals.Text = "Open";
            btnGoals.UseVisualStyleBackColor = true;
            btnGoals.Click += btnGoals_Click;
            // 
            // TasksContainer
            // 
            TasksContainer.Controls.Add(btnNew);
            TasksContainer.Location = new Point(3, 221);
            TasksContainer.Name = "TasksContainer";
            TasksContainer.Size = new Size(281, 52);
            TasksContainer.TabIndex = 3;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(278, 45);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTags);
            panel1.Location = new Point(3, 279);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 52);
            panel1.TabIndex = 5;
            // 
            // btnTags
            // 
            btnTags.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnTags.Location = new Point(3, 4);
            btnTags.Name = "btnTags";
            btnTags.Size = new Size(278, 45);
            btnTags.TabIndex = 0;
            btnTags.Text = "Bin";
            btnTags.UseVisualStyleBackColor = true;
            btnTags.Click += btnTags_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnList);
            panel3.Location = new Point(3, 337);
            panel3.Name = "panel3";
            panel3.Size = new Size(281, 52);
            panel3.TabIndex = 6;
            // 
            // btnList
            // 
            btnList.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnList.Location = new Point(3, 4);
            btnList.Name = "btnList";
            btnList.Size = new Size(278, 45);
            btnList.TabIndex = 0;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 40, 45);
            panel2.Location = new Point(290, 25);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 577);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 630);
            Controls.Add(panel2);
            Controls.Add(sidebar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            sidebar.ResumeLayout(false);
            MenuContainer.ResumeLayout(false);
            NewContainer.ResumeLayout(false);
            TasksContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel MenuContainer;
        private Panel SearchContainer;
        private Button btnMenu;
        private Panel NewContainer;
        private Button btnNew;
        private Panel TasksContainer;
        private Button btnTags;
        private Panel panel1;
        private Button btnList;
        private Panel panel2;
        private Panel panel3;
        private Button btnGoals;
    }
}