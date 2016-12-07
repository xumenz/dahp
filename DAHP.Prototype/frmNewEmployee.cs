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
    public partial class frmNewEmployee : Form
    {
        HRManagementService _Services;
        HRComponentService _ComponentService = new HRComponentService();
        Person _Person;
        ContactInfo _ContactInfo;
        ContactPhone _ContactPhone;
        Qualification _Qualification;
        Education _Education;
        NextOfKin _NextOfKin;

        public frmNewEmployee()
        {
            InitializeComponent();

            initEmployee();

        }

        private void initEmployee()
        {
            _Services = new HRManagementService();
            _Person = new Person();
            _Qualification = new Qualification();
            _Education = new Education();
            _ContactInfo = new ContactInfo();
            _ContactPhone = new ContactPhone();
            _NextOfKin = new NextOfKin();
        }



        void BindLgas()
        {
            this.cmbLGAofOrigin.DataSource = getLgas();

            cmbLGAofOrigin.DisplayMember = "LocalGovernmentName";
            cmbLGAofOrigin.ValueMember = "Id";
        }


        private List<Lga> getLgas()
        {
            return _ComponentService.GetLgas().ToList();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmNewEmployee_Load(object sender, EventArgs e)
        {
            BindLgas();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lblFinishDate_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void LGA_Click(object sender, EventArgs e)
        {

        }

        private void tpContactPhones_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (IsValidEntry())
            {
                _Services.createPerson(_Person);
                _Services.createEducation(_Education);
               // _Services.createProfessionalQualification(_Qualification);
                

                MessageBox.Show("Employee Details Added Successfully");
            }
        }

        private bool IsValidEntry()
        {
            assignValues();
            if (String.IsNullOrEmpty (_Person.FirstName) && String.IsNullOrEmpty(_Person.Surname))
            {
                return false;
            }
            throw new NotImplementedException();
        }

       void assignValues()
        {
            _Person.FirstName = txtFirstname.Text;
            _Person.Othernames = txtMiddleName.Text;
            _Person.Surname = txtSurname.Text;
            _Person.Gender = getGender();
            _Person.DateofBirth = dtpBirthDate.Value.Date;
      //      _Person.Lga = cmbLGAofOrigin;


        //  _ContactInfo.AddressType = cmbAddressType.; 
           _ContactInfo.Address = txtAddress.Text;
           _ContactInfo.Email = txtEmail.Text;
        //   _ContactInfo.lgaId = cmbLGA.

           _ContactPhone.Phonenumber = txtPhoneNumber.Text;
           _ContactPhone.Phonenumber = txtPhoneNumber2.Text;

           _NextOfKin.Firstname = txtFName.Text;
           _NextOfKin.OtherName = txtMName.Text;
           _NextOfKin.Surname = txtSName.Text;
           _NextOfKin.Relationship = txtRelationship.Text;
           //_NextOfKin.PhoneNumber = 
           _NextOfKin.ContactAddress = txtNKContactAddress.Text;
         //  _NextOfKin.DateOfBirth =

       //  _Education.CertificateIssueDate = cmbCertificateIssuseDate.
           _Education.FinishDate = dtpFinishDate.Value.Date;
           _Education.StartDate = dtpStartDate.Value.Date;
           _Education.SchoolObtained = txtSchoolObtained.Text;
         //  _Education.QualificationId = CmbDegreeName.

           
           _Qualification.DateObtained = dtpQualificationDate.Value.Date;
          // _Qualification.QualificationName = cmbQualificationName.;
           }

        private Gender getGender()
        {
            if (rdbMale.Checked)
            {
                return Gender.Male;
            }

            else
            {
                return Gender.Female;
            }

        }
    }
}
