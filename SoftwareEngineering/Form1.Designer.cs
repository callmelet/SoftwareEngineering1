namespace SoftwareEngineering
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.homepagepanel1 = new System.Windows.Forms.Panel();
            this.homepagepanel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.homepagebutton2 = new System.Windows.Forms.Button();
            this.homepagelabel3 = new System.Windows.Forms.Label();
            this.homepagelabel2 = new System.Windows.Forms.Label();
            this.homepagelabel1 = new System.Windows.Forms.Label();
            this.homepagepanel1.SuspendLayout();
            this.homepagepanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // homepagepanel1
            // 
            this.homepagepanel1.AutoSize = true;
            this.homepagepanel1.BackColor = System.Drawing.Color.Transparent;
            this.homepagepanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homepagepanel1.BackgroundImage")));
            this.homepagepanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homepagepanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homepagepanel1.Controls.Add(this.homepagepanel2);
            this.homepagepanel1.Controls.Add(this.homepagelabel1);
            this.homepagepanel1.Location = new System.Drawing.Point(-3, 0);
            this.homepagepanel1.Name = "homepagepanel1";
            this.homepagepanel1.Size = new System.Drawing.Size(806, 451);
            this.homepagepanel1.TabIndex = 1;
            // 
            // homepagepanel2
            // 
            this.homepagepanel2.BackColor = System.Drawing.Color.Transparent;
            this.homepagepanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.homepagepanel2.Controls.Add(this.button1);
            this.homepagepanel2.Controls.Add(this.homepagebutton2);
            this.homepagepanel2.Controls.Add(this.homepagelabel3);
            this.homepagepanel2.Controls.Add(this.homepagelabel2);
            this.homepagepanel2.Location = new System.Drawing.Point(327, 75);
            this.homepagepanel2.Name = "homepagepanel2";
            this.homepagepanel2.Size = new System.Drawing.Size(423, 269);
            this.homepagepanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button1.Location = new System.Drawing.Point(150, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "REGISTER";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // homepagebutton2
            // 
            this.homepagebutton2.BackColor = System.Drawing.Color.Black;
            this.homepagebutton2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepagebutton2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.homepagebutton2.Location = new System.Drawing.Point(150, 178);
            this.homepagebutton2.Name = "homepagebutton2";
            this.homepagebutton2.Size = new System.Drawing.Size(162, 38);
            this.homepagebutton2.TabIndex = 3;
            this.homepagebutton2.Text = "LOGIN";
            this.homepagebutton2.UseVisualStyleBackColor = false;
            // 
            // homepagelabel3
            // 
            this.homepagelabel3.BackColor = System.Drawing.Color.Transparent;
            this.homepagelabel3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepagelabel3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.homepagelabel3.Location = new System.Drawing.Point(22, 145);
            this.homepagelabel3.Name = "homepagelabel3";
            this.homepagelabel3.Size = new System.Drawing.Size(390, 30);
            this.homepagelabel3.TabIndex = 2;
            this.homepagelabel3.Text = "Already have an account ? Click here to Login";
            this.homepagelabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homepagelabel2
            // 
            this.homepagelabel2.AutoEllipsis = true;
            this.homepagelabel2.BackColor = System.Drawing.Color.Transparent;
            this.homepagelabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepagelabel2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.homepagelabel2.Location = new System.Drawing.Point(112, 59);
            this.homepagelabel2.Name = "homepagelabel2";
            this.homepagelabel2.Size = new System.Drawing.Size(235, 32);
            this.homepagelabel2.TabIndex = 1;
            this.homepagelabel2.Text = "Click here to Register";
            this.homepagelabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.homepagelabel2.UseWaitCursor = true;
            // 
            // homepagelabel1
            // 
            this.homepagelabel1.BackColor = System.Drawing.Color.Black;
            this.homepagelabel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.homepagelabel1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepagelabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.homepagelabel1.Location = new System.Drawing.Point(15, 18);
            this.homepagelabel1.Name = "homepagelabel1";
            this.homepagelabel1.Size = new System.Drawing.Size(223, 55);
            this.homepagelabel1.TabIndex = 0;
            this.homepagelabel1.Text = "Citisoft Limited\r\n\r\n";
            this.homepagelabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homepagepanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.homepagepanel1.ResumeLayout(false);
            this.homepagepanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel homepagepanel1;
        private System.Windows.Forms.Panel homepagepanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button homepagebutton2;
        private System.Windows.Forms.Label homepagelabel3;
        private System.Windows.Forms.Label homepagelabel2;
        private System.Windows.Forms.Label homepagelabel1;
    }
}

