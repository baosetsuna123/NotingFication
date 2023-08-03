using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noting_Fication
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            SetColors();
        }

        private void SetColors()
        {
            this.BackColor = Color.White; // Set the background color of the form
            btnRegister.BackColor = AppColors.Green; // Set the background color of a button
            btnRegister.ForeColor = Color.White; // Set the text color of a button
                                                 // Set other colors for your form elements as needed
        }
        String ConnectionString = "server =LAPTOP-P1F3R3OG\\SQLEXPRESS; database= NotingFication_2; uid=sa;pwd=12345; TrustServerCertificate=True";

        // This function was born because I eam to lazy to add the auto incrementing into the User table
        private int GenerateNewUserID()
        {
            int newUserID = 1; // Start with a default value

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT MAX(UserID) FROM [User]";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    connection.Close();

                    if (result != null && result != DBNull.Value)
                    {
                        newUserID = Convert.ToInt32(result) + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating a new UserID: " + ex.Message);
            }

            return newUserID;
        }

        // Function to valid the correct email format
        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Use Regex.IsMatch to validate the email format
            return Regex.IsMatch(email, emailPattern);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegisterName.Text;
            string password = txtRegisterPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtRegisterEmail.Text;

            //1 Valid username
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please fill in your username", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegisterName.BorderStyle = BorderStyle.FixedSingle;
                return;
            }
            else
            {
                txtRegisterName.BorderStyle = BorderStyle.None;
            }

            //2 Valid Password
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please fill in your username", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegisterPassword.BorderStyle = BorderStyle.FixedSingle;
                return;
            }
            else
            {
                txtRegisterPassword.BorderStyle = BorderStyle.None;
            }

            //3 Valid confirmPassword
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please fill in your username", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
                return;
            }
            else
            {
                txtConfirmPassword.BorderStyle = BorderStyle.None;
            }
            // Check if password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the email is in correct format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address( ex: abc@gmail.com).", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "INSERT INTO [User](UserName, Password, Email) VALUES (@Username, @Password, @Email)";
                    SqlCommand command = new SqlCommand(query, connection);
                    /*command.Parameters.AddWithValue("@UserID", GenerateNewUserID());*/
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Login login = new Login();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
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
