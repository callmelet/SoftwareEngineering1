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
    public partial class BudgetingForm : Form
    {
        public BudgetingForm()
        {
            InitializeComponent();
        }

        private void Budgeting_Load(object sender, EventArgs e)
        {

        }

        private void xerobudgetingbutton_Click(object sender, EventArgs e)
        {
            XeroBudgeting xeroBudgetingForm = new XeroBudgeting(); 
            xeroBudgetingForm.Show();
            this.Hide();
        }

        private void spendeskbudgetingbutton_Click(object sender, EventArgs e)
        {
            SpendeskBudgeting spendeskBudgetingForm = new SpendeskBudgeting();
            spendeskBudgetingForm.Show();
            this.Hide();
        }

        private void quickbooksBudgetingbutton_Click(object sender, EventArgs e)
        {
            QuickbooksBudgeting quickbooksBudgetingForm = new QuickbooksBudgeting();
            quickbooksBudgetingForm.Show();
            this.Hide();
        }
    }
}
