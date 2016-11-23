using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAHP.Prototype
{
    public partial class frmEmploymentHistory : Form
    {
        public frmEmploymentHistory()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string EmployeeName = txtEmployeeName.Text;
        }

        private void txtPreviousDepartment_TextChanged(object sender, EventArgs e)
        {
            string PreviousDepartment = txtPreviousDepartment.Text;
        }

        private void txtPreviousUnit_TextChanged(object sender, EventArgs e)
        {
            string PreviousUnit = txtPreviousUnit.Text;
        }

        private void txtPreviousSalary_TextChanged(object sender, EventArgs e)
        {
            double PreviousSalary = Convert.ToDouble(txtPreviousSalary.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void dtpEntry_ValueChanged(object sender, EventArgs e)
        {
            DateTime DateofEntry = Convert.ToDateTime(dtpEntry);
        }
    }
}
