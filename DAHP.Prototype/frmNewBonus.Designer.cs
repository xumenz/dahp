namespace DAHP.Prototype
{
    partial class frmAddNewBonus
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
            this.gbBonusCategory = new System.Windows.Forms.GroupBox();
            this.txtBonusDetails = new System.Windows.Forms.RichTextBox();
            this.lblBonusDetails = new System.Windows.Forms.Label();
            this.lblBonusName = new System.Windows.Forms.Label();
            this.txtBonusName = new System.Windows.Forms.TextBox();
            this.btnCancelBonus = new System.Windows.Forms.Button();
            this.btnSaveBonus = new System.Windows.Forms.Button();
            this.gbBonusCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBonusCategory
            // 
            this.gbBonusCategory.Controls.Add(this.txtBonusDetails);
            this.gbBonusCategory.Controls.Add(this.lblBonusDetails);
            this.gbBonusCategory.Controls.Add(this.lblBonusName);
            this.gbBonusCategory.Controls.Add(this.txtBonusName);
            this.gbBonusCategory.Controls.Add(this.btnCancelBonus);
            this.gbBonusCategory.Controls.Add(this.btnSaveBonus);
            this.gbBonusCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBonusCategory.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBonusCategory.Location = new System.Drawing.Point(0, 0);
            this.gbBonusCategory.Name = "gbBonusCategory";
            this.gbBonusCategory.Size = new System.Drawing.Size(341, 158);
            this.gbBonusCategory.TabIndex = 2;
            this.gbBonusCategory.TabStop = false;
            this.gbBonusCategory.Text = "Enter/Modify Bonus Category";
            // 
            // txtBonusDetails
            // 
            this.txtBonusDetails.Location = new System.Drawing.Point(125, 59);
            this.txtBonusDetails.Name = "txtBonusDetails";
            this.txtBonusDetails.Size = new System.Drawing.Size(202, 46);
            this.txtBonusDetails.TabIndex = 9;
            this.txtBonusDetails.Text = "";
            // 
            // lblBonusDetails
            // 
            this.lblBonusDetails.AutoSize = true;
            this.lblBonusDetails.Location = new System.Drawing.Point(60, 59);
            this.lblBonusDetails.Name = "lblBonusDetails";
            this.lblBonusDetails.Size = new System.Drawing.Size(48, 18);
            this.lblBonusDetails.TabIndex = 8;
            this.lblBonusDetails.Text = "Details";
            // 
            // lblBonusName
            // 
            this.lblBonusName.AutoSize = true;
            this.lblBonusName.Location = new System.Drawing.Point(14, 33);
            this.lblBonusName.Name = "lblBonusName";
            this.lblBonusName.Size = new System.Drawing.Size(84, 18);
            this.lblBonusName.TabIndex = 7;
            this.lblBonusName.Text = "Bonus Name:";
            // 
            // txtBonusName
            // 
            this.txtBonusName.Location = new System.Drawing.Point(123, 30);
            this.txtBonusName.Name = "txtBonusName";
            this.txtBonusName.Size = new System.Drawing.Size(204, 23);
            this.txtBonusName.TabIndex = 6;
            // 
            // btnCancelBonus
            // 
            this.btnCancelBonus.Location = new System.Drawing.Point(244, 115);
            this.btnCancelBonus.Name = "btnCancelBonus";
            this.btnCancelBonus.Size = new System.Drawing.Size(77, 29);
            this.btnCancelBonus.TabIndex = 5;
            this.btnCancelBonus.Text = "Cancel";
            this.btnCancelBonus.UseVisualStyleBackColor = true;
            // 
            // btnSaveBonus
            // 
            this.btnSaveBonus.Location = new System.Drawing.Point(161, 115);
            this.btnSaveBonus.Name = "btnSaveBonus";
            this.btnSaveBonus.Size = new System.Drawing.Size(77, 29);
            this.btnSaveBonus.TabIndex = 4;
            this.btnSaveBonus.Text = "Save";
            this.btnSaveBonus.UseVisualStyleBackColor = true;
            // 
            // frmAddNewBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(341, 158);
            this.Controls.Add(this.gbBonusCategory);
            this.Name = "frmAddNewBonus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Bonus";
            this.Load += new System.EventHandler(this.frmNewDesignation_Load);
            this.gbBonusCategory.ResumeLayout(false);
            this.gbBonusCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBonusCategory;
        private System.Windows.Forms.RichTextBox txtBonusDetails;
        private System.Windows.Forms.Label lblBonusDetails;
        private System.Windows.Forms.Label lblBonusName;
        private System.Windows.Forms.TextBox txtBonusName;
        private System.Windows.Forms.Button btnCancelBonus;
        private System.Windows.Forms.Button btnSaveBonus;


    }
}