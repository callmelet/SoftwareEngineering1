namespace SoftwareEngineering
{
    partial class TaxPlanningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxPlanningForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EYTaxbutton = new System.Windows.Forms.Button();
            this.indineroTaxbutton = new System.Windows.Forms.Button();
            this.taxscoutsbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
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
            this.label1.Text = "Tax Planning ";
            // 
            // EYTaxbutton
            // 
            this.EYTaxbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EYTaxbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EYTaxbutton.BackgroundImage")));
            this.EYTaxbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EYTaxbutton.Location = new System.Drawing.Point(25, 279);
            this.EYTaxbutton.Name = "EYTaxbutton";
            this.EYTaxbutton.Size = new System.Drawing.Size(214, 94);
            this.EYTaxbutton.TabIndex = 4;
            this.EYTaxbutton.UseVisualStyleBackColor = false;
            this.EYTaxbutton.Click += new System.EventHandler(this.EYTaxbutton_Click);
            // 
            // indineroTaxbutton
            // 
            this.indineroTaxbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.indineroTaxbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("indineroTaxbutton.BackgroundImage")));
            this.indineroTaxbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.indineroTaxbutton.Location = new System.Drawing.Point(285, 279);
            this.indineroTaxbutton.Name = "indineroTaxbutton";
            this.indineroTaxbutton.Size = new System.Drawing.Size(214, 94);
            this.indineroTaxbutton.TabIndex = 5;
            this.indineroTaxbutton.UseVisualStyleBackColor = false;
            this.indineroTaxbutton.Click += new System.EventHandler(this.indineroTaxbutton_Click);
            // 
            // taxscoutsbutton
            // 
            this.taxscoutsbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxscoutsbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taxscoutsbutton.BackgroundImage")));
            this.taxscoutsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.taxscoutsbutton.Location = new System.Drawing.Point(547, 279);
            this.taxscoutsbutton.Name = "taxscoutsbutton";
            this.taxscoutsbutton.Size = new System.Drawing.Size(214, 94);
            this.taxscoutsbutton.TabIndex = 6;
            this.taxscoutsbutton.UseVisualStyleBackColor = false;
            this.taxscoutsbutton.Click += new System.EventHandler(this.taxscoutsbutton_Click);
            // 
            // TaxPlanningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taxscoutsbutton);
            this.Controls.Add(this.indineroTaxbutton);
            this.Controls.Add(this.EYTaxbutton);
            this.Controls.Add(this.panel1);
            this.Name = "TaxPlanningForm";
            this.Text = "TaxPlanning";
            this.Load += new System.EventHandler(this.TaxPlanning_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EYTaxbutton;
        private System.Windows.Forms.Button indineroTaxbutton;
        private System.Windows.Forms.Button taxscoutsbutton;
    }
}