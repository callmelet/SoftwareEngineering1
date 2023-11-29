using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    internal class UserpageBackend
    {
        private readonly string connectionString;

        public UserpageBackend(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<string> GetDataFromDatabase()
        {
            List<string> solutionNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SolutionName FROM Solutions";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        solutionNames.Add(reader["SolutionName"].ToString());
                    }
                }
            }

            return solutionNames;
        }

        public void NavigateToSolution(string solutionName)
        {
            switch (solutionName)
            {
                case "Investment Planning":
                    InvestmentPlanningForm investmentPlanningForm = new InvestmentPlanningForm();
                    investmentPlanningForm.Show();
                    break;
                case "Budgeting":
                    BudgetingForm budgetingForm = new BudgetingForm();
                    budgetingForm.Show();
                    break;
                case "Tax Planning":
                    TaxPlanningForm taxPlanningForm = new TaxPlanningForm();
                    taxPlanningForm.Show();
                    break;
                case "Financial Analysis":
                    FinancialAnalysisForm financialAnalysisForm = new FinancialAnalysisForm();
                    financialAnalysisForm.Show();
                    break;
                case "Debt Management":
                    DebtManagementForm debtManagementForm = new DebtManagementForm();
                    debtManagementForm.Show();
                    break;
                default:
                    MessageBox.Show("The solution you are looking for does not exist. Please check the name and try again.");
                    break;
            }
        }

        public void OpenUserProfileForm()
        {
            // Open the userprofile form
            userprofile userProfileForm = new userprofile();
            userProfileForm.Show();
        }

        public void OpenUserClientsForm()
        {
            // Open the userclients form
            userclients userClientsForm = new userclients();
            userClientsForm.Show();
        }
    }
}
