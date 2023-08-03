using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Noting_Fication
{
    public partial class Form1 : Form
    {
        static int iduser;
        static string filePath;
        public Form1(int id)
        {
            iduser = id;
            InitializeComponent();
        }

        public Form1()
        {
            InitializeComponent();
        }
        public void show(Form frm)
        {
            panel2.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.AutoScroll = true;
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            Bins form = new Bins(iduser);
            show(form);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            CreateNote form = new CreateNote(iduser);
            show(form);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories(iduser);
            show(categories);
        }

        public void LoadMyFile()
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.           
                filePath = openFile1.FileName;
                EditForm edit = new EditForm(iduser, filePath);
                show(edit);
                EditForm form1 = (EditForm)Application.OpenForms["EditForm"];
                RichTextBox rtxbox = (RichTextBox)form1.Controls["rtxbContent"];
                rtxbox.LoadFile(openFile1.FileName);
            }
        }
        private void btnGoals_Click(object sender, EventArgs e)
        {
            LoadMyFile();
        }
    }
}