using System;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    public partial class BudgetingForm : Form
    {
        public BudgetingForm()
        {
            InitializeComponent();
        }

        private void xerobudgetingbutton_Click(object sender, EventArgs e)
        {
            // Create an instance of the XeroBudgeting form and show it.
            XeroBudgeting xeroBudgetingForm = new XeroBudgeting(); 
            xeroBudgetingForm.Show();
            this.Hide();
        }

        private void spendeskbudgetingbutton_Click(object sender, EventArgs e)
        {
            // Create an instance of the SpendeskBudgeting form and show it.
            SpendeskBudgeting spendeskBudgetingForm = new SpendeskBudgeting();
            spendeskBudgetingForm.Show();
            this.Hide();
        }

        private void quickbooksBudgetingbutton_Click(object sender, EventArgs e)
        {
            // Create an instance of the QuickbooksBudgeting form and show it.
            QuickbooksBudgeting quickbooksBudgetingForm = new QuickbooksBudgeting();
            quickbooksBudgetingForm.Show();
            this.Hide();
        }

    }
}
