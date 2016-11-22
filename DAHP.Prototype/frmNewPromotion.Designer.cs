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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewPromotion = new System.Windows.Forms.TextBox();
            this.gbNewPromotion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNewPromotion
            // 
            this.gbNewPromotion.Controls.Add(this.btnCancel);
            this.gbNewPromotion.Controls.Add(this.btnSave);
            this.gbNewPromotion.Controls.Add(this.txtNewPromotion);
            this.gbNewPromotion.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewPromotion.Location = new System.Drawing.Point(101, 44);
            this.gbNewPromotion.Name = "gbNewPromotion";
            this.gbNewPromotion.Size = new System.Drawing.Size(457, 219);
            this.gbNewPromotion.TabIndex = 1;
            this.gbNewPromotion.TabStop = false;
            this.gbNewPromotion.Text = "Enter/Modify New Promotion";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(364, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtNewPromotion
            // 
            this.txtNewPromotion.Location = new System.Drawing.Point(122, 79);
            this.txtNewPromotion.Name = "txtNewPromotion";
            this.txtNewPromotion.Size = new System.Drawing.Size(318, 23);
            this.txtNewPromotion.TabIndex = 2;
            this.txtNewPromotion.Text = "Enter/ Modify New Promotion:";
            // 
            // frmNewPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(652, 314);
            this.Controls.Add(this.gbNewPromotion);
            this.Name = "frmNewPromotion";
            this.Text = "New Promotion";
            this.Load += new System.EventHandler(this.frmNewPromotion_Load);
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