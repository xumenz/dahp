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
    public partial class frmState : Form
    {

        HRComponentService _Service;

        State CurrentState = null;
        public frmState()
        {
            InitializeComponent();

            _Service = new HRComponentService();

           
        }



        public frmState(State state)
        {
            InitializeComponent();

            _Service = new HRComponentService();

            CurrentState = state;
        }


        private void frmState_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(IsValidEntry()){

                if (CurrentState == null)
                {
                    var state = new State();

                    state.StateName = txtStateName.Text;


                    if (_Service.createState(state) != Guid.Empty)
                    {
                        MessageBox.Show("State created successfully");
                        ResetControl();
                    }
                }
                else
                {

                    CurrentState.StateName = txtStateName.Text;
                    _Service.UpdateState(CurrentState);
                }

         
            }
           

        }

        private void ResetControl()
        {
            txtStateName.Clear();
        }

        private bool IsValidEntry()
        {
            if (String.IsNullOrEmpty(txtStateName.Text))
            {
                MessageBox.Show("No input information found");
                return false;
            }

            return true;
        }
    }
}
