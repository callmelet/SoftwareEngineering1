namespace SoftwareEngineering
{
    partial class DebtManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtManagementForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.upstart_vendorbutton = new System.Windows.Forms.Button();
            this.sofi_vendorbutton = new System.Windows.Forms.Button();
            this.payplanvendorbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 198);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 140);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debt Management ";
            // 
            // upstart_vendorbutton
            // 
            this.upstart_vendorbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.upstart_vendorbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upstart_vendorbutton.BackgroundImage")));
            this.upstart_vendorbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.upstart_vendorbutton.Location = new System.Drawing.Point(41, 264);
            this.upstart_vendorbutton.Name = "upstart_vendorbutton";
            this.upstart_vendorbutton.Size = new System.Drawing.Size(214, 94);
            this.upstart_vendorbutton.TabIndex = 2;
            this.upstart_vendorbutton.UseVisualStyleBackColor = false;
            this.upstart_vendorbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sofi_vendorbutton
            // 
            this.sofi_vendorbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sofi_vendorbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sofi_vendorbutton.BackgroundImage")));
            this.sofi_vendorbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sofi_vendorbutton.Location = new System.Drawing.Point(301, 264);
            this.sofi_vendorbutton.Name = "sofi_vendorbutton";
            this.sofi_vendorbutton.Size = new System.Drawing.Size(218, 94);
            this.sofi_vendorbutton.TabIndex = 3;
            this.sofi_vendorbutton.UseVisualStyleBackColor = false;
            this.sofi_vendorbutton.Click += new System.EventHandler(this.sofi_vendorbutton_Click);
            // 
            // payplanvendorbutton
            // 
            this.payplanvendorbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.payplanvendorbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payplanvendorbutton.BackgroundImage")));
            this.payplanvendorbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.payplanvendorbutton.Location = new System.Drawing.Point(556, 264);
            this.payplanvendorbutton.Name = "payplanvendorbutton";
            this.payplanvendorbutton.Size = new System.Drawing.Size(206, 94);
            this.payplanvendorbutton.TabIndex = 4;
            this.payplanvendorbutton.UseVisualStyleBackColor = false;
            this.payplanvendorbutton.Click += new System.EventHandler(this.payplanvendorbutton_Click);
            // 
            // DebtManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.payplanvendorbutton);
            this.Controls.Add(this.sofi_vendorbutton);
            this.Controls.Add(this.upstart_vendorbutton);
            this.Controls.Add(this.panel1);
            this.Name = "DebtManagementForm";
            this.Text = "DebtManagement";
            this.Load += new System.EventHandler(this.DebtManagement_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button upstart_vendorbutton;
        private System.Windows.Forms.Button sofi_vendorbutton;
        private System.Windows.Forms.Button payplanvendorbutton;
    }
}