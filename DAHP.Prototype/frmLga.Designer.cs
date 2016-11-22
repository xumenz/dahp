namespace DAHP.Prototype
{
    partial class frmLga
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
            this.gbSave = new System.Windows.Forms.GroupBox();
            this.lblStateName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLga = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSave
            // 
            this.gbSave.Controls.Add(this.lblStateName);
            this.gbSave.Controls.Add(this.label1);
            this.gbSave.Controls.Add(this.txtLga);
            this.gbSave.Controls.Add(this.btnCancel);
            this.gbSave.Controls.Add(this.btnSave);
            this.gbSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSave.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSave.Location = new System.Drawing.Point(0, 0);
            this.gbSave.Name = "gbSave";
            this.gbSave.Size = new System.Drawing.Size(340, 118);
            this.gbSave.TabIndex = 1;
            this.gbSave.TabStop = false;
            this.gbSave.Text = "Enter/Modify LGA";
            // 
            // lblStateName
            // 
            this.lblStateName.AutoSize = true;
            this.lblStateName.Location = new System.Drawing.Point(60, 27);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(39, 18);
            this.lblStateName.TabIndex = 8;
            this.lblStateName.Text = "State";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "State : ";
            // 
            // txtLga
            // 
            this.txtLga.Location = new System.Drawing.Point(15, 48);
            this.txtLga.Name = "txtLga";
            this.txtLga.Size = new System.Drawing.Size(295, 23);
            this.txtLga.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(147, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmLga
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(340, 118);
            this.Controls.Add(this.gbSave);
            this.Name = "frmLga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Government Area";
            this.Load += new System.EventHandler(this.frmNewDesignation_Load);
            this.gbSave.ResumeLayout(false);
            this.gbSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLga;
        private System.Windows.Forms.Label lblStateName;
        private System.Windows.Forms.Label label1;

    }
}