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
    public partial class frmStateAndLocal : Form
    {
        public frmStateAndLocal()
        {
            InitializeComponent();
        }

        private void tsbNewState_Click(object sender, EventArgs e)
        {
            frmState frm = new frmState();
            frm.ShowDialog();
        }

        private void tsbNewLga_Click(object sender, EventArgs e)
        {
            frmNewPromotion frm = new frmNewPromotion();
            frm.ShowDialog();
        }
    }
}
