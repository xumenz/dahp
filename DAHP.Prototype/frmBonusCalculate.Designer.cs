namespace DAHP.Prototype
{
    partial class frmBonusCalculator
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
            this.gbBonus = new System.Windows.Forms.GroupBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.lblBonusAmount = new System.Windows.Forms.Label();
            this.lblBonusDetails = new System.Windows.Forms.Label();
            this.lblBonusCategory = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBonusAmount = new System.Windows.Forms.TextBox();
            this.btnCancelBonus = new System.Windows.Forms.Button();
            this.btnAddBonus = new System.Windows.Forms.Button();
            this.txtBonusDetails = new System.Windows.Forms.TextBox();
            this.txtBonusList = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAddToPayRoll = new System.Windows.Forms.Button();
            this.lblTotalAmountDue = new System.Windows.Forms.Label();
            this.lblTotalBonusAmount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbBonus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtBonusList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbBonus, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, -3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 311);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // gbBonus
            // 
            this.gbBonus.Controls.Add(this.txtBasicSalary);
            this.gbBonus.Controls.Add(this.lblBasicSalary);
            this.gbBonus.Controls.Add(this.lblBonusAmount);
            this.gbBonus.Controls.Add(this.lblBonusDetails);
            this.gbBonus.Controls.Add(this.lblBonusCategory);
            this.gbBonus.Controls.Add(this.comboBox1);
            this.gbBonus.Controls.Add(this.textBonusAmount);
            this.gbBonus.Controls.Add(this.btnCancelBonus);
            this.gbBonus.Controls.Add(this.btnAddBonus);
            this.gbBonus.Controls.Add(this.txtBonusDetails);
            this.gbBonus.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBonus.Location = new System.Drawing.Point(3, 3);
            this.gbBonus.Name = "gbBonus";
            this.gbBonus.Size = new System.Drawing.Size(406, 209);
            this.gbBonus.TabIndex = 2;
            this.gbBonus.TabStop = false;
            this.gbBonus.Text = "Enter Bonus Details";
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(116, 33);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(251, 23);
            this.txtBasicSalary.TabIndex = 12;
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Location = new System.Drawing.Point(22, 33);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(77, 18);
            this.lblBasicSalary.TabIndex = 11;
            this.lblBasicSalary.Text = "Basic Salary";
            // 
            // lblBonusAmount
            // 
            this.lblBonusAmount.AutoSize = true;
            this.lblBonusAmount.Location = new System.Drawing.Point(24, 129);
            this.lblBonusAmount.Name = "lblBonusAmount";
            this.lblBonusAmount.Size = new System.Drawing.Size(90, 18);
            this.lblBonusAmount.TabIndex = 9;
            this.lblBonusAmount.Text = "Bonus Amount";
            // 
            // lblBonusDetails
            // 
            this.lblBonusDetails.AutoSize = true;
            this.lblBonusDetails.Location = new System.Drawing.Point(22, 98);
            this.lblBonusDetails.Name = "lblBonusDetails";
            this.lblBonusDetails.Size = new System.Drawing.Size(86, 18);
            this.lblBonusDetails.TabIndex = 8;
            this.lblBonusDetails.Text = "Bonus Details";
            // 
            // lblBonusCategory
            // 
            this.lblBonusCategory.AutoSize = true;
            this.lblBonusCategory.Location = new System.Drawing.Point(19, 66);
            this.lblBonusCategory.Name = "lblBonusCategory";
            this.lblBonusCategory.Size = new System.Drawing.Size(98, 18);
            this.lblBonusCategory.TabIndex = 7;
            this.lblBonusCategory.Text = "Bonus Category";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Christmas",
            "Overtime",
            "Easter",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(116, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 26);
            this.comboBox1.TabIndex = 6;
            // 
            // textBonusAmount
            // 
            this.textBonusAmount.Location = new System.Drawing.Point(116, 124);
            this.textBonusAmount.Name = "textBonusAmount";
            this.textBonusAmount.Size = new System.Drawing.Size(251, 23);
            this.textBonusAmount.TabIndex = 5;
            // 
            // btnCancelBonus
            // 
            this.btnCancelBonus.Location = new System.Drawing.Point(293, 167);
            this.btnCancelBonus.Name = "btnCancelBonus";
            this.btnCancelBonus.Size = new System.Drawing.Size(76, 27);
            this.btnCancelBonus.TabIndex = 4;
            this.btnCancelBonus.Text = "Cancel";
            this.btnCancelBonus.UseVisualStyleBackColor = true;
            // 
            // btnAddBonus
            // 
            this.btnAddBonus.Location = new System.Drawing.Point(211, 167);
            this.btnAddBonus.Name = "btnAddBonus";
            this.btnAddBonus.Size = new System.Drawing.Size(76, 27);
            this.btnAddBonus.TabIndex = 3;
            this.btnAddBonus.Text = "Add";
            this.btnAddBonus.UseVisualStyleBackColor = true;
            // 
            // txtBonusDetails
            // 
            this.txtBonusDetails.Location = new System.Drawing.Point(116, 95);
            this.txtBonusDetails.Name = "txtBonusDetails";
            this.txtBonusDetails.Size = new System.Drawing.Size(251, 23);
            this.txtBonusDetails.TabIndex = 2;
            // 
            // txtBonusList
            // 
            this.txtBonusList.Location = new System.Drawing.Point(3, 218);
            this.txtBonusList.Name = "txtBonusList";
            this.txtBonusList.Size = new System.Drawing.Size(378, 90);
            this.txtBonusList.TabIndex = 3;
            this.txtBonusList.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnAddToPayRoll
            // 
            this.BtnAddToPayRoll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAddToPayRoll.Location = new System.Drawing.Point(198, 369);
            this.BtnAddToPayRoll.Name = "BtnAddToPayRoll";
            this.BtnAddToPayRoll.Size = new System.Drawing.Size(111, 27);
            this.BtnAddToPayRoll.TabIndex = 20;
            this.BtnAddToPayRoll.Text = "Add To PayRoll";
            this.BtnAddToPayRoll.UseVisualStyleBackColor = false;
            // 
            // lblTotalAmountDue
            // 
            this.lblTotalAmountDue.AutoSize = true;
            this.lblTotalAmountDue.Location = new System.Drawing.Point(28, 342);
            this.lblTotalAmountDue.Name = "lblTotalAmountDue";
            this.lblTotalAmountDue.Size = new System.Drawing.Size(93, 13);
            this.lblTotalAmountDue.TabIndex = 18;
            this.lblTotalAmountDue.Text = "Total Amount Due";
            // 
            // lblTotalBonusAmount
            // 
            this.lblTotalBonusAmount.AutoSize = true;
            this.lblTotalBonusAmount.Location = new System.Drawing.Point(28, 316);
            this.lblTotalBonusAmount.Name = "lblTotalBonusAmount";
            this.lblTotalBonusAmount.Size = new System.Drawing.Size(101, 13);
            this.lblTotalBonusAmount.TabIndex = 16;
            this.lblTotalBonusAmount.Text = "Total Bonus Earned";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 339);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 20);
            this.textBox2.TabIndex = 19;
            // 
            // frmBonusCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(428, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAddToPayRoll);
            this.Controls.Add(this.lblTotalAmountDue);
            this.Controls.Add(this.lblTotalBonusAmount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Name = "frmBonusCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonus Calculator";
            this.Load += new System.EventHandler(this.frmNewDesignation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbBonus.ResumeLayout(false);
            this.gbBonus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbBonus;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.Label lblBonusAmount;
        private System.Windows.Forms.Label lblBonusDetails;
        private System.Windows.Forms.Label lblBonusCategory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBonusAmount;
        private System.Windows.Forms.Button btnCancelBonus;
        private System.Windows.Forms.Button btnAddBonus;
        private System.Windows.Forms.TextBox txtBonusDetails;
        private System.Windows.Forms.RichTextBox txtBonusList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAddToPayRoll;
        private System.Windows.Forms.Label lblTotalAmountDue;
        private System.Windows.Forms.Label lblTotalBonusAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;



    }
}