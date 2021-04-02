using FamilyTree.Adapters;
using FamilyTree.Concrete;
using FamilyTree.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree
{
    public partial class UserUI : Form
    {
        public UserUI()
        {
            InitializeComponent();
        }

        private void UserUI_Load(object sender, EventArgs e)
        {
            radioButtonUpper.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PersonForVerification person = new PersonForVerification();
            person.NationalityId = txtId.Text;
            person.TargetFirstName = txtTargetFirstName.Text;
            person.TargetLastName = txtTargetLastName.Text;
            person.TargetBirthYear = Convert.ToInt32(txtTargetBirthYear.Text);
            
            PersonManager personManager = new PersonManager(new NationalityIdServiceAdapter(), new CalculateUpperId());

            if (radioButtonLower.Checked)
                personManager = new PersonManager(new NationalityIdServiceAdapter(), new CalculateLowerId());

            var result = personManager.VerifyPerson(person);
            if (result.Success)
            {
                lblNationalityNumber.Text = person.TargetNationalityId;
            }
            else
            {
                lblNationalityNumber.Text = "Hatalı değer!!!";
            }
        }

        private void radioButtonUpper_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLower.Checked)
            {
                radioButtonLower.Checked = false;
                radioButtonUpper.Checked = true;
            }                
        }

        private void radioButtonLower_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUpper.Checked)
            {
                radioButtonUpper.Checked = false;
                radioButtonLower.Checked = true;
            }
        }

    }
}
