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
    public partial class InvestmentPlanningForm : Form
    {   
        public InvestmentPlanningForm()
        {
            InitializeComponent();
        }

        private void InvestmentPlanning_Load(object sender, EventArgs e)
        {

        }

        private void bettermentInvestmentButton_Click(object sender, EventArgs e)
        {
            BettermentInvestmentPlanning bettermentInvestmentPlanningForm = new BettermentInvestmentPlanning();
            bettermentInvestmentPlanningForm.Show();
            this.Hide();
        }

        private void blackrockInvestmentbutton_Click(object sender, EventArgs e)
        {
            BlackrockInvestmentPlanning blackrockInvestmentPlanningForm = new BlackrockInvestmentPlanning();
            blackrockInvestmentPlanningForm.Show();
            this.Hide();
        }

        private void JPinvestmentbutton_Click(object sender, EventArgs e)
        {
            JPMorganInvestmentPlanning jPMorganInvestmentPlanningForm = new JPMorganInvestmentPlanning();
            jPMorganInvestmentPlanningForm.Show();
            this.Hide();
        }
    }
}
