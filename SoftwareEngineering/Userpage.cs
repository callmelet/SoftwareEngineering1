using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    // Userpage class represents the main page for a logged-in user
    public partial class Userpage : Form
    {
        private readonly UserpageBackend backend;
        private AutoCompleteStringCollection suggestionList;

        // Constructor initializes the Userpage form and backend
        public Userpage()
        {
            InitializeComponent();
            backend = new UserpageBackend();
            InitializeAutoComplete();
        }

        // Initialize the AutoComplete feature for the search box
        private void InitializeAutoComplete()
        {
            suggestionList = new AutoCompleteStringCollection();
            PopulateSuggestionList();
            usersearchbox.AutoCompleteCustomSource = suggestionList;
            usersearchbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            usersearchbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Populate the AutoComplete suggestion list from the database
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

        // Event handler for the "User Profile" button click, where users can view their own profile
        private void userprofile_Click(object sender, EventArgs e)
        {
            // Open the userprofile form
            userprofile userProfileForm = new userprofile();
            userProfileForm.Show();
            this.Hide();
        }

        // Event handler for the "Search" button click, where the users can search for solutions
        private void searchbutton_Click(object sender, EventArgs e)
        {   
            string selectedSolution = usersearchbox.Text;
            backend.NavigateToSolution(selectedSolution);
            
        }

        // Event handler for the "User Clients" button click, where users can view their clients
        private void userclientsbutton_Click(object sender, EventArgs e)
        {
            // Open the userclients form
            userclients userClientsForm = new userclients();
            userClientsForm.Show();
            this.Hide();
        }

        // Event handler for the "Logout" button click
        private void button1_Click(object sender, EventArgs e)
        {
            LoginInfo.UserName = null;
            Homepage login = new Homepage();
            login.Show();
            this.Close();
        }

    }
}
