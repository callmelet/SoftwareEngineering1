using System;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    public partial class userprofile : Form
    {
        // Instance of the UserprofileBackend class for handling backend logic
        private readonly UserprofileBackend userProfileBackend;

        // Constructor initializing components and creating an instance of UserprofileBackend
        public userprofile()
        {
            InitializeComponent();
            userProfileBackend=new UserprofileBackend();
        }

        // Method to retrieve user data from the backend and populate textboxes
        public void GetUserData()
        {
            //Retriving the UserData from userProfileModel and assigning it to textbox
            UserProfileModel userData = userProfileBackend.LoadUserData();

            // Check if user data is retrieved successfully
            if (userData != null )
            {
                // Populate textboxes with user data
                textBoxname.Text = userData.Name;
                textBoxsurname.Text =userData.Surname;
                textBoxemail.Text = userData.Email;
                textBoxphone.Text = userData.Phone;
            }
        }

        // Event handler when the Userprofile form is loaded
        private void userprofile_Load(object sender, EventArgs e)
        {
            // Call GetUserData to populate textboxes when the form is loaded
            GetUserData();
        }

        // Event handler for saving the name to the database
        private void btnsavename_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string name = textBoxname.Text;
            string username = LoginInfo.UserName;

            // Update the name in the database using the UserprofileBackend's UpdateName method
            int rowsAffected = userProfileBackend.UpdateName(name, username);

            // Check if the insertion was successful and provide feedback to the user
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data saved successfully!");
                GetUserData(); // Refresh user data after the update
            }
            else
            {
                MessageBox.Show("Error saving data to the database.");
            }
        }

        // Similar event handlers for saving surname, email, and phone number to the database
        private void btnsavesurname_Click(object sender, EventArgs e)
        {
            //GetUserData();
            // Get user input from textboxes
            string surname = textBoxsurname.Text;
            string username = LoginInfo.UserName;

            int rowsAffected = userProfileBackend.UpdateSurname(surname, username);

            // Check if the update was successful
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data saved successfully!");
                GetUserData();
            }
            else
            {
                MessageBox.Show("Error saving data to the database.");
            }        
        }
        private void btnsaveemail_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string email = textBoxemail.Text;
            string username = LoginInfo.UserName;

            int rowsAffected = userProfileBackend.UpdateEmail(email, username);

            // Check if the update was successful
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data saved successfully!");
                GetUserData();
            }
            else
            {
                MessageBox.Show("Error saving data to the database.");
            }

        }
        private void btnsavephone_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string phone = textBoxphone.Text;
            string username = LoginInfo.UserName;

            int rowsAffected = userProfileBackend.UpdatePhone(phone, username);

            // Check if the update was successful
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data saved successfully!");
                GetUserData();
            }
            else
            {
                MessageBox.Show("Error saving data to the database.");
            }
        }

        // Event handler for navigating back to the Userpage
        private void backButton_Click(object sender, EventArgs e)
        {
            Userpage userpage= new Userpage();
            userpage.Show();
            this.Close();
        }
    }
}
