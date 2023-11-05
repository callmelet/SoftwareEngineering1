namespace SoftwareEngineering
{
    partial class AdminRegistrationForm
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
            this.adminusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmadminpassword = new System.Windows.Forms.Label();
            this.textBox1adminusername = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1register = new System.Windows.Forms.Button();
            this.button2back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminusername
            // 
            this.adminusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminusername.Location = new System.Drawing.Point(152, 90);
            this.adminusername.Name = "adminusername";
            this.adminusername.Size = new System.Drawing.Size(209, 35);
            this.adminusername.TabIndex = 0;
            this.adminusername.Text = "Admin Username";
            this.adminusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(152, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmadminpassword
            // 
            this.confirmadminpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmadminpassword.Location = new System.Drawing.Point(152, 244);
            this.confirmadminpassword.Name = "confirmadminpassword";
            this.confirmadminpassword.Size = new System.Drawing.Size(209, 35);
            this.confirmadminpassword.TabIndex = 2;
            this.confirmadminpassword.Text = "Confirm Admin Password\r\n";
            this.confirmadminpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1adminusername
            // 
            this.textBox1adminusername.Location = new System.Drawing.Point(455, 94);
            this.textBox1adminusername.Name = "textBox1adminusername";
            this.textBox1adminusername.Size = new System.Drawing.Size(221, 26);
            this.textBox1adminusername.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(455, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1register
            // 
            this.button1register.Location = new System.Drawing.Point(266, 331);
            this.button1register.Name = "button1register";
            this.button1register.Size = new System.Drawing.Size(140, 39);
            this.button1register.TabIndex = 6;
            this.button1register.Text = "REGISTER";
            this.button1register.UseVisualStyleBackColor = true;
            this.button1register.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2back
            // 
            this.button2back.Location = new System.Drawing.Point(434, 331);
            this.button2back.Name = "button2back";
            this.button2back.Size = new System.Drawing.Size(140, 39);
            this.button2back.TabIndex = 7;
            this.button2back.Text = "BACK";
            this.button2back.UseVisualStyleBackColor = true;
            this.button2back.Click += new System.EventHandler(this.button2back_Click);
            // 
            // AdminRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2back);
            this.Controls.Add(this.button1register);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox1adminusername);
            this.Controls.Add(this.confirmadminpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminusername);
            this.Name = "AdminRegistrationForm";
            this.Text = "adminRegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label confirmadminpassword;
        private System.Windows.Forms.TextBox textBox1adminusername;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1register;
        private System.Windows.Forms.Button button2back;
    }
}