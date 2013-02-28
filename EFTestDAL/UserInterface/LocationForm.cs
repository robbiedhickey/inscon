using Enterprise.DAL.Models;
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
    public partial class LocationForm : Form
    {
        private Organization org = new Organization();
        private Location loc = new Location();

        public LocationForm()
        {
            InitializeComponent();
        }

        public Organization NewOrg
        {
            set
            {
                org = value;
            }
        }

        public Location NewLoc
        {
            get
            {
                return loc;
            }
        }

        private void LocationForm_Load(object sender, EventArgs e)
        {
            this.Text = "Add new location to " + org.Name;
            loc.OrganizationID = org.OrganizationID;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            loc.Code = txtCode.Text.Trim().Length == 0 ? null : txtCode.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            loc.Name = txtName.Text;
        }

        private void txtTypeID_TextChanged(object sender, EventArgs e)
        {
            loc.TypeID = Convert.ToInt32(txtTypeID.Text);
        }
    }
}
