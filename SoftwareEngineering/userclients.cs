using System;
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
        private int selectedRowIndex = -1; // Track the selected row index

        public userclients()
        {
            InitializeComponent();
                
        }


        private void userclients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendorApplicationDataSet1.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.vendorApplicationDataSet1.Clients);
            // TODO: This line of code loads data into the 'vendorApplicationDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.vendorApplicationDataSet1.Clients);

            // Initialize the DataSet and bind it to the DataGridView
            InitializeDataSet();

            
        }
    

        private void InitializeDataSet()
        {
            dataSet = new DataSet();

            // Set up a data adapter to fetch data from SQL Server
            dataAdapter = new SqlDataAdapter("SELECT * FROM Clients", connectionString);

            // Create commands to automatically generate SQL statements
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            // Fill the DataSet with data from SQL Server
            dataAdapter.Fill(dataSet, "Clients");

            // Set the DataSource of the DataGridView
            dataGridView2.DataSource = dataSet.Tables["Clients"];

            // Ensure that the scroll bars are visible for dataGridView2
            dataGridView2.ScrollBars = ScrollBars.Both;
            this.VerticalScroll.Visible = true;
        }


        private void UpdateDataGridView()
        {
            // Clear the DataSet and refill it with updated data from SQL Server
            dataSet.Clear();
            dataAdapter.Fill(dataSet, "Clients");

            // Disable editing after updating
            dataGridView2.ReadOnly = false;  
        }


        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void EditClient(int rowIndex)
        {
            
        }

        private void DeleteClient(int rowIndex)
        {

        }
         

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ClientSolutionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["CLIENT SOLUTION"] = ClientSolutionTextBox.Text;
                dataAdapter.Update(dataSet, "Clients");
                UpdateDataGridView();
            }
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
            // Add new row to the DataGridView and DataSet
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
            // Hide the current form (userclients)
            this.Hide();
            // Show the UserPage form
            Userpage userPage = new Userpage();
            userPage.Show();
        }

        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRowIndex = e.RowIndex;

        }

        private void deleteClientbutton_Click(object sender, EventArgs e)
        {
            // Display a warning message
            DialogResult result = MessageBox.Show("Are you sure you want to delete this client? This action cannot be undone.",
                                                  "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Get the selected row index
                int rowIndex = dataGridView2.CurrentCell.RowIndex;

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
            // Get the selected row index
            int rowIndex = dataGridView2.CurrentCell.RowIndex;

            // Update the selected row in the DataSet with data from textboxes
            dataSet.Tables["Clients"].Rows[rowIndex]["CLIENT NAME"] = clientNameTextBox.Text;
            dataSet.Tables["Clients"].Rows[rowIndex]["CONTACT NUMBER"] = PhoneTextBox.Text;
            dataSet.Tables["Clients"].Rows[rowIndex]["EMAIL ADDRESS"] = EmailAddressTextBox.Text;
            dataSet.Tables["Clients"].Rows[rowIndex]["ADDRESS"] = AddressTextBox.Text;
            dataSet.Tables["Clients"].Rows[rowIndex]["JOB TITLE"] = JobTitleTextBox.Text;
            dataSet.Tables["Clients"].Rows[rowIndex]["COMPANY NAME"] = CompanyNameTextBox.Text;

            // Save changes to the database
            dataAdapter.Update(dataSet, "Clients");

            // Update the DataGridView after editing
            UpdateDataGridView();

        }

        private void SaveClientInfoButton_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                dataSet.Tables["Clients"].Rows[selectedRowIndex]["CLIENT SOLUTION"] = ClientSolutionTextBox.Text;
                dataAdapter.Update(dataSet, "Clients");
                UpdateDataGridView();
            }
        }
    }
}
