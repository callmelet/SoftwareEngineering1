using System;
using System.Windows.Forms;
using System.IO;

namespace SoftwareEngineering
{
    public partial class XeroBudgeting : Form
    {
        // String to store vendor information
        private string vendorInformation = "";

        // Constructor to initialize the form
        public XeroBudgeting()
        {
            InitializeComponent();
        }

        // Event handler for the Xero website link click
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify the URL you want to redirect to
            string url = "https://www.xero.com/uk/";

            // Open the URL in the default web browser
            System.Diagnostics.Process.Start(url);
        }

        // Event handler for the "Open PDF" button click
        private void button2_Click(object sender, EventArgs e)
        {
            // Save vendor information (for example, in a string)
            vendorInformation = "Vendor Name: Xero Budgeting\n" +
                               "Contact Email: info@xero.com\n" +
                               "Contact Number: 1-800-555-5566\n";

            // Generate an HTML file with the vendor information
            string htmlContent = $@"<html>
                                      <head><title>Vendor Information</title></head>
                                      <body>{vendorInformation.Replace("\n", "<br>")}</body>
                                   </html>";

            // Save the HTML content to a temporary file
            string tempHtmlFile = Path.Combine(Path.GetTempPath(), "VendorInformation_Xero.html");
            File.WriteAllText(tempHtmlFile, htmlContent);

            // Open the HTML file in the default web browser
            System.Diagnostics.Process.Start(tempHtmlFile);
        }

    }
}
