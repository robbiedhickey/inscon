using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Service;

namespace InsConManager
{
    public partial class FrmOrganizationManager : Form
    {
        private Organization _org;
        private OrganizationService _orgService;
        private int _orgId;
        private List<Organization> _orgs;


        // Constructor
        public FrmOrganizationManager()
        {
            InitializeComponent();

            comboStatus.DataSource = new LookupService().GetLookupValuesByGroupId(1);
            comboType.DataSource = new LookupService().GetLookupValuesByGroupId(2);
            gvOrganizations.AutoGenerateColumns = false;
            gvUsers.AutoGenerateColumns = false;
        }

        #region private events

        private void frmOrganizationManager_Load(object sender, EventArgs e)
        {
            LoadOrganizationGrid();
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            lblOrgStatus.Text = String.Empty;
            _orgId = Convert.ToInt32(gvOrganizations.SelectedRows[0].Cells[0].Value);
            _org = new OrganizationService().GetOrganizationById(_orgId);

            PopulateOrganizationForm();
            LoadUsersGrid();
        }

        private void btnSaveOrg_Click(object sender, EventArgs e)
        {
            _orgService = new OrganizationService();
            _org = _orgService.GetOrganizationById(_orgId);
            _org.Name = txtOrgName.Text;
            _org.Code = txtOrgCode.Text;
            _org.StatusID = Convert.ToInt32(comboStatus.SelectedValue);
            _org.TypeID = Convert.ToInt32(comboType.SelectedValue);

            lblOrgStatus.Text = @"Record changed = : " + _org.IsChanged().ToString();

            _orgId = _orgService.SaveRecord(_org);

        }

        #endregion

        #region private methods

        /// <summary>
        ///     Loads the Organization grid with data from the database
        /// </summary>
        private void LoadOrganizationGrid()
        {
            _orgs = new OrganizationService().GetAllOrganizations();
            gvOrganizations.DataSource = _orgs;
        }

        /// <summary>
        ///     Loads the users for the selected Organization in the users grid.
        /// </summary>
        private void LoadUsersGrid()
        {
            gvUsers.DataSource = _org.Users;
        }

        /// <summary>
        ///     Populates the Organization form with the selected Organization data.
        /// </summary>
        private void PopulateOrganizationForm()
        {
            txtOrgId.Text = _org.OrganizationID.ToString(CultureInfo.InvariantCulture);
            txtOrgName.Text = _org.Name;
            txtOrgCode.Text = _org.Code;

            comboStatus.SelectedValue = _org.StatusID;
            comboType.SelectedValue = _org.TypeID;
        }

        #endregion
    }
}