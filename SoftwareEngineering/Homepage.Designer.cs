namespace SoftwareEngineering
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.loginbutton = new System.Windows.Forms.Button();
            this.registerbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonUSER = new System.Windows.Forms.RadioButton();
            this.radioButtonADMIN = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbutton.Location = new System.Drawing.Point(59, 227);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(127, 40);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "LOGIN";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // registerbutton
            // 
            this.registerbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerbutton.Location = new System.Drawing.Point(284, 227);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(127, 40);
            this.registerbutton.TabIndex = 1;
            this.registerbutton.Text = "REGISTER";
            this.registerbutton.UseVisualStyleBackColor = false;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select your role:";
            // 
            // radioButtonUSER
            // 
            this.radioButtonUSER.BackColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonUSER.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonUSER.Location = new System.Drawing.Point(175, 91);
            this.radioButtonUSER.Name = "radioButtonUSER";
            this.radioButtonUSER.Size = new System.Drawing.Size(121, 38);
            this.radioButtonUSER.TabIndex = 3;
            this.radioButtonUSER.TabStop = true;
            this.radioButtonUSER.Text = "USER";
            this.radioButtonUSER.UseVisualStyleBackColor = false;
            this.radioButtonUSER.CheckedChanged += new System.EventHandler(this.radioButtonUSER_CheckedChanged);
            // 
            // radioButtonADMIN
            // 
            this.radioButtonADMIN.BackColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonADMIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonADMIN.Location = new System.Drawing.Point(175, 147);
            this.radioButtonADMIN.Name = "radioButtonADMIN";
            this.radioButtonADMIN.Size = new System.Drawing.Size(121, 38);
            this.radioButtonADMIN.TabIndex = 4;
            this.radioButtonADMIN.TabStop = true;
            this.radioButtonADMIN.Text = "ADMIN";
            this.radioButtonADMIN.UseVisualStyleBackColor = false;
            this.radioButtonADMIN.CheckedChanged += new System.EventHandler(this.radioButtonADMIN_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonUSER);
            this.panel1.Controls.Add(this.radioButtonADMIN);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Controls.Add(this.registerbutton);
            this.panel1.Location = new System.Drawing.Point(189, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 315);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(871, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Homepage";
            this.Text = "Citisoft-Homepage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonUSER;
        private System.Windows.Forms.RadioButton radioButtonADMIN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}