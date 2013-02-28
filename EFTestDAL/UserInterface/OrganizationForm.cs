using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    using Enterprise.DAL.Models;

    public partial class OrganizationForm : Form
    {
        Organization org = new Organization();

        public OrganizationForm()
        {
            InitializeComponent();
        }

        public Organization NewOrg
        {
            get
            {
                return org;
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            org.Code = txtCode.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            org.Name = txtName.Text;
        }

        private void txtTypeID_TextChanged(object sender, EventArgs e)
        {
            org.TypeID = Convert.ToInt32(txtTypeID.Text);
        }

        private void txtStatusID_TextChanged(object sender, EventArgs e)
        {
            org.StatusID = Convert.ToInt32(txtStatusID.Text);
        }
    }
}
