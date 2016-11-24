namespace DAHP.Prototype
{
    partial class frmPaymentSchedules
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbPaymentSchedules = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPaymentSchedules = new System.Windows.Forms.Label();
            this.lblTypeofEmployee = new System.Windows.Forms.Label();
            this.lblLevies = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblPayrollCategory = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpPaymentDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtLevies = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.cmbTypeofEmployee = new System.Windows.Forms.ComboBox();
            this.cmbPayrollCategory = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbPaymentSchedules.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbPaymentSchedules, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 265);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // gbPaymentSchedules
            // 
            this.gbPaymentSchedules.Controls.Add(this.cmbPayrollCategory);
            this.gbPaymentSchedules.Controls.Add(this.cmbTypeofEmployee);
            this.gbPaymentSchedules.Controls.Add(this.txtBonus);
            this.gbPaymentSchedules.Controls.Add(this.txtLevies);
            this.gbPaymentSchedules.Controls.Add(this.dtpPaymentDueDate);
            this.gbPaymentSchedules.Controls.Add(this.lblPayrollCategory);
            this.gbPaymentSchedules.Controls.Add(this.lblLevies);
            this.gbPaymentSchedules.Controls.Add(this.lblBonus);
            this.gbPaymentSchedules.Controls.Add(this.lblTypeofEmployee);
            this.gbPaymentSchedules.Controls.Add(this.lblPaymentSchedules);
            this.gbPaymentSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaymentSchedules.Location = new System.Drawing.Point(3, 3);
            this.gbPaymentSchedules.Name = "gbPaymentSchedules";
            this.gbPaymentSchedules.Size = new System.Drawing.Size(287, 196);
            this.gbPaymentSchedules.TabIndex = 0;
            this.gbPaymentSchedules.TabStop = false;
            this.gbPaymentSchedules.Text = "Payment Schedules";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblPaymentSchedules
            // 
            this.lblPaymentSchedules.AutoSize = true;
            this.lblPaymentSchedules.Location = new System.Drawing.Point(20, 29);
            this.lblPaymentSchedules.Name = "lblPaymentSchedules";
            this.lblPaymentSchedules.Size = new System.Drawing.Size(119, 18);
            this.lblPaymentSchedules.TabIndex = 0;
            this.lblPaymentSchedules.Text = "Payment Due Date:";
            // 
            // lblTypeofEmployee
            // 
            this.lblTypeofEmployee.AutoSize = true;
            this.lblTypeofEmployee.Location = new System.Drawing.Point(20, 57);
            this.lblTypeofEmployee.Name = "lblTypeofEmployee";
            this.lblTypeofEmployee.Size = new System.Drawing.Size(115, 18);
            this.lblTypeofEmployee.TabIndex = 1;
            this.lblTypeofEmployee.Text = "Type of Employee:";
            // 
            // lblLevies
            // 
            this.lblLevies.AutoSize = true;
            this.lblLevies.Location = new System.Drawing.Point(20, 122);
            this.lblLevies.Name = "lblLevies";
            this.lblLevies.Size = new System.Drawing.Size(51, 18);
            this.lblLevies.TabIndex = 3;
            this.lblLevies.Text = "Levies:";
            this.lblLevies.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(20, 86);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(47, 18);
            this.lblBonus.TabIndex = 2;
            this.lblBonus.Text = "Bonus:";
            // 
            // lblPayrollCategory
            // 
            this.lblPayrollCategory.AutoSize = true;
            this.lblPayrollCategory.Location = new System.Drawing.Point(20, 152);
            this.lblPayrollCategory.Name = "lblPayrollCategory";
            this.lblPayrollCategory.Size = new System.Drawing.Size(106, 18);
            this.lblPayrollCategory.TabIndex = 4;
            this.lblPayrollCategory.Text = "Payroll Category:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(119, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtpPaymentDueDate
            // 
            this.dtpPaymentDueDate.Location = new System.Drawing.Point(145, 29);
            this.dtpPaymentDueDate.Name = "dtpPaymentDueDate";
            this.dtpPaymentDueDate.Size = new System.Drawing.Size(127, 23);
            this.dtpPaymentDueDate.TabIndex = 5;
            // 
            // txtLevies
            // 
            this.txtLevies.Location = new System.Drawing.Point(145, 122);
            this.txtLevies.Name = "txtLevies";
            this.txtLevies.Size = new System.Drawing.Size(100, 23);
            this.txtLevies.TabIndex = 6;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(145, 89);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(100, 23);
            this.txtBonus.TabIndex = 7;
            // 
            // cmbTypeofEmployee
            // 
            this.cmbTypeofEmployee.FormattingEnabled = true;
            this.cmbTypeofEmployee.Location = new System.Drawing.Point(145, 57);
            this.cmbTypeofEmployee.Name = "cmbTypeofEmployee";
            this.cmbTypeofEmployee.Size = new System.Drawing.Size(127, 26);
            this.cmbTypeofEmployee.TabIndex = 9;
            // 
            // cmbPayrollCategory
            // 
            this.cmbPayrollCategory.FormattingEnabled = true;
            this.cmbPayrollCategory.Location = new System.Drawing.Point(145, 152);
            this.cmbPayrollCategory.Name = "cmbPayrollCategory";
            this.cmbPayrollCategory.Size = new System.Drawing.Size(127, 26);
            this.cmbPayrollCategory.TabIndex = 10;
            // 
            // frmPaymentSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(293, 265);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "frmPaymentSchedules";
            this.Text = "Payment Schedules";
            this.Load += new System.EventHandler(this.frmPaymentSchedules_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbPaymentSchedules.ResumeLayout(false);
            this.gbPaymentSchedules.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbPaymentSchedules;
        private System.Windows.Forms.Label lblPayrollCategory;
        private System.Windows.Forms.Label lblLevies;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblTypeofEmployee;
        private System.Windows.Forms.Label lblPaymentSchedules;
        private System.Windows.Forms.ComboBox cmbPayrollCategory;
        private System.Windows.Forms.ComboBox cmbTypeofEmployee;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtLevies;
        private System.Windows.Forms.DateTimePicker dtpPaymentDueDate;
    }
}