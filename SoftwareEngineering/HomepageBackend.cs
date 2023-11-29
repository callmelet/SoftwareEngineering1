using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    internal class HomepageBackend
    {
        public void LoginButtonClicked(bool isUserSelected, bool isAdminSelected)
        {
            if (isUserSelected)
            {
                // The user selected "User" and clicked "Login"
                UserLoginForm userLoginForm = new UserLoginForm();
                userLoginForm.Show();
            }
            else if (isAdminSelected)
            {
                // The user selected "Admin" and clicked "Login"
                AdminLoginForm adminLoginForm = new AdminLoginForm();
                adminLoginForm.Show();
            }
        }

        public void RegisterButtonClicked(bool isUserSelected, bool isAdminSelected)
        {
            if (isUserSelected)
            {
                // The user selected "User" and clicked "Register"
                UserRegistrationForm userRegistrationForm = new UserRegistrationForm();
                userRegistrationForm.Show();
            }
            else if (isAdminSelected)
            {
                // The user selected "Admin" and clicked "Register"
                AdminRegistrationForm adminRegistrationForm = new AdminRegistrationForm();
                adminRegistrationForm.Show();
            }
        }
    }
}
