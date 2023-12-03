namespace SoftwareEngineering
{
    partial class InvestmentPlanningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvestmentPlanningForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bettermentInvestmentButton = new System.Windows.Forms.Button();
            this.blackrockInvestmentbutton = new System.Windows.Forms.Button();
            this.JPinvestmentbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 199);
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
            this.label1.Text = "Investment Planning";
            // 
            // bettermentInvestmentButton
            // 
            this.bettermentInvestmentButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bettermentInvestmentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bettermentInvestmentButton.BackgroundImage")));
            this.bettermentInvestmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bettermentInvestmentButton.Location = new System.Drawing.Point(32, 266);
            this.bettermentInvestmentButton.Name = "bettermentInvestmentButton";
            this.bettermentInvestmentButton.Size = new System.Drawing.Size(214, 94);
            this.bettermentInvestmentButton.TabIndex = 4;
            this.bettermentInvestmentButton.UseVisualStyleBackColor = false;
            this.bettermentInvestmentButton.Click += new System.EventHandler(this.bettermentInvestmentButton_Click);
            // 
            // blackrockInvestmentbutton
            // 
            this.blackrockInvestmentbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.blackrockInvestmentbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blackrockInvestmentbutton.BackgroundImage")));
            this.blackrockInvestmentbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.blackrockInvestmentbutton.Location = new System.Drawing.Point(286, 266);
            this.blackrockInvestmentbutton.Name = "blackrockInvestmentbutton";
            this.blackrockInvestmentbutton.Size = new System.Drawing.Size(214, 94);
            this.blackrockInvestmentbutton.TabIndex = 5;
            this.blackrockInvestmentbutton.UseVisualStyleBackColor = false;
            this.blackrockInvestmentbutton.Click += new System.EventHandler(this.blackrockInvestmentbutton_Click);
            // 
            // JPinvestmentbutton
            // 
            this.JPinvestmentbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JPinvestmentbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JPinvestmentbutton.BackgroundImage")));
            this.JPinvestmentbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.JPinvestmentbutton.Location = new System.Drawing.Point(548, 266);
            this.JPinvestmentbutton.Name = "JPinvestmentbutton";
            this.JPinvestmentbutton.Size = new System.Drawing.Size(214, 94);
            this.JPinvestmentbutton.TabIndex = 6;
            this.JPinvestmentbutton.UseVisualStyleBackColor = false;
            this.JPinvestmentbutton.Click += new System.EventHandler(this.JPinvestmentbutton_Click);
            // 
            // InvestmentPlanningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 496);
            this.Controls.Add(this.JPinvestmentbutton);
            this.Controls.Add(this.blackrockInvestmentbutton);
            this.Controls.Add(this.bettermentInvestmentButton);
            this.Controls.Add(this.panel1);
            this.Name = "InvestmentPlanningForm";
            this.Text = "InvestmentPlanning";
            this.Load += new System.EventHandler(this.InvestmentPlanning_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bettermentInvestmentButton;
        private System.Windows.Forms.Button blackrockInvestmentbutton;
        private System.Windows.Forms.Button JPinvestmentbutton;
    }
}