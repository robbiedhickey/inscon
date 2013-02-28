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
    using System.Collections;
    using System.Diagnostics.CodeAnalysis;

    using Enterprise.DAL.Models;
    using Enterprise.DAL.Repositories;

    public partial class Form1 : Form
    {
        private IOrganizationRepository orgRep;
        private ILocationRepository locRep;
        private IAssetRepository astRep;
        private IList<Organization> orgBindingList;
        private EnterpriseDbContext context;

        public Form1()
        {
            InitializeComponent();

            //organizationBindingSource.DataSource = 
            //    new OrganizationRepository(
            //        new EnterpriseDbContext()).Get();

            context = new EnterpriseDbContext();
            
            orgRep = new OrganizationRepository(context);
            locRep = new LocationRepository(context);
            astRep = new AssetRepository(context);

            orgBindingList = orgRep.Get();

            organizationBindingSource.DataSource = orgBindingList;

        }

        private void organizationDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAddOrg_Click(object sender, EventArgs e)
        {
            OrganizationForm dlg = new OrganizationForm();

            dlg.ShowDialog(this);

            if (dlg.DialogResult == DialogResult.OK)
            {
                Organization org = dlg.NewOrg;

                orgRep.Insert(org);

                orgRep.Save();

                organizationBindingSource.DataSource = orgRep.Get();
            }
        }

        private void assetsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            btnRemoveOrg.Enabled = assetsBindingSource.Count.Equals(0) &&
                                   locationsBindingSource.Count.Equals(0);
        }

        private void btnRemoveOrg_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            if (organizationDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow row = organizationDataGridView.SelectedRows[0];
                Organization org = row.DataBoundItem as Organization;

                AssetForm dlg = new AssetForm();
                dlg.NewOrg = org;
                dlg.ShowDialog();

                if (dlg.DialogResult == DialogResult.OK)
                {
                    Asset ast = dlg.NewAst;

                    org.Assets.Add(ast);

                    orgRep.Save();

                    organizationBindingSource.DataSource = orgRep.Get();
                }
            }
        }

        private void btnRemoveAsset_Click(object sender, EventArgs e)
        {

        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (organizationDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow row = organizationDataGridView.SelectedRows[0];
                Organization org = row.DataBoundItem as Organization;

                LocationForm dlg = new LocationForm();
                dlg.NewOrg = org;
                dlg.ShowDialog();

                if (dlg.DialogResult == DialogResult.OK)
                {
                    Location loc = dlg.NewLoc;

                    org.Locations.Add(loc);

                    orgRep.Save();

                    organizationBindingSource.DataSource = orgRep.Get();
                }
            }
        }

        private void btnRemoveLocation_Click(object sender, EventArgs e)
        {
            if (locationsDataGridView.SelectedRows.Count == 1 && 
                organizationDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow orgRow = organizationDataGridView.SelectedRows[0];
                Organization org = orgRow.DataBoundItem as Organization;

                DataGridViewRow locRow = locationsDataGridView.SelectedRows[0];
                Location loc = locRow.DataBoundItem as Location;

                DialogResult dr = MessageBox.Show(
                    "Are you sure you wish to delete " + loc.Name + "?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    locRep.Delete(loc.LocationID);
                    orgBindingList.Clear();
                    orgRep = new OrganizationRepository(context);
                    orgBindingList = orgRep.Get();
                    organizationBindingSource.DataSource = orgBindingList;
                }
            }
        }
    }
}
