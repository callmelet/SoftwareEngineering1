﻿using System;
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
    public partial class Userpage : Form
    {
        private AutoCompleteStringCollection suggestionList;
        private string connectionString = "Data Source=BOOK-5A3M5LR9FE\\SQLEXPRESS;Initial Catalog=VendorApplication;Integrated Security=True";

        public Userpage()
        {
            InitializeComponent();
            InitializeComponent();
            suggestionList = new AutoCompleteStringCollection();
            PopulateSuggestionList();
            usersearchbox.AutoCompleteCustomSource = suggestionList;
            usersearchbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;  // Set to SuggestAppend
            usersearchbox.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void PopulateSuggestionList()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => PopulateSuggestionList()));
                    return;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT SolutionName FROM Solutions";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            suggestionList.Add(reader["SolutionName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {   
                MessageBox.Show($"An error occurred while fetching suggestions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userprofile_Click(object sender, EventArgs e)
        {
            // Open the userprofile form
            userprofile userProfileForm = new userprofile();
            userProfileForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {

        }

        private void userclientsbutton_Click(object sender, EventArgs e)
        {
            // Open the userclients form
            userclients userClientsForm = new userclients();
            userClientsForm.Show();
        }

        private void usersearchbox_TextChanged(object sender, EventArgs e)
        {
          
        }


    }
}