using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Noting_Fication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noting_Fication
{
    public partial class CreateNote : Form
    {
        static int iduser;
        static String filepath;
        public CreateNote(int id)
        {
            iduser = id;
            InitializeComponent();
            SetColors();
        }
        private void SetColors()
        {
            this.BackColor = AppColors.Lime; // Set the background color of the form
            button1.BackColor = AppColors.Green; // Set the background color of a button
            button1.ForeColor = Color.White; // Set the text color of a button
            panel1.BackColor = Color.White;

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void showedit()
        {
            EditForm form3 = new EditForm(iduser, filepath);
            form3.TopLevel = false;
            form3.TopMost = true;
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            Panel panel1 = (Panel)form1.Controls["panel2"];
            panel1.Controls.Clear();
            panel1.Controls.Add(form3);
            form3.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = comboBox1.Text;
            int id = 0;
            using (var context = new NotingFication_2Context())
            {
                Category c1 = context.Categories.FirstOrDefault(x => x.CategoryName == text);
                if (c1 == null)
                {
                    Category c2 = new Category();
                    c2.CategoryName = text;
                    context.Categories.Add(c2);
                    context.SaveChanges();
                    id = c2.CategoryId;
                }
                else
                {
                    id = c1.CategoryId;
                }
            }
            Note n = new Note();
            n.Name = textBox1.Text;
            n.CategoryId = id;
            n.UserId = iduser;
            n.CreateDate = DateTime.Now;
            n.Status = true;
            n.Deadline = dateTimePicker1.Value;
            n.Content = $@"..\..\save\{n.Name}.rtf";
            string filename = $"{n.Name}.rtf";
            string folderPath = $@"..\..\save\";

            Directory.CreateDirectory(folderPath);

            filepath = Path.Combine(folderPath, filename);
            int counter = 1;

            while (File.Exists(filepath))
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filename);
                string fileExtension = Path.GetExtension(filename);
                string newFileName = $"{fileNameWithoutExtension} ({counter}){fileExtension}";
                filepath = Path.Combine(folderPath, newFileName);
                counter++;
            }
            if (n.Name == "" || n.Content == "")
            {
                MessageBox.Show("Ban can nhap day du thong tin");
            }
            else
            {
                try
                {
                    using (var context = new NotingFication_2Context())
                    {
                        context.Notes.Add(n);
                        context.SaveChanges();
                    }
                    using (File.Create(filepath))
                    {
                        // File is created with no content
                    }
                    MessageBox.Show("Add thanh cong Note!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            textBox1.Text = String.Empty;

            showedit();
        }

        private void CreateNote_Load_1(object sender, EventArgs e)
        {
            using (var context = new NotingFication_2Context())
            {
                List<Category> list = context.Categories.ToList();
                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "CategoryId";
                comboBox1.DataSource = list;
            }
            int cornerRadius = 10;
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddArc(panel1.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddArc(panel1.Width - cornerRadius * 2, panel1.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddArc(0, panel1.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.CloseFigure();

            // Set the rounded rectangle region to the Panel control
            panel1.Region = new Region(roundedRect);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

    }
}
