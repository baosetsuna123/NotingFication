using Microsoft.Data.SqlClient;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Noting_Fication.Models;
using Microsoft.EntityFrameworkCore;

namespace Noting_Fication
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
            SetColors();
        }
        private void SetColors()
        {
            this.BackColor = Color.White; // Set the background color of the form
            btnLogin.BackColor = AppColors.Green; // Set the background color of a button
            btnLogin.ForeColor = Color.White; // Set the text color of a button
                                              // Set other colors for your form elements as needed
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        String ConnectionString = "server =LAPTOP-P1F3R3OG\\SQLEXPRESS; database= NotingFication; uid=sa;pwd=12345; TrustServerCertificate=True";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var pwd = txtPassword.Text;
            //Validate username input
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("You must enter your username to move on", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.BorderStyle = BorderStyle.FixedSingle;
                txtUsername.Focus();
                return;
            }
            else
            {
                txtUsername.BorderStyle = BorderStyle.None;
            }

            // Validate password input
            if (string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("You must enter your password to move on", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.BorderStyle = BorderStyle.FixedSingle;
                txtPassword.Focus();
                return;
            }
            else
            {
                txtUsername.BorderStyle = BorderStyle.None;
            }


            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT COUNT(*) FROM [User] WHERE Username = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", pwd);

                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();
                    connection.Close();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Success", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        // dang them 1
                        Form1 mainPage = new Form1(1);
                        mainPage.Show();
                    }
                    else
                    {
                        // Failed login
                        MessageBox.Show("Invalid username or password", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating the user: " + ex.Message);
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register rs = new Register();
            rs.Show();
            lblRegister.LinkVisited = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Create a rounded rectangle region
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

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var pwd = txtPassword.Text;
            //Validate username input
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("You must enter your username to move on", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.BorderStyle = BorderStyle.FixedSingle;
                txtUsername.Focus();
                return;
            }
            else
            {
                txtUsername.BorderStyle = BorderStyle.None;
            }

            // Validate password input
            if (string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("You must enter your password to move on", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.BorderStyle = BorderStyle.FixedSingle;
                txtPassword.Focus();
                return;
            }
            else
            {
                txtUsername.BorderStyle = BorderStyle.None;
            }

            using (var context = new NotingFication_2Context())
            {
                User u = context.Users.FirstOrDefault(x => x.Username == username && x.Password == pwd);
                if (u != null)
                {
                    this.Hide();

                    Form1 mainPage = new Form1(u.UserId);
                    mainPage.Show();
                }
                else
                    MessageBox.Show("Invalid username or password", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register rs = new Register();
            rs.Show();
            lblRegister.LinkVisited = true;
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            // Create a rounded rectangle region
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
    }
}
