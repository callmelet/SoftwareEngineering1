namespace SoftwareEngineering
{
    partial class FinancialAnalysisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialAnalysisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.factsetFinancialAnalysisButton = new System.Windows.Forms.Button();
            this.bloombergfinancialbutton = new System.Windows.Forms.Button();
            this.goldmanfinancialbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 198);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 140);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financial Analysis ";
            // 
            // factsetFinancialAnalysisButton
            // 
            this.factsetFinancialAnalysisButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.factsetFinancialAnalysisButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("factsetFinancialAnalysisButton.BackgroundImage")));
            this.factsetFinancialAnalysisButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.factsetFinancialAnalysisButton.Location = new System.Drawing.Point(42, 262);
            this.factsetFinancialAnalysisButton.Name = "factsetFinancialAnalysisButton";
            this.factsetFinancialAnalysisButton.Size = new System.Drawing.Size(214, 94);
            this.factsetFinancialAnalysisButton.TabIndex = 3;
            this.factsetFinancialAnalysisButton.UseVisualStyleBackColor = false;
            this.factsetFinancialAnalysisButton.Click += new System.EventHandler(this.factsetFinancialAnalysisButton_Click);
            // 
            // bloombergfinancialbutton
            // 
            this.bloombergfinancialbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bloombergfinancialbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bloombergfinancialbutton.BackgroundImage")));
            this.bloombergfinancialbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bloombergfinancialbutton.Location = new System.Drawing.Point(299, 262);
            this.bloombergfinancialbutton.Name = "bloombergfinancialbutton";
            this.bloombergfinancialbutton.Size = new System.Drawing.Size(214, 94);
            this.bloombergfinancialbutton.TabIndex = 4;
            this.bloombergfinancialbutton.UseVisualStyleBackColor = false;
            this.bloombergfinancialbutton.Click += new System.EventHandler(this.bloombergfinancialbutton_Click);
            // 
            // goldmanfinancialbutton
            // 
            this.goldmanfinancialbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goldmanfinancialbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goldmanfinancialbutton.BackgroundImage")));
            this.goldmanfinancialbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goldmanfinancialbutton.Location = new System.Drawing.Point(549, 262);
            this.goldmanfinancialbutton.Name = "goldmanfinancialbutton";
            this.goldmanfinancialbutton.Size = new System.Drawing.Size(214, 94);
            this.goldmanfinancialbutton.TabIndex = 5;
            this.goldmanfinancialbutton.UseVisualStyleBackColor = false;
            this.goldmanfinancialbutton.Click += new System.EventHandler(this.goldmanfinancialbutton_Click);
            // 
            // FinancialAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goldmanfinancialbutton);
            this.Controls.Add(this.bloombergfinancialbutton);
            this.Controls.Add(this.factsetFinancialAnalysisButton);
            this.Controls.Add(this.panel1);
            this.Name = "FinancialAnalysisForm";
            this.Text = "FinancialConsultation";
            this.Load += new System.EventHandler(this.FinancialAnalysis_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button factsetFinancialAnalysisButton;
        private System.Windows.Forms.Button bloombergfinancialbutton;
        private System.Windows.Forms.Button goldmanfinancialbutton;
    }
}