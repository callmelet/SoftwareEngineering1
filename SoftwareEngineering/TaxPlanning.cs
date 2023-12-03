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
    public partial class TaxPlanningForm : Form
    {
        public TaxPlanningForm()
        {
            InitializeComponent();
        }

        private void TaxPlanning_Load(object sender, EventArgs e)
        {

        }

        private void EYTaxbutton_Click(object sender, EventArgs e)
        {
            EYTaxPlanning eYTaxPlanningForm = new EYTaxPlanning();
            eYTaxPlanningForm.Show();
            this.Hide();
        }

        private void indineroTaxbutton_Click(object sender, EventArgs e)
        {
            IndineroTaxPlanning indineroTaxPlanningForm = new IndineroTaxPlanning();
            indineroTaxPlanningForm.Show();
            this.Hide();   
        }

        private void taxscoutsbutton_Click(object sender, EventArgs e)
        {
            TaxScouts taxScoutsForm = new TaxScouts();
            taxScoutsForm.Show();
            this.Hide();
        }
    }
}
