﻿using DAHP.Application;
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
    public partial class frmNewQuery : Form
    {
        HRManagementService _Services;
        public frmNewQuery()
        {
            InitializeComponent();
            _Services = new HRManagementService();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var query = new Query();

            query.Title = txtSubject.Text;
            query.QueryDetail = txtDetail.Text;
            query.ReasonForQuery = txtReason.Text;
            query.QueryDate = dtpDate.Value.Date;
          //  query.EmploymentId = cbxQueriedBy;
        }

       
    }
}
