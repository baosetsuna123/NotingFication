using Microsoft.EntityFrameworkCore;
using Noting_Fication;
using Noting_Fication.Models;
using Noting_Fication.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noting_Fication
{
    public partial class AddCategories : Form
    {
        private Categories categoriesForm;
        static int iduser;
        public AddCategories(int id)
        {
            iduser = id;
            InitializeComponent();

            //Wire();
        }
        //private void Wire()
        //{
        //    categoriesForm.txtNew = txtNew;
        //    btnADD.Click += btnAdd_Click_1;
        //}
        private void btnAdd_Click_1(object? sender, EventArgs e)
        {
           
        }

        private void btnADD_Click(object sender, EventArgs e)
        { 
            string newCategoryName = txtNew.Text.ToString();

            try
            {
                using (var context = new NotingFication_2Context())
                {
                    Category cat = new Category();
                    cat.CategoryName = newCategoryName;
                    context.Categories.Add(cat);
                    context.SaveChanges();
                }
                // Category added successfully
                MessageBox.Show("Category added successfully.");
                Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
    }
}

