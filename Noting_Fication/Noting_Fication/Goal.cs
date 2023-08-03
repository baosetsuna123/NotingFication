using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using Noting_Fication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Noting_Fication
{
    public partial class Goal : Form
    {
        public DateTime SelectedDeadline { get; private set; }
        String Noten;
        public Goal(string notename)
        {
            Noten = notename;
            InitializeComponent();
        }

        private void Goal_Load(object sender, EventArgs e)
        {
            //cmB_Status.Items.Add(new ComboBoxItem("In Progress", true));
            //cmB_Status.Items.Add(new ComboBoxItem("Not Started", false));
            //cmB_Status.Items.Add(new ComboBoxItem("Done", false));
            //cmB_Status.SelectedIndex = 0;
            txtNote.Text    =   Noten;
            this.Load += Goal_Load;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime dedline = dTP_Deadline.Value;
            using (var context = new NotingFication_2Context())
            {
                Note n = context.Notes.Where(n => n.Name == Noten).FirstOrDefault();
                n.Deadline = dedline;
                context.SaveChanges();
            }
            MessageBox.Show($"successfully.", "Delete Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public bool Status { get; set; }

        public ComboBoxItem(string text, bool status)
        {
            Text = text;
            Status = status;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
