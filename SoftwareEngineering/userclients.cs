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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SoftwareEngineering
{
    public partial class userclients : Form
    {
        private string connectionString = "Data Source=BOOK-5A3M5LR9FE\\SQLEXPRESS;Initial Catalog=VendorApplication;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;

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
            dataGridView1.DataSource = dataSet.Tables["Clients"];
        }


        private void UpdateDataGridView()
        {
            // Clear the DataSet and refill it with updated data from SQL Server
            dataSet.Clear();
            dataAdapter.Fill(dataSet, "Clients");

            // Disable editing after updating
            dataGridView1.ReadOnly = false;  
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
            dataGridView1.ScrollBars= ScrollBars.Both;
            this.VerticalScroll.Visible = true;
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                if (columnIndex == dataGridView1.Columns["EDIT"].Index)
                {
                    // Allow editing for the entire DataGridView
                    // dataGridView1.ReadOnly = false;

                    // Handle edit button click
                    EditClient(rowIndex);

                }
                else if (columnIndex == dataGridView1.Columns["DELETE"].Index)
                {
                    // Handle delete button click
                    DeleteClient(rowIndex);
                }
            }   


        }

        private void EditClient(int rowIndex)
        {
            // Enable the DataGridView's edit mode for the selected row
            dataGridView1.BeginEdit(true);
        }

        private void DeleteClient(int rowIndex)
        {
             // Display a warning message
                DialogResult result = MessageBox.Show("Are you sure you want to delete this client? This action cannot be undone.",
                                                      "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the client from the database
                    int clientIdToDelete = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["CLIENT ID"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM Clients WHERE ClientID = @ClientID";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@ClientID", clientIdToDelete);
                            cmd.ExecuteNonQuery();
                        }
                    }
                


                // Update the DataGridView after deletion
                UpdateDataGridView();
            }
        }
         


private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Save changes to the database when editing is completed
            dataAdapter.Update(dataSet, "Clients");
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

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Hide the current form (userclients)
            this.Hide();
            // Show the UserPage form
            Userpage userPage = new Userpage();
            userPage.Show();
        }
    }
}
