using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoftwareEngineering
{
    public partial class Homepage : Form
    {
        private SqlConnection connection;
        private readonly HomepageBackend backend;

        // Constructor for the Homepage form
        public Homepage()
        {
            InitializeComponent();
            backend = new HomepageBackend();
        }

        // Event handler for the "Login" button click
        private void loginbutton_Click(object sender, EventArgs e)
        {
            // to Check if neither user nor admin is selected
            if (!radioButtonUSER.Checked && !radioButtonADMIN.Checked)
            {
                MessageBox.Show("Please select one option");
            }
            else
            {
                // Invoke the appropriate method in the backend based on the selection
                backend.LoginButtonClicked(radioButtonUSER.Checked, radioButtonADMIN.Checked);
                // Hide the current form
                this.Hide();
            }
           
        }


        // Event handler for the "Register" button click
        private void registerbutton_Click(object sender, EventArgs e)
        {
            // to Check if neither user nor admin is selected
            if (!radioButtonUSER.Checked && !radioButtonADMIN.Checked)
            {
                MessageBox.Show("Please select one option");
            }
            else
            {
                // Invoke the appropriate method in the backend based on the selection
                backend.RegisterButtonClicked(radioButtonUSER.Checked, radioButtonADMIN.Checked);
                // Hide the current form
                this.Hide();
            }
        }

    }
}
