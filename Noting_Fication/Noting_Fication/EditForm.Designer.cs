using System.Windows.Forms;

namespace Noting_Fication
{
    partial class EditForm
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
            rtxbContent = new RichTextBox();
            btBold = new Button();
            btNormal = new Button();
            btItalic = new Button();
            numericUpDown1 = new NumericUpDown();
            btUnderline = new Button();
            cbFont = new ComboBox();
            btnUndo = new Button();
            btnRedo = new Button();
            btnBlack = new Button();
            btnWhite = new Button();
            btnYellow_Green = new Button();
            BtnRed = new Button();
            btnGreen = new Button();
            btnRed_Orange = new Button();
            btnBlue_Green = new Button();
            btnOrange = new Button();
            btnBlue = new Button();
            btnYellow_Orange = new Button();
            btnBlue_Violet = new Button();
            btnYellow = new Button();
            panel1 = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cbHighlight = new ComboBox();
            btnHighlight = new Button();
            btnBullet = new Button();
            btnSave = new Button();
            btnSetgoal = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rtxbContent
            // 
            rtxbContent.AcceptsTab = true;
            rtxbContent.Location = new Point(10, 64);
            rtxbContent.Margin = new Padding(3, 2, 3, 2);
            rtxbContent.Name = "rtxbContent";
            rtxbContent.Size = new Size(924, 356);
            rtxbContent.TabIndex = 0;
            rtxbContent.Text = "";
            rtxbContent.TextChanged += richTextBox1_TextChanged;
            // 
            // btBold
            // 
            btBold.Location = new Point(253, 19);
            btBold.Margin = new Padding(3, 2, 3, 2);
            btBold.Name = "btBold";
            btBold.Size = new Size(29, 22);
            btBold.TabIndex = 1;
            btBold.Text = "B";
            btBold.UseVisualStyleBackColor = true;
            btBold.Click += btBold_Click;
            // 
            // btNormal
            // 
            btNormal.Location = new Point(355, 19);
            btNormal.Margin = new Padding(3, 2, 3, 2);
            btNormal.Name = "btNormal";
            btNormal.Size = new Size(29, 22);
            btNormal.TabIndex = 3;
            btNormal.Text = "N";
            btNormal.UseVisualStyleBackColor = true;
            btNormal.Click += btNormal_Click;
            // 
            // btItalic
            // 
            btItalic.Location = new Point(287, 19);
            btItalic.Margin = new Padding(3, 2, 3, 2);
            btItalic.Name = "btItalic";
            btItalic.Size = new Size(29, 22);
            btItalic.TabIndex = 4;
            btItalic.Text = "I";
            btItalic.UseVisualStyleBackColor = true;
            btItalic.Click += btItalic_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(177, 6);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(42, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btUnderline
            // 
            btUnderline.Location = new Point(321, 19);
            btUnderline.Margin = new Padding(3, 2, 3, 2);
            btUnderline.Name = "btUnderline";
            btUnderline.Size = new Size(29, 22);
            btUnderline.TabIndex = 6;
            btUnderline.Text = "U";
            btUnderline.UseVisualStyleBackColor = true;
            btUnderline.Click += btUnderline_Click;
            // 
            // cbFont
            // 
            cbFont.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbFont.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFont.FormattingEnabled = true;
            cbFont.Items.AddRange(new object[] { "Arial", "Avenir", "Baskerville", "Bodoni", "Book Antiqua", "Bookman Old Style", "Brush Script MT", "Calibri", "Calibri", "Cambria", "Candara", "Century Gothic", "Century Schoolbook", "Clarendon", "Comic Sans MS", "Consolas", "Copperplate Gothic", "Courier", "Courier New", "Didot", "Edwardian Script ITC", "Engravers MT", "Eurostile", "Felix Titling", "Forte", "Franklin Gothic", "Franklin Gothic Medium", "Frutiger", "Futura", "Garamond", "Georgia", "Gill Sans", "Gill Sans", "Gotham", "Gotham", "Goudy Stout", "Helvetica", "Impact", "Impact", "ITC Avant Garde Gothic", "Lucida Console", "Lucida Handwriting", "Lucida Handwriting", "Magneto", "Marlett", "Microsoft Sans Serif", "Monotype Corsiva", "Myriad", "Myriad Pro", "Neutraface", "Optima", "Palatino Linotype", "Proxima Nova", "Rockwell", "Segoe Print", "Segoe Script", "Segoe UI", "Symbol", "Tahoma", "Times New Roman", "Times New Roman", "Trade Gothic", "Trebuchet MS", "Univers", "Verdana", "Verdana", "Webdings", "Wingdings", "Wingdings 2", "Wingdings 3" });
            cbFont.Location = new Point(24, 6);
            cbFont.Margin = new Padding(3, 2, 3, 2);
            cbFont.Name = "cbFont";
            cbFont.Size = new Size(133, 23);
            cbFont.Sorted = true;
            cbFont.TabIndex = 7;
            cbFont.Text = "Times New Romen";
            cbFont.SelectedIndexChanged += cbFont_SelectedIndexChanged;
            // 
            // btnUndo
            // 
            btnUndo.Image = Properties.Resources.undo1;
            btnUndo.Location = new Point(404, 15);
            btnUndo.Margin = new Padding(3, 2, 3, 2);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(34, 29);
            btnUndo.TabIndex = 8;
            btnUndo.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.Image = Properties.Resources.redo;
            btnRedo.Location = new Point(452, 15);
            btnRedo.Margin = new Padding(3, 2, 3, 2);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(34, 29);
            btnRedo.TabIndex = 9;
            btnRedo.UseVisualStyleBackColor = true;
            btnRedo.Click += btnRedo_Click;
            // 
            // btnBlack
            // 
            btnBlack.BackColor = Color.Black;
            btnBlack.FlatStyle = FlatStyle.Flat;
            btnBlack.Location = new Point(19, 3);
            btnBlack.Margin = new Padding(0);
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new Size(18, 16);
            btnBlack.TabIndex = 10;
            btnBlack.UseVisualStyleBackColor = true;
            btnBlack.Click += btnBlack_Click;
            // 
            // btnWhite
            // 
            btnWhite.Location = new Point(19, 32);
            btnWhite.Margin = new Padding(0);
            btnWhite.Name = "btnWhite";
            btnWhite.Size = new Size(18, 16);
            btnWhite.TabIndex = 11;
            btnWhite.UseVisualStyleBackColor = true;
            btnWhite.Click += btnWhite_Click;
            // 
            // btnYellow_Green
            // 
            btnYellow_Green.BackColor = Color.YellowGreen;
            btnYellow_Green.FlatStyle = FlatStyle.Flat;
            btnYellow_Green.Location = new Point(53, 32);
            btnYellow_Green.Margin = new Padding(0);
            btnYellow_Green.Name = "btnYellow_Green";
            btnYellow_Green.Size = new Size(18, 16);
            btnYellow_Green.TabIndex = 13;
            btnYellow_Green.UseVisualStyleBackColor = true;
            btnYellow_Green.Click += btnYellow_Green_Click;
            // 
            // BtnRed
            // 
            BtnRed.BackColor = Color.Red;
            BtnRed.FlatStyle = FlatStyle.Flat;
            BtnRed.Location = new Point(53, 3);
            BtnRed.Margin = new Padding(0);
            BtnRed.Name = "BtnRed";
            BtnRed.Size = new Size(18, 16);
            BtnRed.TabIndex = 12;
            BtnRed.UseVisualStyleBackColor = false;
            BtnRed.Click += BtnRed_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Green;
            btnGreen.FlatStyle = FlatStyle.Flat;
            btnGreen.Location = new Point(90, 32);
            btnGreen.Margin = new Padding(0);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(18, 16);
            btnGreen.TabIndex = 15;
            btnGreen.UseVisualStyleBackColor = true;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnRed_Orange
            // 
            btnRed_Orange.BackColor = Color.OrangeRed;
            btnRed_Orange.FlatStyle = FlatStyle.Flat;
            btnRed_Orange.Location = new Point(90, 3);
            btnRed_Orange.Margin = new Padding(0);
            btnRed_Orange.Name = "btnRed_Orange";
            btnRed_Orange.Size = new Size(18, 16);
            btnRed_Orange.TabIndex = 14;
            btnRed_Orange.UseVisualStyleBackColor = true;
            btnRed_Orange.Click += btnRed_Orange_Click;
            // 
            // btnBlue_Green
            // 
            btnBlue_Green.BackColor = Color.FromArgb(13, 152, 186);
            btnBlue_Green.FlatStyle = FlatStyle.Flat;
            btnBlue_Green.Location = new Point(128, 32);
            btnBlue_Green.Margin = new Padding(0);
            btnBlue_Green.Name = "btnBlue_Green";
            btnBlue_Green.Size = new Size(18, 16);
            btnBlue_Green.TabIndex = 17;
            btnBlue_Green.UseVisualStyleBackColor = true;
            btnBlue_Green.Click += btnBlue_Green_Click;
            // 
            // btnOrange
            // 
            btnOrange.BackColor = Color.Orange;
            btnOrange.FlatStyle = FlatStyle.Flat;
            btnOrange.Location = new Point(128, 3);
            btnOrange.Margin = new Padding(0);
            btnOrange.Name = "btnOrange";
            btnOrange.Size = new Size(18, 16);
            btnOrange.TabIndex = 16;
            btnOrange.UseVisualStyleBackColor = true;
            btnOrange.Click += btnOrange_Click;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Blue;
            btnBlue.FlatStyle = FlatStyle.Flat;
            btnBlue.Location = new Point(165, 32);
            btnBlue.Margin = new Padding(0);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(18, 16);
            btnBlue.TabIndex = 19;
            btnBlue.UseVisualStyleBackColor = true;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnYellow_Orange
            // 
            btnYellow_Orange.BackColor = Color.FromArgb(255, 174, 66);
            btnYellow_Orange.FlatStyle = FlatStyle.Flat;
            btnYellow_Orange.Location = new Point(165, 3);
            btnYellow_Orange.Margin = new Padding(0);
            btnYellow_Orange.Name = "btnYellow_Orange";
            btnYellow_Orange.Size = new Size(18, 16);
            btnYellow_Orange.TabIndex = 18;
            btnYellow_Orange.UseVisualStyleBackColor = true;
            btnYellow_Orange.Click += btnYellow_Orange_Click;
            // 
            // btnBlue_Violet
            // 
            btnBlue_Violet.BackColor = Color.BlueViolet;
            btnBlue_Violet.FlatStyle = FlatStyle.Flat;
            btnBlue_Violet.Location = new Point(206, 32);
            btnBlue_Violet.Margin = new Padding(0);
            btnBlue_Violet.Name = "btnBlue_Violet";
            btnBlue_Violet.Size = new Size(18, 16);
            btnBlue_Violet.TabIndex = 21;
            btnBlue_Violet.UseVisualStyleBackColor = true;
            btnBlue_Violet.Click += button1_Click;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Yellow;
            btnYellow.FlatStyle = FlatStyle.Flat;
            btnYellow.Location = new Point(206, 3);
            btnYellow.Margin = new Padding(0);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(18, 16);
            btnYellow.TabIndex = 20;
            btnYellow.UseVisualStyleBackColor = true;
            btnYellow.Click += btnYellow_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnYellow_Green);
            panel1.Controls.Add(btnBlue_Violet);
            panel1.Controls.Add(btnBlack);
            panel1.Controls.Add(btnYellow);
            panel1.Controls.Add(btnWhite);
            panel1.Controls.Add(btnBlue);
            panel1.Controls.Add(BtnRed);
            panel1.Controls.Add(btnYellow_Orange);
            panel1.Controls.Add(btnRed_Orange);
            panel1.Controls.Add(btnBlue_Green);
            panel1.Controls.Add(btnGreen);
            panel1.Controls.Add(btnOrange);
            panel1.Location = new Point(578, 4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 55);
            panel1.TabIndex = 22;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cbHighlight
            // 
            cbHighlight.FormattingEnabled = true;
            cbHighlight.Location = new Point(529, 20);
            cbHighlight.Margin = new Padding(3, 2, 3, 2);
            cbHighlight.Name = "cbHighlight";
            cbHighlight.Size = new Size(41, 23);
            cbHighlight.TabIndex = 25;
            cbHighlight.DrawItem += comboBoxColors_DrawItem;
            // 
            // btnHighlight
            // 
            btnHighlight.Image = Properties.Resources.highlight;
            btnHighlight.Location = new Point(492, 13);
            btnHighlight.Margin = new Padding(3, 2, 3, 2);
            btnHighlight.Name = "btnHighlight";
            btnHighlight.Size = new Size(32, 33);
            btnHighlight.TabIndex = 26;
            btnHighlight.UseVisualStyleBackColor = true;
            btnHighlight.Click += btnHighlight_Click;
            // 
            // btnBullet
            // 
            btnBullet.Image = Properties.Resources.bulleted;
            btnBullet.Location = new Point(832, 19);
            btnBullet.Margin = new Padding(3, 2, 3, 2);
            btnBullet.Name = "btnBullet";
            btnBullet.Size = new Size(41, 30);
            btnBullet.TabIndex = 27;
            btnBullet.UseVisualStyleBackColor = true;
            btnBullet.Click += btnBullet_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(883, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(51, 38);
            btnSave.TabIndex = 28;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSetgoal
            // 
            btnSetgoal.Location = new Point(52, 36);
            btnSetgoal.Name = "btnSetgoal";
            btnSetgoal.Size = new Size(75, 23);
            btnSetgoal.TabIndex = 29;
            btnSetgoal.Text = "Set Goals";
            btnSetgoal.UseVisualStyleBackColor = true;
            btnSetgoal.Click += btnSetgoal_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 45);
            ClientSize = new Size(943, 435);
            Controls.Add(btnSetgoal);
            Controls.Add(btnSave);
            Controls.Add(btnBullet);
            Controls.Add(btnHighlight);
            Controls.Add(cbHighlight);
            Controls.Add(panel1);
            Controls.Add(btnRedo);
            Controls.Add(btnUndo);
            Controls.Add(cbFont);
            Controls.Add(btUnderline);
            Controls.Add(numericUpDown1);
            Controls.Add(btItalic);
            Controls.Add(btNormal);
            Controls.Add(btBold);
            Controls.Add(rtxbContent);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtxbContent;
        private Button btBold;
        private Button btNormal;
        private Button btItalic;
        private NumericUpDown numericUpDown1;
        private Button btUnderline;
        private ComboBox cbFont;
        private Button btnUndo;
        private Button btnRedo;
        private Button btnBlack;
        private Button btnWhite;
        private Button btnYellow_Green;
        private Button BtnRed;
        private Button btnGreen;
        private Button btnRed_Orange;
        private Button btnBlue_Green;
        private Button btnOrange;
        private Button btnBlue;
        private Button btnYellow_Orange;
        private Button btn;
        private Button btnYellow;
        private Button btnBlue_Violet;
        private Panel panel1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cbHighlight;
        private Button btnHighlight;
        private Button btnBullet;
        private Button btnSave;
        private Button btnSetgoal;
    }
}