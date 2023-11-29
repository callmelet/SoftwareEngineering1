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

    public partial class Userpage : Form
    {
        private readonly UserpageBackend backend;
        private AutoCompleteStringCollection suggestionList;
        private string connectionString = "Data Source=BOOK-5A3M5LR9FE\\SQLEXPRESS;Initial Catalog=VendorApplication;Integrated Security=True";

        public Userpage()
        {
            InitializeComponent();
            backend = new UserpageBackend(connectionString);
            InitializeAutoComplete();
        }

        private void InitializeAutoComplete()
        {
            suggestionList = new AutoCompleteStringCollection();
            PopulateSuggestionList();
            usersearchbox.AutoCompleteCustomSource = suggestionList;
            usersearchbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            usersearchbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }


        private void PopulateSuggestionList()
        {
            try
            {
                List<string> solutionNames = backend.GetDataFromDatabase();
                suggestionList.AddRange(solutionNames.ToArray());
            }
            catch (Exception ex)
            {   
                MessageBox.Show($"An error occurred while fetching suggestions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userprofile_Click(object sender, EventArgs e)
        {
            // Open the userprofile form
            userprofile userProfileForm = new userprofile();
            userProfileForm.Show();
            this.Hide();
        }


        private void searchbutton_Click(object sender, EventArgs e)
        {   
            string selectedSolution = usersearchbox.Text;
            backend.NavigateToSolution(selectedSolution);
        }

        private void userclientsbutton_Click(object sender, EventArgs e)
        {
            // Open the userclients form
            userclients userClientsForm = new userclients();
            userClientsForm.Show();
            this.Hide();
        }

    }
}
