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
    public partial class GoldmanSachsFinancialAnalysis : Form
    {
        private string vendorInformation = "";
        public GoldmanSachsFinancialAnalysis()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save vendor information (for example, in a string)
            vendorInformation = "Vendor Name: Goldman Sachs Financial Analysis\n" +
                               "Contact Email: info@goldmansachs.com\n" +
                               "Contact Number: 1-800-555-5559\n";

            // Generate an HTML file with the vendor information
            string htmlContent = $@"<html>
                                      <head><title>Vendor Information</title></head>
                                      <body>{vendorInformation.Replace("\n", "<br>")}</body>
                                   </html>";

            // Save the HTML content to a temporary file
            string tempHtmlFile = Path.Combine(Path.GetTempPath(), "VendorInformation_GoldmanSachs.html");
            File.WriteAllText(tempHtmlFile, htmlContent);

            // Open the HTML file in the default web browser
            System.Diagnostics.Process.Start(tempHtmlFile);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify the URL you want to redirect to
            string url = "https://www.gsam.com/content/gsam/uk/en/advisers/homepage.html?&ls=paid-search&utm_medium=ppc&utm_source=google&utm_campaign=gmai&s_kwcid=AL!16644!3!677976287200!p!!g!!goldman%20sachs%20am&gclid=CjwKCAiAvJarBhA1EiwAGgZl0J1cVFEmAPTmVzbcO5d1mKvHTCdG9gmcRvGYLkmEZUYxe7sDi4GvAxoC2o0QAvD_BwE&gclsrc=aw.ds";

            // Open the URL in the default web browser
            System.Diagnostics.Process.Start(url);
        }
    }
}
