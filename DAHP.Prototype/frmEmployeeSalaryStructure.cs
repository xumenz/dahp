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
    public partial class frmEmployeeSalaryStructure : Form
    {
        public frmEmployeeSalaryStructure()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double Hours, Rate;
            //double GrossPay, FederalTax, StateTax, NetPay;
            //Hours = Convert.ToDouble(txtAmountWorked.Text);
            //Rate = Convert.ToDouble(txtHourlyDailyMonthlyRate.Text);
            //GrossPay = Hours * Rate;
            //FederalTax = GrossPay * 0.15;
            //StateTax = GrossPay * 5/100;
            //NetPay = GrossPay - (FederalTax + StateTax);

            //txtGrossPay.Text = GrossPay.ToString("c");
            //txtStateTax.Text = StateTax.ToString("c");
            //txtFederalTax.Text = FederalTax.ToString("c");
            //txtNetPay.Text = NetPay.ToString("c");

        }

        private void frmTaxId_Load(object sender, EventArgs e)
        {

        }

        private void txtHourlyRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoursWorked_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSSN_TextChanged(object sender, EventArgs e)
        {
            double SSN = Convert.ToDouble(txtSSN.Text);
        }

        private void txtLevelGrade_TextChanged(object sender, EventArgs e)
        {
            string LevelGrade = Convert.ToString(txtGrade.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();    
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            string Unit = Convert.ToString(txtUnit.Text);
        }

        private void txtLevel_TextChanged(object sender, EventArgs e)
        {
            int Level = Convert.ToInt32(txtLevel.Text);
        }

        private void txtTaxID_TextChanged(object sender, EventArgs e)
        {
            string TaxID = Convert.ToString(txtTaxID.Text);
        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {
            string Department = Convert.ToString(txtDepartment.Text);
        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            string EmployeeName = Convert.ToString(txtEmployeeName.Text);
        }

        private void btnNetPay_Click(object sender, EventArgs e)
        {

            double Hours, Rate;
            double GrossPay, FederalTax, StateTax, NetPay;
            Hours = Convert.ToDouble(txtAmountWorked.Text);
            Rate = Convert.ToDouble(txtHourlyDailyMonthlyRate.Text);
            GrossPay = Hours * Rate;
            FederalTax = GrossPay * 0.15;
            StateTax = GrossPay * 5 / 100;
            NetPay = GrossPay - (FederalTax + StateTax);

            txtGrossPay.Text = GrossPay.ToString("c");
            txtStateTax.Text = StateTax.ToString("c");
            txtFederalTax.Text = FederalTax.ToString("c");
            txtNetPay.Text = NetPay.ToString("c");
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int Step = Convert.ToInt32(numStep.Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int Grade = Convert.ToInt32(numGrade.Text);
        }

        private void numLevel_ValueChanged(object sender, EventArgs e)
        {
            int Level = Convert.ToInt32(numLevel.Text);
        }
    }
}
