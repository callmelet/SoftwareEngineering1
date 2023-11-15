using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SoftwareEngineering
{
    

    public partial class userprofile : Form
    {

        private string connectionString = "Data Source=BOOK-5A3M5LR9FE\\SQLEXPRESS;Initial Catalog=VendorApplication;Integrated Security=True";

        public userprofile()
        {
            InitializeComponent();

        }


        private void userprofile_Load(object sender, EventArgs e)
        {

            LoadUserData();

        }

        private void btnviewprofile_Click(object sender, EventArgs e)
        {
            //// Assuming 'viewuserprofile' is the name of your viewuserprofile form
            //viewuserprofile userProfileForm = new viewuserprofile();

            //// Show the viewuserprofile form
            //userProfileForm.Show();

            //// Close the current form
            //this.Close();
        }

        // this is the textbox for surname
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsavename_Click(object sender, EventArgs e)
        {
            LoadUserData();

            // Get user input from textboxes
            string name = textBoxname.Text;
            string username = LoginInfo.UserName;

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                string query = "UPDATE [user_table]" +
                    "SET Name = @Name where Username = @Username ";



                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data saved successfully!");
                        // Now, retrieve the updated data from the database and display in the textbox
                        string retrieveQuery = "SELECT Name FROM [user_table] WHERE Username = @Username";
                        using (SqlCommand retrieveCommand = new SqlCommand(retrieveQuery, connection))
                        {
                            retrieveCommand.Parameters.AddWithValue("@Username", username);

                            // Execute the retrieve query
                            object result = retrieveCommand.ExecuteScalar();
                            if (result != null)
                            {
                                // Update the textbox with the retrieved data
                                textBoxname.Text = result.ToString();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error saving data to the database.");
                    }
                }
            }
        }

        private void btnsavesurname_Click(object sender, EventArgs e)
        {
            LoadUserData();
            // Get user input from textboxes
            string surname = textBoxsurname.Text;
            string username = LoginInfo.UserName;

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                string query = "UPDATE [user_table] SET Surname = @Surname WHERE Username = @Username";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data saved successfully!");

                        // Now, retrieve the updated data from the database and display in the textbox
                        string retrieveQuery = "SELECT Surname FROM [user_table] WHERE Username = @Username";
                        using (SqlCommand retrieveCommand = new SqlCommand(retrieveQuery, connection))
                        {
                            retrieveCommand.Parameters.AddWithValue("@Username", username);

                            // Execute the retrieve query
                            object result = retrieveCommand.ExecuteScalar();
                            if (result != null)
                            {
                                // Update the textbox with the retrieved data
                                textBoxsurname.Text = result.ToString();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error saving data to the database.");
                    }
                }
            }
        
        }
               
        

        private void textBoxemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsaveemail_Click(object sender, EventArgs e)
        {
            LoadUserData();
            // Get user input from textboxes
            string email = textBoxemail.Text;
            string username = LoginInfo.UserName;

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                string query = "UPDATE [user_table]" + "SET Email = @Email where Username = @Username ";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data saved successfully!");

                        // Now, retrieve the updated data from the database and display in the textbox
                        string retrieveQuery = "SELECT Email FROM [user_table] WHERE Username = @Username";
                        using (SqlCommand retrieveCommand = new SqlCommand(retrieveQuery, connection))
                        {
                            retrieveCommand.Parameters.AddWithValue("@Username", username);

                            // Execute the retrieve query
                            object result = retrieveCommand.ExecuteScalar();
                            if (result != null)
                            {
                                // Update the textbox with the retrieved data
                                textBoxemail.Text = result.ToString();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error saving data to the database.");
                    }
                }
            }

        }

        private void textBoxphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsavephone_Click(object sender, EventArgs e)
        {
            LoadUserData();
            // Get user input from textboxes
            string phone = textBoxphone.Text;
            string username = LoginInfo.UserName;

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                string query = "UPDATE [user_table]" + "SET Phone = @Phone where Username = @Username ";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data saved successfully!");


                        // Now, retrieve the updated data from the database and display in the textbox
                        string retrieveQuery = "SELECT Phone FROM [user_table] WHERE Username = @Username";
                        using (SqlCommand retrieveCommand = new SqlCommand(retrieveQuery, connection))
                        {
                            retrieveCommand.Parameters.AddWithValue("@Username", username);

                            // Execute the retrieve query
                            object result = retrieveCommand.ExecuteScalar();
                            if (result != null)
                            {
                                // Update the textbox with the retrieved data
                                textBoxphone.Text = result.ToString();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error saving data to the database.");
                    }
                }
            }
        }

        private void LoadUserData()
        {
            string username = LoginInfo.UserName;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [user_table] WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Set textbox values based on retrieved data
                        textBoxname.Text = reader["Name"].ToString();
                        textBoxsurname.Text = reader["Surname"].ToString();
                        textBoxemail.Text = reader["Email"].ToString();
                        textBoxphone.Text = reader["Phone"].ToString();
                        // Add more textboxes for other columns as needed
                    }

                    reader.Close();
                }
            }
        }

    }
}
