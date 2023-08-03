using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Noting_Fication.Models;
using Noting_Fication.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Noting_Fication
{
    public partial class Categories : Form
    {
        private NotingFication_2Context dbContext;
        public Userservice _userservice;
        public CateService _cateService;
        public NoteService _noteService;
        static int iduser;
        public TextBox? txtNew { get; set; }

        public Categories(int id)
        {
            iduser = id;
            InitializeComponent();
            dbContext = new NotingFication_2Context();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            LoadCategories();
            btn_AddCat.Enabled = true;
            btn_DeleteCat.Enabled = true;
        }
        private TreeNode selectedCategoryNode;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Tag != null)
            {
                int categoryId = (int)e.Node.Tag;
                List<Note> notes = dbContext.Notes.Where(n => n.CategoryId == categoryId && n.Status== true).ToList();

                SetupListViewColumns();
                DisplayNotes(notes);
            }
        }
        private void TreeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                selectedCategoryNode = e.Node;
            }
            else
            {
                selectedCategoryNode = null;
            }
        }

        private void DisplayNotes(List<Note> notes)
        {

            Note_Categories.Items.Clear();

            foreach (Note note in notes)
            {
                ListViewItem listItem = new ListViewItem(note.Name);

                listItem.SubItems.Add(note.Deadline.ToString());
                listItem.SubItems.Add(note.CreateDate.ToString());

                Note_Categories.Items.Add(listItem);
            }
        }
        private void SetupListViewColumns()
        {
            Note_Categories.Columns.Clear();

            Note_Categories.Columns.Add("NoteName");

            Note_Categories.Columns.Add("Deadline");

            Note_Categories.Columns.Add("CreateDate");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Note_Categories.SelectedItems.Count > 0)
            //{
            //    String selectNote = Note_Categories.SelectedItems[0].Text;
            //    if (Note_Categories.SelectedItems.Count > 0)
            //    {
            //        if (Note_Categories.SelectedItems.Count > 0)
            //        {
            //            ListViewItem selectedItem = Note_Categories.SelectedItems[0];
            //            string noteName = selectedItem.SubItems[0].Text;
            //            string deadline = selectedItem.SubItems[1].Text;
            //            string createDate = selectedItem.SubItems[2].Text;

            //            // Find the Note object in the data source (noteList) that matches the selected item's information
            //            using (var dbContext = new NotingFication_2Context())
            //            {
            //                Note selectedNote = dbContext.Notes.FirstOrDefault(note => note.Name == noteName && note.Deadline.ToString() == deadline && note.CreateDate.ToString() == createDate);
            //                selectedNote.Status = false;
            //            }

            //        }

            //    }

            //}
        }

        //====================================================================================//
        //private AddCategories addForm;
        private void btn_AddCat_Click(object sender, EventArgs e)
        {
            AddCategories addForm = new AddCategories(iduser);
            //Categories categoriesForm = new Categories(iduser);     
            addForm.Show();
            LoadCategories();
            btn_AddCat.Enabled = true;
            btn_DeleteCat.Enabled = true;
        }

        public void AddCategoryToListCate(string categoryName)
        {
            Category caat = new Category();
            caat.CategoryName = categoryName;
            var cat = _cateService.GetAll().FirstOrDefault();
            if (cat == null)
            {
                dbContext.Categories.Add(caat);
                TreeNode categoryNode = new TreeNode(categoryName);
                categoryNode.Tag = categoryName;
            }
            else
            {
                MessageBox.Show("Category is already existed!", "Delete task", MessageBoxButtons.OK);
            }

        }

        //===================================================================================//

        private void btn_DeleteCat_Click(object sender, EventArgs e)
        {
            if (selectedCategoryNode != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string categoryName = selectedCategoryNode.Text;

                    using (var dbContext = new NotingFication_2Context())
                    {
                        Category categoryToDelete = dbContext.Categories.FirstOrDefault(c => c.CategoryName == categoryName);
                        if (categoryToDelete != null)
                        {
                            List<Note> notesToDelete = dbContext.Notes.Where(n => n.CategoryId == categoryToDelete.CategoryId).ToList();
                            dbContext.Notes.RemoveRange(notesToDelete);
                            dbContext.Categories.Remove(categoryToDelete);
                            dbContext.SaveChanges();

                        }
                    }
                    selectedCategoryNode.Remove();
                    selectedCategoryNode = null;
                    MessageBox.Show("delete successfully.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select to delete.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void afterSelectCategory(object sender, EventArgs e)
        {
            btn_DeleteCat.Enabled = (listCate.SelectedNode != null);
        }

        //===============================================================================//
        private void LoadCategories()
        {
            List<Category> categories = dbContext.Categories.ToList();

            listCate.Nodes.Clear();

            foreach (Category category in categories)
            {
                TreeNode node = new TreeNode(category.CategoryName);
                node.Tag = category.CategoryId;
                listCate.Nodes.Add(node);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string filepath;
        private void Note_Categories_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitTest = Note_Categories.HitTest(e.Location);
            if (Note_Categories.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Note_Categories.SelectedItems[0];
                string nodeName = selectedItem.SubItems[0].Text;

                using (var context = new NotingFication_2Context())
                {
                    var notd = context.Notes.Where(n => n.Name == nodeName).FirstOrDefault();
                    filepath = notd.Content;
                }
                showedit();
            }
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

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            if (Note_Categories.SelectedItems.Count > 0)
            {
                // Get the selected ListViewItem
                ListViewItem selectedItem = Note_Categories.SelectedItems[0];

                // Get the note name from the first sub-item (column 0)
                string noteName = selectedItem.SubItems[0].Text;

                // Find the note object in the data source (noteList) based on the note name
                using (var dbContext = new NotingFication_2Context())
                {
                    Note noteToDelete = dbContext.Notes.FirstOrDefault(note => note.Name == noteName);
                    if (noteToDelete != null)
                    {
                        // Remove the note from the data source (noteList)
                        //Note_Categories.Remove(noteToDelete);
                        noteToDelete.Status = false;
                        dbContext.SaveChanges();
                        // Remove the selected ListViewItem from the ListView
                        Note_Categories.Items.Remove(selectedItem);

                        MessageBox.Show($"Note '{noteName}' has been deleted successfully.", "Delete Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }               
            }
            else
            {
                MessageBox.Show("Please select a note to delete.", "Delete Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //===================================================================================

    }
}
