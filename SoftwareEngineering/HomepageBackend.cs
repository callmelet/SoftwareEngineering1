
namespace SoftwareEngineering
{
    // Backend class for the Homepage
    internal class HomepageBackend
    {
        // Method to handle the "Login" button click
        public void LoginButtonClicked(bool isUserSelected, bool isAdminSelected)
        {
            // to Check if the user selected "User" and clicked "Login"
            if (isUserSelected)
            {
                // If the user selected "User" and clicked "Login", show the UserLoginForm
                UserLoginForm userLoginForm = new UserLoginForm();
                userLoginForm.Show();
            }
            else if (isAdminSelected)
            {
                // If the user selected "Admin" and clicked "Login", show the AdminLoginForm
                AdminLoginForm adminLoginForm = new AdminLoginForm();
                adminLoginForm.Show();
            }
        }

        public void RegisterButtonClicked(bool isUserSelected, bool isAdminSelected)
        {
            if (isUserSelected)
            {
                // If the user selected "User" and clicked "Register", show the UserRegistrationForm
                UserRegistrationForm userRegistrationForm = new UserRegistrationForm();
                userRegistrationForm.Show();
            }
            else if (isAdminSelected)
            {
                // If the user selected "Admin" and clicked "Register", show the AdminRegistrationForm
                AdminRegistrationForm adminRegistrationForm = new AdminRegistrationForm();
                adminRegistrationForm.Show();
            }
        }
    }
}
