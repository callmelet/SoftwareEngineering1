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
    public partial class FinancialAnalysisForm : Form
    {
        public FinancialAnalysisForm()
        {
            InitializeComponent();
        }

        private void FinancialAnalysis_Load(object sender, EventArgs e)
        {
            
        }

        private void factsetFinancialAnalysisButton_Click(object sender, EventArgs e)
        {
            // Instantiate factsetFinancialAnalysis form
            FactsetFinancialAnalysis factsetFinancialAnalysisForm = new FactsetFinancialAnalysis();

            // Show the factsetFinancialAnalysis form
            factsetFinancialAnalysisForm.Show();
            this.Hide();
        }

        private void bloombergfinancialbutton_Click(object sender, EventArgs e)
        {
            
            BloombergFinancialAnalysis bloombergFinancialAnalysisForm = new BloombergFinancialAnalysis();
            bloombergFinancialAnalysisForm.Show();
            this.Hide();
        }

        private void goldmanfinancialbutton_Click(object sender, EventArgs e)
        {
            GoldmanSachsFinancialAnalysis goldmanSachsFinancialAnalysisForm = new GoldmanSachsFinancialAnalysis();
            goldmanSachsFinancialAnalysisForm.Show();
            this.Hide();
        }
    }
}
