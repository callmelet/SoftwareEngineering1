using System;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    public partial class userprofile : Form
    {
        private readonly UserprofileBackend userProfileBackend;
        public userprofile()
        {
            InitializeComponent();
            userProfileBackend=new UserprofileBackend();
        }
        public void GetUserData()
        {
            //Retriving the UserData from userProfileModel and assigning it to textbox
            UserProfileModel userData = userProfileBackend.LoadUserData();

            if (userData != null )
            {
                textBoxname.Text = userData.Name;
                textBoxsurname.Text =userData.Surname;
                textBoxemail.Text = userData.Email;
                textBoxphone.Text = userData.Phone;
            }
        }

        private void userprofile_Load(object sender, EventArgs e)
        {
            GetUserData();
        }

        private void btnsavename_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string name = textBoxname.Text;
            string username = LoginInfo.UserName;

            int rowsAffected = userProfileBackend.UpdateName(name, username);

            // Check if the insertion was successful
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

        private void backButton_Click(object sender, EventArgs e)
        {
            Userpage userpage= new Userpage();
            userpage.Show();
            this.Close();
        }
    }
}
