using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    // UserpageBackend class handles the backend logic for the Userpage
    internal class UserpageBackend
    {
        private readonly string connectionString = ConnectionString.DBConnectionString;

        // Retrieve solution names from the database
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

        // Navigate to a specific solution based on the user's selection
        public void NavigateToSolution(string solutionName)
        {
            switch (solutionName)
            {
                // Open the corresponding form for each solution
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
                    // Display an error message for invalid solution names
                    MessageBox.Show("The solution you are looking for does not exist. Please check the name and try again.");
                    break;
            }
        }

    }
}
