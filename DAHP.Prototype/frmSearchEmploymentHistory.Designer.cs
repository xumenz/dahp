namespace DAHP.Prototype
{
    partial class frmSearchEmploymentHistory
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.grpSearchResult = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grpSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpSearchResult, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.19777F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.80223F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 359);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_4);
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpSearch.Controls.Add(this.textBox1);
            this.grpSearch.Controls.Add(this.btnEnter);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.Color.Black;
            this.grpSearch.Location = new System.Drawing.Point(3, 3);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(601, 105);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            this.grpSearch.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(541, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(268, 60);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 34);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // grpSearchResult
            // 
            this.grpSearchResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchResult.Location = new System.Drawing.Point(3, 114);
            this.grpSearchResult.Name = "grpSearchResult";
            this.grpSearchResult.Size = new System.Drawing.Size(601, 242);
            this.grpSearchResult.TabIndex = 1;
            this.grpSearchResult.TabStop = false;
            this.grpSearchResult.Text = "Search Result";
            this.grpSearchResult.Enter += new System.EventHandler(this.grpSearchResult_Enter);
            // 
            // frmSearchEmploymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 359);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSearchEmploymentHistory";
            this.Text = "Search Employment History";
            this.Load += new System.EventHandler(this.frmSearchEmploymentHistory_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox grpSearchResult;







    }
}