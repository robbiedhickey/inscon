namespace UserInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.organizationDataGridView = new System.Windows.Forms.DataGridView();
            this.organzationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.assetsDataGridView = new System.Windows.Forms.DataGridView();
            this.locationsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnRemoveLocation = new System.Windows.Forms.Button();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.btnRemoveAsset = new System.Windows.Forms.Button();
            this.btnAddOrg = new System.Windows.Forms.Button();
            this.btnRemoveOrg = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.assetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.organizationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organzationBindingNavigator)).BeginInit();
            this.organzationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // organizationDataGridView
            // 
            this.organizationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.organizationDataGridView.AutoGenerateColumns = false;
            this.organizationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.organizationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.organizationDataGridView.DataSource = this.organizationBindingSource;
            this.organizationDataGridView.Location = new System.Drawing.Point(8, 28);
            this.organizationDataGridView.Name = "organizationDataGridView";
            this.organizationDataGridView.Size = new System.Drawing.Size(619, 117);
            this.organizationDataGridView.TabIndex = 0;
            this.organizationDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.organizationDataGridView_RowEnter);
            // 
            // organzationBindingNavigator
            // 
            this.organzationBindingNavigator.AddNewItem = null;
            this.organzationBindingNavigator.BindingSource = this.organizationBindingSource;
            this.organzationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.organzationBindingNavigator.DeleteItem = null;
            this.organzationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripSeparator1});
            this.organzationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.organzationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.organzationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.organzationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.organzationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.organzationBindingNavigator.Name = "organzationBindingNavigator";
            this.organzationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.organzationBindingNavigator.Size = new System.Drawing.Size(720, 25);
            this.organzationBindingNavigator.TabIndex = 1;
            this.organzationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // assetsDataGridView
            // 
            this.assetsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assetsDataGridView.AutoGenerateColumns = false;
            this.assetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.assetsDataGridView.DataSource = this.assetsBindingSource;
            this.assetsDataGridView.Location = new System.Drawing.Point(8, 151);
            this.assetsDataGridView.Name = "assetsDataGridView";
            this.assetsDataGridView.Size = new System.Drawing.Size(619, 131);
            this.assetsDataGridView.TabIndex = 2;
            this.assetsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.assetsDataGridView_DataBindingComplete);
            // 
            // locationsDataGridView
            // 
            this.locationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationsDataGridView.AutoGenerateColumns = false;
            this.locationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn24});
            this.locationsDataGridView.DataSource = this.locationsBindingSource;
            this.locationsDataGridView.Location = new System.Drawing.Point(8, 288);
            this.locationsDataGridView.Name = "locationsDataGridView";
            this.locationsDataGridView.Size = new System.Drawing.Size(619, 130);
            this.locationsDataGridView.TabIndex = 3;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLocation.Location = new System.Drawing.Point(633, 366);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(75, 23);
            this.btnAddLocation.TabIndex = 4;
            this.btnAddLocation.Text = "Add";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // btnRemoveLocation
            // 
            this.btnRemoveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveLocation.Location = new System.Drawing.Point(633, 395);
            this.btnRemoveLocation.Name = "btnRemoveLocation";
            this.btnRemoveLocation.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveLocation.TabIndex = 5;
            this.btnRemoveLocation.Text = "Remove";
            this.btnRemoveLocation.UseVisualStyleBackColor = true;
            this.btnRemoveLocation.Click += new System.EventHandler(this.btnRemoveLocation_Click);
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAsset.Location = new System.Drawing.Point(633, 230);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(75, 23);
            this.btnAddAsset.TabIndex = 6;
            this.btnAddAsset.Text = "Add";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // btnRemoveAsset
            // 
            this.btnRemoveAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAsset.Location = new System.Drawing.Point(633, 259);
            this.btnRemoveAsset.Name = "btnRemoveAsset";
            this.btnRemoveAsset.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAsset.TabIndex = 7;
            this.btnRemoveAsset.Text = "Remove";
            this.btnRemoveAsset.UseVisualStyleBackColor = true;
            this.btnRemoveAsset.Click += new System.EventHandler(this.btnRemoveAsset_Click);
            // 
            // btnAddOrg
            // 
            this.btnAddOrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOrg.Location = new System.Drawing.Point(633, 93);
            this.btnAddOrg.Name = "btnAddOrg";
            this.btnAddOrg.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrg.TabIndex = 9;
            this.btnAddOrg.Text = "Add";
            this.btnAddOrg.UseVisualStyleBackColor = true;
            this.btnAddOrg.Click += new System.EventHandler(this.btnAddOrg_Click);
            // 
            // btnRemoveOrg
            // 
            this.btnRemoveOrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveOrg.Location = new System.Drawing.Point(633, 122);
            this.btnRemoveOrg.Name = "btnRemoveOrg";
            this.btnRemoveOrg.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveOrg.TabIndex = 10;
            this.btnRemoveOrg.Text = "Remove";
            this.btnRemoveOrg.UseVisualStyleBackColor = true;
            this.btnRemoveOrg.Click += new System.EventHandler(this.btnRemoveOrg_Click);
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "LocationID";
            this.dataGridViewTextBoxColumn23.HeaderText = "ID";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 50;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn25.HeaderText = "Code";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 60;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn24.HeaderText = "Name";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "Locations";
            this.locationsBindingSource.DataSource = this.organizationBindingSource;
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataSource = typeof(Enterprise.DAL.Models.Organization);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AssetID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "AssetNumber";
            this.dataGridViewTextBoxColumn12.HeaderText = "AssetNumber";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "LoanNumber";
            this.dataGridViewTextBoxColumn13.HeaderText = "LoanNumber";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "LoanTypeID";
            this.dataGridViewTextBoxColumn14.HeaderText = "LoanTypeID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MortgagorName";
            this.dataGridViewTextBoxColumn15.HeaderText = "MortgagorName";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "MortgagorPhone";
            this.dataGridViewTextBoxColumn16.HeaderText = "MortgagorPhone";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "HudCaseNumber";
            this.dataGridViewTextBoxColumn17.HeaderText = "HudCaseNumber";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ConveyanceDate";
            this.dataGridViewTextBoxColumn18.HeaderText = "ConveyanceDate";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "FirstTimeVacantDate";
            this.dataGridViewTextBoxColumn19.HeaderText = "FirstTimeVacantDate";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "InBankruptcyProtection";
            this.dataGridViewTextBoxColumn20.HeaderText = "InBankruptcyProtection";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // assetsBindingSource
            // 
            this.assetsBindingSource.DataMember = "Assets";
            this.assetsBindingSource.DataSource = this.organizationBindingSource;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrganizationID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrganizationID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn3.HeaderText = "Code";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TypeID";
            this.dataGridViewTextBoxColumn4.HeaderText = "TypeID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StatusID";
            this.dataGridViewTextBoxColumn5.HeaderText = "StatusID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Assets";
            this.dataGridViewTextBoxColumn6.HeaderText = "Assets";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Locations";
            this.dataGridViewTextBoxColumn7.HeaderText = "Locations";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 432);
            this.Controls.Add(this.btnRemoveOrg);
            this.Controls.Add(this.btnAddOrg);
            this.Controls.Add(this.btnRemoveAsset);
            this.Controls.Add(this.btnAddAsset);
            this.Controls.Add(this.btnRemoveLocation);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.locationsDataGridView);
            this.Controls.Add(this.assetsDataGridView);
            this.Controls.Add(this.organzationBindingNavigator);
            this.Controls.Add(this.organizationDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.organizationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organzationBindingNavigator)).EndInit();
            this.organzationBindingNavigator.ResumeLayout(false);
            this.organzationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource organizationBindingSource;
        private System.Windows.Forms.DataGridView organizationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingNavigator organzationBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource assetsBindingSource;
        private System.Windows.Forms.DataGridView assetsDataGridView;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private System.Windows.Forms.DataGridView locationsDataGridView;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnRemoveLocation;
        private System.Windows.Forms.Button btnAddAsset;
        private System.Windows.Forms.Button btnRemoveAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnAddOrg;
        private System.Windows.Forms.Button btnRemoveOrg;
    }
}

