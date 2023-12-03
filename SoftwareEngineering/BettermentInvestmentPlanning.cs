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
    public partial class BettermentInvestmentPlanning : Form
    {
        private string vendorInformation = "";
        public BettermentInvestmentPlanning()
        {
            InitializeComponent();
        }

        private void BettermentInvestmentPlanning_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify the URL you want to redirect to
            string url = "https://www.betterment.com/";

            // Open the URL in the default web browser
            System.Diagnostics.Process.Start(url);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Save vendor information (for example, in a string)
            vendorInformation = "Vendor Name: Betterment Investment Planning\n" +
                               "Contact Email: info@betterment.com\n" +
                               "Contact Number: 1-800-555-5560\n";

            // Generate an HTML file with the vendor information
            string htmlContent = $@"<html>
                                      <head><title>Vendor Information</title></head>
                                      <body>{vendorInformation.Replace("\n", "<br>")}</body>
                                   </html>";

            // Save the HTML content to a temporary file
            string tempHtmlFile = Path.Combine(Path.GetTempPath(), "VendorInformation_Betterment.html");
            File.WriteAllText(tempHtmlFile, htmlContent);

            // Open the HTML file in the default web browser
            System.Diagnostics.Process.Start(tempHtmlFile);
        }
    }
}
