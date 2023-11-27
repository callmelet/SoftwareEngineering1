﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SoftwareEngineering
{
    public partial class userclients : Form
    {
        private string connectionString = "Data Source=BOOK-5A3M5LR9FE\\SQLEXPRESS;Initial Catalog=VendorApplication;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private int selectedRowIndex = -1;

        public userclients()
        {
            InitializeComponent();
            InitializeDataSet();
        }


        private void userclients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendorApplicationDataSet3.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter1.Fill(this.vendorApplicationDataSet3.Clients);


        }


        private void InitializeDataSet()
        {
            dataSet = new DataSet();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Clients", connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(dataSet, "Clients");
            dataGridView1.DataSource = dataSet.Tables["Clients"];

            // Make the DataGridView read-only
            dataGridView1.ReadOnly = true;

            // Ensure that the scroll bars are visible for dataGridView1
            dataGridView1.ScrollBars = ScrollBars.Both;
            this.VerticalScroll.Visible = true;

            // Subscribe to the CellClick event
            dataGridView1.CellClick += dataGridView1_CellContentClick_3;
        }


        private void UpdateDataGridView()
        {
            // Clear the DataSet and refill it with updated data from SQL Server
            dataSet.Clear();
            dataAdapter.Fill(dataSet, "Clients");

            // Disable editing after updating
            dataGridView1.ReadOnly = true;
        }


        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ignore
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           //nothing here
        }

        private void EditClient(int rowIndex)
        {
            
        }

        private void DeleteClient(int rowIndex)
        {

        }
         

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //nothing here
        }

        private void ClientSolutionTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AssignedVendorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void JobTitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompanyNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            // Add new row to the DataSet
            DataRow newRow = dataSet.Tables["Clients"].NewRow();

            // Populate the new row with data from textboxes
            newRow["CLIENT NAME"] = clientNameTextBox.Text;
            newRow["CONTACT NUMBER"] = PhoneTextBox.Text;
            newRow["EMAIL ADDRESS"] = EmailAddressTextBox.Text;
            newRow["ADDRESS"] = AddressTextBox.Text;
            newRow["JOB TITLE"] = JobTitleTextBox.Text;
            newRow["COMPANY NAME"] = CompanyNameTextBox.Text;

            // Add the new row to the DataSet
            dataSet.Tables["Clients"].Rows.Add(newRow);

            // Save changes to the database
            dataAdapter.Update(dataSet, "Clients");

            // Update the DataGridView after adding
            UpdateDataGridView();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            
        }

        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void deleteClientbutton_Click(object sender, EventArgs e)
        {
            // Display a warning message
            DialogResult result = MessageBox.Show("Are you sure you want to delete this client? This action cannot be undone.",
                                                  "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Get the selected row index
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                // Delete the selected row from the DataSet
                dataSet.Tables["Clients"].Rows[rowIndex].Delete();

                // Save changes to the database
                dataAdapter.Update(dataSet, "Clients");

                // Update the DataGridView after deletion
                UpdateDataGridView();
            }
        }

        private void EditClientbutton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (selectedRowIndex >= 0)
            {
                // Update the selected row in the DataSet with data from textboxes
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["CLIENT NAME"] = clientNameTextBox.Text;
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["CONTACT NUMBER"] = PhoneTextBox.Text;
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["EMAIL ADDRESS"] = EmailAddressTextBox.Text;
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["ADDRESS"] = AddressTextBox.Text;
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["JOB TITLE"] = JobTitleTextBox.Text;
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["COMPANY NAME"] = CompanyNameTextBox.Text;


                // Save changes to the database
                dataAdapter.Update(dataSet, "Clients");

                // Update the DataGridView after editing
                UpdateDataGridView();
            }
        }

        private void SaveClientInfoButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (selectedRowIndex >= 0)
            {
                // Update the selected row in the DataSet with data from textboxes
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["CLIENT NAME"] = clientNameTextBox.Text;
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["CONTACT NUMBER"] = PhoneTextBox.Text;
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["EMAIL ADDRESS"] = EmailAddressTextBox.Text;
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["ADDRESS"] = AddressTextBox.Text;
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["JOB TITLE"] = JobTitleTextBox.Text;
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["COMPANY NAME"] = CompanyNameTextBox.Text;

                // Check if the Client Solution TextBox has content
                if (!string.IsNullOrEmpty(ClientSolutionTextBox.Text))
                {
                    dataSet.Tables["Clients"].Rows[selectedRowIndex]["CLIENT SOLUTION"] = ClientSolutionTextBox.Text;
                }

                // Check if the Assigned Vendor TextBox has content
                if (!string.IsNullOrEmpty(AssignedVendorTextBox.Text))
                {
                    dataSet.Tables["Clients"].Rows[selectedRowIndex]["ASSIGNED VENDOR"] = AssignedVendorTextBox.Text;
                }

                // Save changes to the database
                dataAdapter.Update(dataSet, "Clients");

                // Update the DataGridView after editing
                UpdateDataGridView();
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked
            if (e.RowIndex >= 0)
            {
                // Store the selected row index
                selectedRowIndex = e.RowIndex;

                // Display the selected row data in textboxes
                clientNameTextBox.Text = dataGridView1.Rows[selectedRowIndex].Cells[1].Value?.ToString();
                PhoneTextBox.Text = dataGridView1.Rows[selectedRowIndex].Cells[2].Value?.ToString();
                EmailAddressTextBox.Text = dataGridView1.Rows[selectedRowIndex].Cells[3].Value?.ToString();
                AddressTextBox.Text = dataGridView1.Rows[selectedRowIndex].Cells[4].Value?.ToString();
                JobTitleTextBox.Text = dataGridView1.Rows[selectedRowIndex].Cells[6].Value?.ToString();
                CompanyNameTextBox.Text = dataGridView1.Rows[selectedRowIndex].Cells[7].Value?.ToString();
            }
        }
    }
}
