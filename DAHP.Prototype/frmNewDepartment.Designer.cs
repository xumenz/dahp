namespace DAHP.Prototype
{
    partial class frmNewDepartment
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.cmbNewDepartment = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.cmbNewDepartment);
            this.gb.Controls.Add(this.btnSave);
            this.gb.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.Location = new System.Drawing.Point(131, 86);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(443, 163);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Text = "Enter/Modify Department Name";
            this.gb.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbNewDepartment
            // 
            this.cmbNewDepartment.FormattingEnabled = true;
            this.cmbNewDepartment.Location = new System.Drawing.Point(40, 51);
            this.cmbNewDepartment.Name = "cmbNewDepartment";
            this.cmbNewDepartment.Size = new System.Drawing.Size(367, 26);
            this.cmbNewDepartment.TabIndex = 5;
            this.cmbNewDepartment.Text = "Enter/Modify Department Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(213, 112);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(446, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmNewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(720, 380);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gb);
            this.Name = "frmNewDepartment";
            this.Text = "New Department";
            this.Load += new System.EventHandler(this.frmNewDepartment_Load);
            this.gb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbNewDepartment;

    }
}