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
    public partial class AssetForm : Form
    {
        private Organization org = new Organization();
        private Asset ast = new Asset();

        public AssetForm()
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

        public Asset NewAst
        {
            get
            {
                return ast;
            }
        }

        private void AssetForm_Load(object sender, EventArgs e)
        {
            this.Text = "Add new asset to " + org.Name;
            ast.OrganizationID = org.OrganizationID;
        }

        private void txtTypeID_TextChanged(object sender, EventArgs e)
        {
            ast.TypeID = Convert.ToInt32(txtTypeID.Text);
        }

        private void txtAssetNumber_TextChanged(object sender, EventArgs e)
        {
            ast.AssetNumber = txtAssetNumber.Text;
        }

        private void txtLoanNumber_TextChanged(object sender, EventArgs e)
        {
            ast.LoanNumber = txtLoanNumber.Text;
        }

        private void txtMortgagorName_TextChanged(object sender, EventArgs e)
        {
            ast.MortgagorName = txtMortgagorName.Text;
        }

        private void txtHudCase_TextChanged(object sender, EventArgs e)
        {
            ast.HudCaseNumber = txtHudCase.Text;
        }

        private void dtpVacantDate_ValueChanged(object sender, EventArgs e)
        {
            ast.FirstTimeVacantDate = dtpVacantDate.Value;
        }

        private void txtLoanTypeID_TextChanged(object sender, EventArgs e)
        {
            int tempVal;
            ast.LoanTypeID = Int32.TryParse(txtLoanTypeID.Text, out tempVal) ? tempVal : (int?)null;
        }

        private void txtMortgagorPhone_TextChanged(object sender, EventArgs e)
        {
            ast.MortgagorPhone = txtMortgagorPhone.Text;
        }

        private void dtpConveyDate_ValueChanged(object sender, EventArgs e)
        {
            ast.ConveyanceDate = dtpConveyDate.Value;
        }

        private void chkBankrupt_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBankrupt.CheckState != CheckState.Indeterminate)
            {
                ast.InBankruptcyProtection = 
                    (chkBankrupt.CheckState == CheckState.Checked) ? true : false;
            }
        }
    }
}
