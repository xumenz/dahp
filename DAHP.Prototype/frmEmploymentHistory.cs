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
        //public bool Cancel = false;
        public frmEmploymentHistory()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          //  if (btnCancel = Click()
          //  {
          //      Console.WriteLine("Are you sure you want to Cancel");
          //  }
          //else
          //  {
                
          //  }
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

            //frmEmploymentHistory Save = new frmEmploymentHistory();
            //Save.

        }

        private void dtpEntry_ValueChanged(object sender, EventArgs e)
        {
            DateTime StartDate = Convert.ToDateTime(dtpStartDate);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime EndDate = Convert.ToDateTime(dtpEndDate);
        }
    }
}
