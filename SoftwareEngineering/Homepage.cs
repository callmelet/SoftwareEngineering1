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
    public partial class Homepage : Form
    {
        private SqlConnection connection;
        private readonly HomepageBackend backend;
            
        public Homepage()
        {
            InitializeComponent();
            backend = new HomepageBackend();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void radioButtonUSER_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        
        private void radioButtonADMIN_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if(!radioButtonUSER.Checked && !radioButtonADMIN.Checked)
            {
                MessageBox.Show("Please select one option");
            }
            else
            {
                backend.LoginButtonClicked(radioButtonUSER.Checked, radioButtonADMIN.Checked);
                this.Hide();
            }
           
        }
        

        private void registerbutton_Click(object sender, EventArgs e)
        {
            if (!radioButtonUSER.Checked && !radioButtonADMIN.Checked)
            {
                MessageBox.Show("Please select one option");
            }
            else
            {
                backend.RegisterButtonClicked(radioButtonUSER.Checked, radioButtonADMIN.Checked);
                this.Hide();
            }
        }

    }
}
