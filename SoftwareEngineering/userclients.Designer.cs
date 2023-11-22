namespace SoftwareEngineering
{
    partial class userclients
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
            this.components = new System.ComponentModel.Container();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorApplicationDataSet1 = new SoftwareEngineering.VendorApplicationDataSet1();
            this.clientsTableAdapter = new SoftwareEngineering.VendorApplicationDataSet1TableAdapters.ClientsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addClientBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.JobTitleTextBox = new System.Windows.Forms.TextBox();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ClientSolutionTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AssignedVendorTextBox = new System.Windows.Forms.TextBox();
            this.EditClientbutton = new System.Windows.Forms.Button();
            this.deleteClientbutton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cLIENTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTNUMBERDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILADDRESSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTSOLUTIONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBTITLEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveClientInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorApplicationDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.vendorApplicationDataSet1;
            // 
            // vendorApplicationDataSet1
            // 
            this.vendorApplicationDataSet1.DataSetName = "VendorApplicationDataSet1";
            this.vendorApplicationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "CLIENT NAME";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "JOB TITLE";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(44, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "COMPANY NAME";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(44, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "EMAIL ADDRESS";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(44, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "ADDRESS";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(44, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "PHONE";
            // 
            // addClientBtn
            // 
            this.addClientBtn.BackColor = System.Drawing.Color.Coral;
            this.addClientBtn.Location = new System.Drawing.Point(645, 39);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(144, 39);
            this.addClientBtn.TabIndex = 17;
            this.addClientBtn.Text = "ADD CLIENT";
            this.addClientBtn.UseVisualStyleBackColor = false;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Coral;
            this.cancelBtn.Location = new System.Drawing.Point(645, 232);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(144, 39);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(197, 26);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(348, 26);
            this.clientNameTextBox.TabIndex = 19;
            this.clientNameTextBox.TextChanged += new System.EventHandler(this.clientNameTextBox_TextChanged);
            // 
            // JobTitleTextBox
            // 
            this.JobTitleTextBox.Location = new System.Drawing.Point(197, 70);
            this.JobTitleTextBox.Name = "JobTitleTextBox";
            this.JobTitleTextBox.Size = new System.Drawing.Size(348, 26);
            this.JobTitleTextBox.TabIndex = 20;
            this.JobTitleTextBox.TextChanged += new System.EventHandler(this.JobTitleTextBox_TextChanged);
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(197, 119);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(348, 26);
            this.CompanyNameTextBox.TabIndex = 21;
            this.CompanyNameTextBox.TextChanged += new System.EventHandler(this.CompanyNameTextBox_TextChanged);
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Location = new System.Drawing.Point(197, 166);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(348, 26);
            this.EmailAddressTextBox.TabIndex = 22;
            this.EmailAddressTextBox.TextChanged += new System.EventHandler(this.EmailAddressTextBox_TextChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(197, 209);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(348, 26);
            this.AddressTextBox.TabIndex = 23;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(197, 260);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(348, 26);
            this.PhoneTextBox.TabIndex = 24;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(26, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "CLIENT SOLUTION";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(26, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "ASSIGNED VENDOR";
            // 
            // ClientSolutionTextBox
            // 
            this.ClientSolutionTextBox.Location = new System.Drawing.Point(30, 61);
            this.ClientSolutionTextBox.Name = "ClientSolutionTextBox";
            this.ClientSolutionTextBox.Size = new System.Drawing.Size(356, 26);
            this.ClientSolutionTextBox.TabIndex = 0;
            this.ClientSolutionTextBox.TextChanged += new System.EventHandler(this.ClientSolutionTextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.SaveClientInfoButton);
            this.panel2.Controls.Add(this.AssignedVendorTextBox);
            this.panel2.Controls.Add(this.ClientSolutionTextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(942, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 268);
            this.panel2.TabIndex = 10;
            // 
            // AssignedVendorTextBox
            // 
            this.AssignedVendorTextBox.Location = new System.Drawing.Point(30, 167);
            this.AssignedVendorTextBox.Name = "AssignedVendorTextBox";
            this.AssignedVendorTextBox.Size = new System.Drawing.Size(356, 26);
            this.AssignedVendorTextBox.TabIndex = 2;
            this.AssignedVendorTextBox.TextChanged += new System.EventHandler(this.AssignedVendorTextBox_TextChanged);
            // 
            // EditClientbutton
            // 
            this.EditClientbutton.BackColor = System.Drawing.Color.Coral;
            this.EditClientbutton.Location = new System.Drawing.Point(645, 109);
            this.EditClientbutton.Name = "EditClientbutton";
            this.EditClientbutton.Size = new System.Drawing.Size(144, 36);
            this.EditClientbutton.TabIndex = 25;
            this.EditClientbutton.Text = "EDIT CLIENT";
            this.EditClientbutton.UseVisualStyleBackColor = false;
            this.EditClientbutton.Click += new System.EventHandler(this.EditClientbutton_Click);
            // 
            // deleteClientbutton
            // 
            this.deleteClientbutton.BackColor = System.Drawing.Color.Coral;
            this.deleteClientbutton.Location = new System.Drawing.Point(645, 166);
            this.deleteClientbutton.Name = "deleteClientbutton";
            this.deleteClientbutton.Size = new System.Drawing.Size(144, 39);
            this.deleteClientbutton.TabIndex = 26;
            this.deleteClientbutton.Text = "DELETE CLIENT";
            this.deleteClientbutton.UseVisualStyleBackColor = false;
            this.deleteClientbutton.Click += new System.EventHandler(this.deleteClientbutton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIENTIDDataGridViewTextBoxColumn1,
            this.cLIENTNAMEDataGridViewTextBoxColumn1,
            this.cONTACTNUMBERDataGridViewTextBoxColumn1,
            this.eMAILADDRESSDataGridViewTextBoxColumn1,
            this.aDDRESSDataGridViewTextBoxColumn1,
            this.cLIENTSOLUTIONDataGridViewTextBoxColumn1,
            this.jOBTITLEDataGridViewTextBoxColumn1,
            this.cOMPANYNAMEDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.clientsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-7, 324);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1577, 252);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // cLIENTIDDataGridViewTextBoxColumn1
            // 
            this.cLIENTIDDataGridViewTextBoxColumn1.DataPropertyName = "CLIENT ID";
            this.cLIENTIDDataGridViewTextBoxColumn1.HeaderText = "CLIENT ID";
            this.cLIENTIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.cLIENTIDDataGridViewTextBoxColumn1.Name = "cLIENTIDDataGridViewTextBoxColumn1";
            this.cLIENTIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cLIENTIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // cLIENTNAMEDataGridViewTextBoxColumn1
            // 
            this.cLIENTNAMEDataGridViewTextBoxColumn1.DataPropertyName = "CLIENT NAME";
            this.cLIENTNAMEDataGridViewTextBoxColumn1.HeaderText = "CLIENT NAME";
            this.cLIENTNAMEDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.cLIENTNAMEDataGridViewTextBoxColumn1.Name = "cLIENTNAMEDataGridViewTextBoxColumn1";
            this.cLIENTNAMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cLIENTNAMEDataGridViewTextBoxColumn1.Width = 150;
            // 
            // cONTACTNUMBERDataGridViewTextBoxColumn1
            // 
            this.cONTACTNUMBERDataGridViewTextBoxColumn1.DataPropertyName = "CONTACT NUMBER";
            this.cONTACTNUMBERDataGridViewTextBoxColumn1.HeaderText = "CONTACT NUMBER";
            this.cONTACTNUMBERDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.cONTACTNUMBERDataGridViewTextBoxColumn1.Name = "cONTACTNUMBERDataGridViewTextBoxColumn1";
            this.cONTACTNUMBERDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cONTACTNUMBERDataGridViewTextBoxColumn1.Width = 150;
            // 
            // eMAILADDRESSDataGridViewTextBoxColumn1
            // 
            this.eMAILADDRESSDataGridViewTextBoxColumn1.DataPropertyName = "EMAIL ADDRESS";
            this.eMAILADDRESSDataGridViewTextBoxColumn1.HeaderText = "EMAIL ADDRESS";
            this.eMAILADDRESSDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.eMAILADDRESSDataGridViewTextBoxColumn1.Name = "eMAILADDRESSDataGridViewTextBoxColumn1";
            this.eMAILADDRESSDataGridViewTextBoxColumn1.ReadOnly = true;
            this.eMAILADDRESSDataGridViewTextBoxColumn1.Width = 150;
            // 
            // aDDRESSDataGridViewTextBoxColumn1
            // 
            this.aDDRESSDataGridViewTextBoxColumn1.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn1.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.aDDRESSDataGridViewTextBoxColumn1.Name = "aDDRESSDataGridViewTextBoxColumn1";
            this.aDDRESSDataGridViewTextBoxColumn1.ReadOnly = true;
            this.aDDRESSDataGridViewTextBoxColumn1.Width = 150;
            // 
            // cLIENTSOLUTIONDataGridViewTextBoxColumn1
            // 
            this.cLIENTSOLUTIONDataGridViewTextBoxColumn1.DataPropertyName = "CLIENT SOLUTION";
            this.cLIENTSOLUTIONDataGridViewTextBoxColumn1.HeaderText = "CLIENT SOLUTION";
            this.cLIENTSOLUTIONDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.cLIENTSOLUTIONDataGridViewTextBoxColumn1.Name = "cLIENTSOLUTIONDataGridViewTextBoxColumn1";
            this.cLIENTSOLUTIONDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cLIENTSOLUTIONDataGridViewTextBoxColumn1.Width = 150;
            // 
            // jOBTITLEDataGridViewTextBoxColumn1
            // 
            this.jOBTITLEDataGridViewTextBoxColumn1.DataPropertyName = "JOB TITLE";
            this.jOBTITLEDataGridViewTextBoxColumn1.HeaderText = "JOB TITLE";
            this.jOBTITLEDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.jOBTITLEDataGridViewTextBoxColumn1.Name = "jOBTITLEDataGridViewTextBoxColumn1";
            this.jOBTITLEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.jOBTITLEDataGridViewTextBoxColumn1.Width = 150;
            // 
            // cOMPANYNAMEDataGridViewTextBoxColumn1
            // 
            this.cOMPANYNAMEDataGridViewTextBoxColumn1.DataPropertyName = "COMPANY NAME";
            this.cOMPANYNAMEDataGridViewTextBoxColumn1.HeaderText = "COMPANY NAME";
            this.cOMPANYNAMEDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.cOMPANYNAMEDataGridViewTextBoxColumn1.Name = "cOMPANYNAMEDataGridViewTextBoxColumn1";
            this.cOMPANYNAMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cOMPANYNAMEDataGridViewTextBoxColumn1.Width = 150;
            // 
            // SaveClientInfoButton
            // 
            this.SaveClientInfoButton.BackColor = System.Drawing.Color.Coral;
            this.SaveClientInfoButton.Location = new System.Drawing.Point(144, 202);
            this.SaveClientInfoButton.Name = "SaveClientInfoButton";
            this.SaveClientInfoButton.Size = new System.Drawing.Size(144, 39);
            this.SaveClientInfoButton.TabIndex = 19;
            this.SaveClientInfoButton.Text = "SAVE";
            this.SaveClientInfoButton.UseVisualStyleBackColor = false;
            this.SaveClientInfoButton.Click += new System.EventHandler(this.SaveClientInfoButton_Click);
            // 
            // userclients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1569, 667);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.deleteClientbutton);
            this.Controls.Add(this.EditClientbutton);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.EmailAddressTextBox);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.JobTitleTextBox);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addClientBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "userclients";
            this.Text = "userclients";
            this.Load += new System.EventHandler(this.userclients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorApplicationDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VendorApplicationDataSet1 vendorApplicationDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private VendorApplicationDataSet1TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addClientBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox JobTitleTextBox;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ClientSolutionTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AssignedVendorTextBox;
        private System.Windows.Forms.Button EditClientbutton;
        private System.Windows.Forms.Button deleteClientbutton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNUMBERDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILADDRESSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTSOLUTIONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBTITLEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button SaveClientInfoButton;
    }
}