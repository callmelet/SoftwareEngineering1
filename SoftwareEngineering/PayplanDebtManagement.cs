using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoftwareEngineering
{
    public partial class PayplanDebtManagement : Form
    {
        private string vendorInformation = "";

        public PayplanDebtManagement()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify the URL you want to redirect to
            string url = "https://www.payplan.com/";

            // Open the URL in the default web browser
            System.Diagnostics.Process.Start(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save vendor information (for example, in a string)
            vendorInformation = "Vendor Name: Payplan Debt Management\n" +
                               "Contact Email: info@payplan.com\n" +
                               "Contact Number: 1-800-555-5556\n";

            // Generate an HTML file with the vendor information
            string htmlContent = $@"<html>
                                      <head><title>Vendor Information</title></head>
                                      <body>{vendorInformation.Replace("\n", "<br>")}</body>
                                   </html>";

            // Save the HTML content to a temporary file
            string tempHtmlFile = Path.Combine(Path.GetTempPath(), "VendorInformation_Payplan.html");
            File.WriteAllText(tempHtmlFile, htmlContent);

            // Open the HTML file in the default web browser
            System.Diagnostics.Process.Start(tempHtmlFile);
        }
    }
}
