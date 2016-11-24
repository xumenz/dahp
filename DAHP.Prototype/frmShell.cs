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
    public partial class frmShell : Form
    {
        public frmShell()
        {
            InitializeComponent();
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmShell_Load(object sender, EventArgs e)
        {

        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewEmployee frm = new frmNewEmployee();
            frm.ShowDialog();
        }

        private void newQualificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQualifications frm = new frmQualifications ();
            frm.ShowDialog();
        }

        private void newQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewQuery frm = new frmNewQuery();
            frm.ShowDialog();
        }

        private void newDesignationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewDesignation frm = new frmNewDesignation();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bayelsaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeManagement frm = new frmEmployeeManagement();
            frm.ShowDialog();
        }

        private void stateAndLGAManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStateAndLocal frm = new frmStateAndLocal();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
