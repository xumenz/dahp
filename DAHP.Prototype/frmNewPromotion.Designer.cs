namespace DAHP.Prototype
{
    partial class frmNewPromotion
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
            this.gbNewPromotion = new System.Windows.Forms.GroupBox();
            this.txtNewPromotion = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbNewPromotion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNewPromotion
            // 
            this.gbNewPromotion.Controls.Add(this.btnCancel);
            this.gbNewPromotion.Controls.Add(this.btnSave);
            this.gbNewPromotion.Controls.Add(this.txtNewPromotion);
            this.gbNewPromotion.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewPromotion.Location = new System.Drawing.Point(233, 105);
            this.gbNewPromotion.Name = "gbNewPromotion";
            this.gbNewPromotion.Size = new System.Drawing.Size(544, 249);
            this.gbNewPromotion.TabIndex = 1;
            this.gbNewPromotion.TabStop = false;
            this.gbNewPromotion.Text = "Enter/Modify New Promotion";
            // 
            // txtNewPromotion
            // 
            this.txtNewPromotion.Location = new System.Drawing.Point(122, 79);
            this.txtNewPromotion.Name = "txtNewPromotion";
            this.txtNewPromotion.Size = new System.Drawing.Size(318, 23);
            this.txtNewPromotion.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(269, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(365, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmNewPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 661);
            this.Controls.Add(this.gbNewPromotion);
            this.Name = "frmNewPosition";
            this.Text = "frmNewPosition";
            this.gbNewPromotion.ResumeLayout(false);
            this.gbNewPromotion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewPromotion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewPromotion;
    }
}