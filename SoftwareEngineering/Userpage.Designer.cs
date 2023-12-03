namespace SoftwareEngineering
{
    partial class Userpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Userpage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userclientsbutton = new System.Windows.Forms.Button();
            this.userprofilebutton = new System.Windows.Forms.Button();
            this.usersearchbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.userclientsbutton);
            this.panel1.Controls.Add(this.userprofilebutton);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 515);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // userclientsbutton
            // 
            this.userclientsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userclientsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userclientsbutton.Location = new System.Drawing.Point(35, 305);
            this.userclientsbutton.Name = "userclientsbutton";
            this.userclientsbutton.Size = new System.Drawing.Size(161, 35);
            this.userclientsbutton.TabIndex = 1;
            this.userclientsbutton.Text = "YOUR CLIENTS";
            this.userclientsbutton.UseVisualStyleBackColor = true;
            this.userclientsbutton.Click += new System.EventHandler(this.userclientsbutton_Click);
            // 
            // userprofilebutton
            // 
            this.userprofilebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userprofilebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userprofilebutton.Location = new System.Drawing.Point(35, 209);
            this.userprofilebutton.Name = "userprofilebutton";
            this.userprofilebutton.Size = new System.Drawing.Size(161, 35);
            this.userprofilebutton.TabIndex = 0;
            this.userprofilebutton.Text = "YOUR PROFILE";
            this.userprofilebutton.UseVisualStyleBackColor = true;
            this.userprofilebutton.Click += new System.EventHandler(this.userprofile_Click);
            // 
            // usersearchbox
            // 
            this.usersearchbox.AutoCompleteCustomSource.AddRange(new string[] {
            "Tax Planning ",
            "Budgeting",
            "Financial Analysis",
            "Investment Planning ",
            "Debt Management "});
            this.usersearchbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.usersearchbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.usersearchbox.Location = new System.Drawing.Point(50, 70);
            this.usersearchbox.Name = "usersearchbox";
            this.usersearchbox.Size = new System.Drawing.Size(427, 26);
            this.usersearchbox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.searchbutton);
            this.panel2.Controls.Add(this.usersearchbox);
            this.panel2.Location = new System.Drawing.Point(241, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 133);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "What solutions are you looking for? Type here to start";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(504, 65);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(107, 37);
            this.searchbutton.TabIndex = 2;
            this.searchbutton.Text = "SEARCH";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // Logout
            // 
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(35, 384);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(161, 35);
            this.Logout.TabIndex = 8;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // Userpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Userpage";
            this.Text = "Userpage";
            this.Load += new System.EventHandler(this.Userpage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button userprofilebutton;
        private System.Windows.Forms.Button userclientsbutton;
        private System.Windows.Forms.TextBox usersearchbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Logout;
    }
}