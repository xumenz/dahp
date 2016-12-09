using DAHP.Application;
using DAHP.Domain;
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
    public partial class frmUnit : Form
    {

        HRManagementService _ManagementService = new HRManagementService();

        Department CurrentDepartment;
        public frmUnit(Department _department)
        {
            InitializeComponent();
            if (_department == null)
            {
                throw new InvalidOperationException("A valid Department information is required");
            }

            CurrentDepartment = _department;

            lblDepartmentName.Text = CurrentDepartment.DepartmentName;
           
        }

        private void frmUnit_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbSave_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidEntry())
            {
                var unit = new Unit();
                unit.DepartmentId = CurrentDepartment.Id;
                unit.UnitName = txtUnit.Text;


                if (_ManagementService.createUnit(unit) != Guid.Empty)
                {
                    MessageBox.Show("Unit created successfully");
                    ResetControl();
                }

            }
        }

       

    private void ResetControl()
        {
            txtUnit.Clear();
        }

     private bool IsValidEntry()
    {
 	   if (string.IsNullOrEmpty(txtUnit.Text))
            {
                return false;
            }

            return true;
        }
    
    void frmUnit_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
