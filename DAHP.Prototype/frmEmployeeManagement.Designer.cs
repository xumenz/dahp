namespace DAHP.Prototype
{
    partial class frmEmployeeManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnProfessionalQualification = new System.Windows.Forms.Button();
            this.btnEducationalQualification = new System.Windows.Forms.Button();
            this.btnNextOfKin = new System.Windows.Forms.Button();
            this.btnPhoneNumber = new System.Windows.Forms.Button();
            this.btnContactInformation = new System.Windows.Forms.Button();
            this.btnPersonInformation = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSearchEmployee = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbSearchEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.btnProfessionalQualification);
            this.panel1.Controls.Add(this.btnEducationalQualification);
            this.panel1.Controls.Add(this.btnNextOfKin);
            this.panel1.Controls.Add(this.btnPhoneNumber);
            this.panel1.Controls.Add(this.btnContactInformation);
            this.panel1.Controls.Add(this.btnPersonInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 487);
            this.panel1.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(-4, 400);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(152, 49);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // btnProfessionalQualification
            // 
            this.btnProfessionalQualification.Location = new System.Drawing.Point(-4, 328);
            this.btnProfessionalQualification.Name = "btnProfessionalQualification";
            this.btnProfessionalQualification.Size = new System.Drawing.Size(152, 49);
            this.btnProfessionalQualification.TabIndex = 5;
            this.btnProfessionalQualification.Text = "Professional Qualification";
            this.btnProfessionalQualification.UseVisualStyleBackColor = true;
            // 
            // btnEducationalQualification
            // 
            this.btnEducationalQualification.Location = new System.Drawing.Point(-4, 262);
            this.btnEducationalQualification.Name = "btnEducationalQualification";
            this.btnEducationalQualification.Size = new System.Drawing.Size(152, 49);
            this.btnEducationalQualification.TabIndex = 4;
            this.btnEducationalQualification.Text = "Educational Qualification";
            this.btnEducationalQualification.UseVisualStyleBackColor = true;
            // 
            // btnNextOfKin
            // 
            this.btnNextOfKin.Location = new System.Drawing.Point(-4, 199);
            this.btnNextOfKin.Name = "btnNextOfKin";
            this.btnNextOfKin.Size = new System.Drawing.Size(151, 49);
            this.btnNextOfKin.TabIndex = 3;
            this.btnNextOfKin.Text = "Next Of Kin";
            this.btnNextOfKin.UseVisualStyleBackColor = true;
            // 
            // btnPhoneNumber
            // 
            this.btnPhoneNumber.Location = new System.Drawing.Point(-1, 136);
            this.btnPhoneNumber.Name = "btnPhoneNumber";
            this.btnPhoneNumber.Size = new System.Drawing.Size(149, 49);
            this.btnPhoneNumber.TabIndex = 2;
            this.btnPhoneNumber.Text = "Contact Phone Number";
            this.btnPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // btnContactInformation
            // 
            this.btnContactInformation.Location = new System.Drawing.Point(-4, 76);
            this.btnContactInformation.Name = "btnContactInformation";
            this.btnContactInformation.Size = new System.Drawing.Size(151, 49);
            this.btnContactInformation.TabIndex = 1;
            this.btnContactInformation.Text = "Contact Information";
            this.btnContactInformation.UseVisualStyleBackColor = true;
            // 
            // btnPersonInformation
            // 
            this.btnPersonInformation.Location = new System.Drawing.Point(-4, 14);
            this.btnPersonInformation.Name = "btnPersonInformation";
            this.btnPersonInformation.Size = new System.Drawing.Size(151, 49);
            this.btnPersonInformation.TabIndex = 0;
            this.btnPersonInformation.Text = "Personal Information";
            this.btnPersonInformation.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.grbSearchEmployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(146, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 487);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(25, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 132);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Surname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Other Name";
            this.Column3.Name = "Column3";
            // 
            // grbSearchEmployee
            // 
            this.grbSearchEmployee.BackColor = System.Drawing.Color.LightGray;
            this.grbSearchEmployee.Controls.Add(this.btnSearch);
            this.grbSearchEmployee.Controls.Add(this.txtName);
            this.grbSearchEmployee.Controls.Add(this.label2);
            this.grbSearchEmployee.Location = new System.Drawing.Point(23, 24);
            this.grbSearchEmployee.Name = "grbSearchEmployee";
            this.grbSearchEmployee.Size = new System.Drawing.Size(396, 130);
            this.grbSearchEmployee.TabIndex = 0;
            this.grbSearchEmployee.TabStop = false;
            this.grbSearchEmployee.Text = "Search Employee By";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(158, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 25);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // frmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(603, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmployeeManagement";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbSearchEmployee.ResumeLayout(false);
            this.grbSearchEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnContactInformation;
        private System.Windows.Forms.Button btnPersonInformation;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnProfessionalQualification;
        private System.Windows.Forms.Button btnEducationalQualification;
        private System.Windows.Forms.Button btnNextOfKin;
        private System.Windows.Forms.Button btnPhoneNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox grbSearchEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;

    }
}