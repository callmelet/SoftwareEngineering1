using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    public partial class DebtManagementForm : Form
    {
        public DebtManagementForm()
        {
            InitializeComponent();
        }

        private void DebtManagement_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instantiate UpstartDebtManagementVendor form
            UpstartDebtManagement upstartDebtManagementVendorForm = new UpstartDebtManagement();

            // Show the UpstartDebtManagementVendor form
            upstartDebtManagementVendorForm.Show();
            this.Hide();
        }

        private void sofi_vendorbutton_Click(object sender, EventArgs e)
        {
            // Instantiate SofiDebtManagement form
            Sofi_DebtManagement sofiDebtManagementForm = new Sofi_DebtManagement();

            // Show the SofiDebtManagement form
            sofiDebtManagementForm.Show();
            this.Hide();
        }

        private void payplanvendorbutton_Click(object sender, EventArgs e)
        {
            // Instantiate PayplanDebtManagement form
            PayplanDebtManagement payplanDebtManagementForm = new PayplanDebtManagement();

            // Show the PayplanDebtManagement form
            payplanDebtManagementForm.Show();
            this.Hide();
        }
    }
}
