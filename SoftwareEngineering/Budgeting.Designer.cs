namespace SoftwareEngineering
{
    partial class BudgetingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.xerobudgetingbutton = new System.Windows.Forms.Button();
            this.spendeskbudgetingbutton = new System.Windows.Forms.Button();
            this.quickbooksBudgetingbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 198);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 140);
            this.label1.TabIndex = 0;
            this.label1.Text = "Budgeting";
            // 
            // xerobudgetingbutton
            // 
            this.xerobudgetingbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xerobudgetingbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xerobudgetingbutton.BackgroundImage")));
            this.xerobudgetingbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.xerobudgetingbutton.Location = new System.Drawing.Point(27, 278);
            this.xerobudgetingbutton.Name = "xerobudgetingbutton";
            this.xerobudgetingbutton.Size = new System.Drawing.Size(214, 94);
            this.xerobudgetingbutton.TabIndex = 4;
            this.xerobudgetingbutton.UseVisualStyleBackColor = false;
            this.xerobudgetingbutton.Click += new System.EventHandler(this.xerobudgetingbutton_Click);
            // 
            // spendeskbudgetingbutton
            // 
            this.spendeskbudgetingbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spendeskbudgetingbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spendeskbudgetingbutton.BackgroundImage")));
            this.spendeskbudgetingbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spendeskbudgetingbutton.Location = new System.Drawing.Point(291, 278);
            this.spendeskbudgetingbutton.Name = "spendeskbudgetingbutton";
            this.spendeskbudgetingbutton.Size = new System.Drawing.Size(214, 94);
            this.spendeskbudgetingbutton.TabIndex = 5;
            this.spendeskbudgetingbutton.UseVisualStyleBackColor = false;
            this.spendeskbudgetingbutton.Click += new System.EventHandler(this.spendeskbudgetingbutton_Click);
            // 
            // quickbooksBudgetingbutton
            // 
            this.quickbooksBudgetingbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quickbooksBudgetingbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quickbooksBudgetingbutton.BackgroundImage")));
            this.quickbooksBudgetingbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.quickbooksBudgetingbutton.Location = new System.Drawing.Point(547, 278);
            this.quickbooksBudgetingbutton.Name = "quickbooksBudgetingbutton";
            this.quickbooksBudgetingbutton.Size = new System.Drawing.Size(214, 94);
            this.quickbooksBudgetingbutton.TabIndex = 6;
            this.quickbooksBudgetingbutton.UseVisualStyleBackColor = false;
            this.quickbooksBudgetingbutton.Click += new System.EventHandler(this.quickbooksBudgetingbutton_Click);
            // 
            // BudgetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quickbooksBudgetingbutton);
            this.Controls.Add(this.spendeskbudgetingbutton);
            this.Controls.Add(this.xerobudgetingbutton);
            this.Controls.Add(this.panel1);
            this.Name = "BudgetingForm";
            this.Text = "Budgeting";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xerobudgetingbutton;
        private System.Windows.Forms.Button spendeskbudgetingbutton;
        private System.Windows.Forms.Button quickbooksBudgetingbutton;
    }
}