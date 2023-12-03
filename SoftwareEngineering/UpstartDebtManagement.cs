using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;

namespace SoftwareEngineering
{
    public partial class UpstartDebtManagement : Form
    {
        private string vendorInformation = "";

        public UpstartDebtManagement()
        {
            InitializeComponent();
        }

        private void UpstartDebtManagementVendor_Load(object sender, EventArgs e)
        {
            // You can set the link text and properties here or in the designer
            linkLabel1.Text = "Visit Upstart Debt Management";
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify the URL you want to redirect to
            string url = "https://www.upstart.com/";

            // Open the URL in the default web browser
            System.Diagnostics.Process.Start(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save vendor information (for example, in a string)
            vendorInformation = "Vendor Name: Upstart Debt Management\n" +
                               "Contact Email: bizdev@upstart.com\n" +
                               "Contact Number: 1-833-212-2461\n" ;

            // Generate an HTML file with the vendor information
            string htmlContent = $@"<html>
                                      <head><title>Vendor Information</title></head>
                                      <body>{vendorInformation.Replace("\n", "<br>")}</body>
                                   </html>";

            // Save the HTML content to a temporary file
            string tempHtmlFile = Path.Combine(Path.GetTempPath(), "VendorInformation.html");
            File.WriteAllText(tempHtmlFile, htmlContent);

            // Open the HTML file in the default web browser
            System.Diagnostics.Process.Start(tempHtmlFile);
        }


        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
