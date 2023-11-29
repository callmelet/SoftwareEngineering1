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
        private string connectionString = "Data Source=BOOK-5A3M5LR9FE;Network Library=dbmssocn;Initial Catalog=VendorApplication;Integrated Security=True";
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
            backend.LoginButtonClicked(radioButtonUSER.Checked, radioButtonADMIN.Checked);
            this.Hide();
        }
        

        private void registerbutton_Click(object sender, EventArgs e)
        {
            backend.RegisterButtonClicked(radioButtonUSER.Checked, radioButtonADMIN.Checked);
            this.Hide();
        }    
            
    }
}
