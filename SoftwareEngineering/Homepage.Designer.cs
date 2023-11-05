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
            this.loginbutton = new System.Windows.Forms.Button();
            this.registerbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonUSER = new System.Windows.Forms.RadioButton();
            this.radioButtonADMIN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbutton.Location = new System.Drawing.Point(216, 287);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(127, 40);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "LOGIN";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // registerbutton
            // 
            this.registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerbutton.Location = new System.Drawing.Point(442, 287);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(127, 40);
            this.registerbutton.TabIndex = 1;
            this.registerbutton.Text = "REGISTER";
            this.registerbutton.UseVisualStyleBackColor = true;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select your role:";
            // 
            // radioButtonUSER
            // 
            this.radioButtonUSER.Location = new System.Drawing.Point(331, 137);
            this.radioButtonUSER.Name = "radioButtonUSER";
            this.radioButtonUSER.Size = new System.Drawing.Size(121, 38);
            this.radioButtonUSER.TabIndex = 3;
            this.radioButtonUSER.TabStop = true;
            this.radioButtonUSER.Text = "USER";
            this.radioButtonUSER.UseVisualStyleBackColor = true;
            this.radioButtonUSER.CheckedChanged += new System.EventHandler(this.radioButtonUSER_CheckedChanged);
            // 
            // radioButtonADMIN
            // 
            this.radioButtonADMIN.Location = new System.Drawing.Point(331, 204);
            this.radioButtonADMIN.Name = "radioButtonADMIN";
            this.radioButtonADMIN.Size = new System.Drawing.Size(121, 38);
            this.radioButtonADMIN.TabIndex = 4;
            this.radioButtonADMIN.TabStop = true;
            this.radioButtonADMIN.Text = "ADMIN";
            this.radioButtonADMIN.UseVisualStyleBackColor = true;
            this.radioButtonADMIN.CheckedChanged += new System.EventHandler(this.radioButtonADMIN_CheckedChanged);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonADMIN);
            this.Controls.Add(this.radioButtonUSER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.loginbutton);
            this.Name = "Homepage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonUSER;
        private System.Windows.Forms.RadioButton radioButtonADMIN;
    }
}