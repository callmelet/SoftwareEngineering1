using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    public partial class AdminRegistrationForm : Form
    {
        private bool isAdminRegistered = false; // Flag to track admin registration status
        private string connectionString = "Data Source=BOOK-5A3M5LR9FE\\SQLEXPRESS;Initial Catalog=VendorApplication;Integrated Security=True";
        public AdminRegistrationForm()
        {
            InitializeComponent();
        }

        private void AdminRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1register_admin_Click(object sender, EventArgs e)
        {

            string adminUsername = textBox1username.Text;
            string adminPassword = textBox1_password.Text;

            if (string.IsNullOrWhiteSpace(adminUsername) || string.IsNullOrWhiteSpace(adminPassword))
            {
                MessageBox.Show("Please fill in both admin username and password.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkAdminQuery = "SELECT COUNT(*) FROM admin_table WHERE Username = @AdminUsername";

                using (SqlCommand checkAdminCommand = new SqlCommand(checkAdminQuery, connection))
                {
                    checkAdminCommand.Parameters.AddWithValue("@AdminUsername", adminUsername);
                    int adminCount = (int)checkAdminCommand.ExecuteScalar();

                    if (adminCount > 0)
                    {
                        MessageBox.Show("Admin already exists.");
                    }
                    else
                    {
                        string insertAdminQuery = "INSERT INTO admin_table (Username, Password) VALUES (@AdminUsername, @AdminPassword)";

                        using (SqlCommand insertAdminCommand = new SqlCommand(insertAdminQuery, connection))
                        {
                            insertAdminCommand.Parameters.AddWithValue("@AdminUsername", adminUsername);
                            insertAdminCommand.Parameters.AddWithValue("@AdminPassword", adminPassword);

                            int rowsAffected = insertAdminCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Admin registration successful.");
                                isAdminRegistered = true;
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password. Please try again.");
                            }
                        }
                    }
                }
            }

        }

        // This method handles the back button click event.
        private void button1back_user_Click(object sender, EventArgs e)
        {
            // Navigate back to the login form or close the registration form
            this.Close(); // Close the registration form
        }
    }
}
