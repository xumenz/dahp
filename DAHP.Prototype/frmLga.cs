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
    public partial class frmLga : Form
    {
        HRComponentService _Service;

        State CurrentState;
        public frmLga(State _state)
        {

            if (_state == null)
            {
                throw new InvalidOperationException("A valid State information is required");
            }

            CurrentState = _state;

            InitializeComponent();
            _Service = new HRComponentService();

            lblStateInfo.Text = CurrentState.StateName;
        }

        private void frmLga_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (IsValidEntry())
            {
                var lga = new Lga();
                lga.StateId = CurrentState.Id;
                lga.LocalGovernmentName = txtLgaName.Text;

                if (_Service.createLga(lga) != Guid.Empty)
                {
                    MessageBox.Show("Lga created successfully");
                    ResetControl();
                }



            }

        }

        private bool IsValidEntry()
        {
            if (string.IsNullOrEmpty(txtLgaName.Text))
            {
                return false;
            }

            return true;
        }
        void ResetControl()
        {
            txtLgaName.Clear();
        }
    }



}
