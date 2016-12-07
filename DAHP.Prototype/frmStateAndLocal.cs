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
    public partial class frmStateAndLocal : Form
    {


        HRComponentService _Service = new HRComponentService();
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
            frmLga frm = new frmLga(currentState());
            frm.ShowDialog();
        }

        private void updateStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentState() != null)
            {
                frmState frm = new frmState(currentState());
                frm.ShowDialog();
            }
        }

        private State currentState()
        {
            var current = (State)bsStates.Current;
            return current;
        }

        private void frmStateAndLocal_Load(object sender, EventArgs e)
        {
            BindStates();
        }

        private void BindStates()
        {
            //IList<State> ListOfStates = GetStates();

            bsStates.DataSource = GetStates();

            bnStates.BindingSource = bsStates;

            dgvState.DataSource = bsStates;
        }

        void BindLgas(Guid stateId)
        {
            bsLgas.DataSource = getLgas(stateId);

            bnLgas.BindingSource = bsLgas;

            dgvLga.DataSource = bsLgas;
        }


        private List<Lga> getLgas(Guid stateId)
        {
            return _Service.GetLgasByState(stateId).ToList();
        }
        private List<State> GetStates()
        {
            return _Service.GetStates().ToList();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindStates();
        }

        private void dgvState_SelectionChanged(object sender, EventArgs e)
        {
            if (currentState() != null)
            {
                BindLgas(currentState().Id);
            }
        }
    }
}
