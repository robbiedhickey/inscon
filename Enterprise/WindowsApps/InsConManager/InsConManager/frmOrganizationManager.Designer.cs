namespace InsConManager
{
    partial class FrmOrganizationManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gvOrganizations = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblOrgStatus = new System.Windows.Forms.Label();
            this.btnSaveOrg = new System.Windows.Forms.Button();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrgCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrgId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrgTabs = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.gvUsers = new System.Windows.Forms.DataGridView();
            this.tabLocations = new System.Windows.Forms.TabPage();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrganizations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.OrgTabs.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(5, 746);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1260, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 29);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gvOrganizations);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(1260, 717);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.TabIndex = 2;
            // 
            // gvOrganizations
            // 
            this.gvOrganizations.AllowUserToAddRows = false;
            this.gvOrganizations.AllowUserToDeleteRows = false;
            this.gvOrganizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrganizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colCode,
            this.colName,
            this.Column2,
            this.EntityId});
            this.gvOrganizations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvOrganizations.Location = new System.Drawing.Point(5, 5);
            this.gvOrganizations.MultiSelect = false;
            this.gvOrganizations.Name = "gvOrganizations";
            this.gvOrganizations.ReadOnly = true;
            this.gvOrganizations.RowHeadersWidth = 25;
            this.gvOrganizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvOrganizations.Size = new System.Drawing.Size(360, 707);
            this.gvOrganizations.TabIndex = 0;
            this.gvOrganizations.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(5, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblOrgStatus);
            this.splitContainer2.Panel1.Controls.Add(this.btnSaveOrg);
            this.splitContainer2.Panel1.Controls.Add(this.comboType);
            this.splitContainer2.Panel1.Controls.Add(this.comboStatus);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.txtOrgName);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.txtOrgCode);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.txtOrgId);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.OrgTabs);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Size = new System.Drawing.Size(876, 707);
            this.splitContainer2.SplitterDistance = 244;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblOrgStatus
            // 
            this.lblOrgStatus.AutoSize = true;
            this.lblOrgStatus.Location = new System.Drawing.Point(204, 202);
            this.lblOrgStatus.Name = "lblOrgStatus";
            this.lblOrgStatus.Size = new System.Drawing.Size(0, 13);
            this.lblOrgStatus.TabIndex = 12;
            // 
            // btnSaveOrg
            // 
            this.btnSaveOrg.Location = new System.Drawing.Point(109, 193);
            this.btnSaveOrg.Name = "btnSaveOrg";
            this.btnSaveOrg.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOrg.TabIndex = 11;
            this.btnSaveOrg.Text = "Save";
            this.btnSaveOrg.UseVisualStyleBackColor = true;
            this.btnSaveOrg.Click += new System.EventHandler(this.btnSaveOrg_Click);
            // 
            // comboType
            // 
            this.comboType.DisplayMember = "Value";
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(109, 138);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(204, 21);
            this.comboType.TabIndex = 10;
            this.comboType.ValueMember = "LookupID";
            // 
            // comboStatus
            // 
            this.comboStatus.DisplayMember = "Value";
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(109, 165);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(204, 21);
            this.comboStatus.TabIndex = 9;
            this.comboStatus.ValueMember = "LookupID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type:";
            // 
            // txtOrgName
            // 
            this.txtOrgName.Location = new System.Drawing.Point(108, 112);
            this.txtOrgName.MaxLength = 50;
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(333, 20);
            this.txtOrgName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // txtOrgCode
            // 
            this.txtOrgCode.Location = new System.Drawing.Point(108, 86);
            this.txtOrgCode.MaxLength = 6;
            this.txtOrgCode.Name = "txtOrgCode";
            this.txtOrgCode.Size = new System.Drawing.Size(70, 20);
            this.txtOrgCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code:";
            // 
            // txtOrgId
            // 
            this.txtOrgId.Location = new System.Drawing.Point(108, 60);
            this.txtOrgId.Name = "txtOrgId";
            this.txtOrgId.ReadOnly = true;
            this.txtOrgId.Size = new System.Drawing.Size(100, 20);
            this.txtOrgId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RecordId: ";
            // 
            // OrgTabs
            // 
            this.OrgTabs.Controls.Add(this.tabUsers);
            this.OrgTabs.Controls.Add(this.tabLocations);
            this.OrgTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrgTabs.Location = new System.Drawing.Point(5, 5);
            this.OrgTabs.Name = "OrgTabs";
            this.OrgTabs.SelectedIndex = 0;
            this.OrgTabs.Size = new System.Drawing.Size(866, 449);
            this.OrgTabs.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.gvUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(5);
            this.tabUsers.Size = new System.Drawing.Size(858, 423);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // gvUsers
            // 
            this.gvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.OrganizationId,
            this.FullName,
            this.Status,
            this.EntityNumber});
            this.gvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvUsers.Location = new System.Drawing.Point(5, 5);
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUsers.Size = new System.Drawing.Size(848, 413);
            this.gvUsers.TabIndex = 0;
            // 
            // tabLocations
            // 
            this.tabLocations.Location = new System.Drawing.Point(4, 22);
            this.tabLocations.Name = "tabLocations";
            this.tabLocations.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocations.Size = new System.Drawing.Size(858, 423);
            this.tabLocations.TabIndex = 1;
            this.tabLocations.Text = "Locations";
            this.tabLocations.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OrganizationID";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 50;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Status";
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 62;
            // 
            // EntityId
            // 
            this.EntityId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EntityId.DataPropertyName = "EntityNumber";
            this.EntityId.HeaderText = "EntityNumber";
            this.EntityId.Name = "EntityId";
            this.EntityId.ReadOnly = true;
            this.EntityId.Width = 95;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "Id";
            this.UserId.Name = "UserId";
            this.UserId.Width = 41;
            // 
            // OrganizationId
            // 
            this.OrganizationId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrganizationId.DataPropertyName = "OrganizationId";
            this.OrganizationId.HeaderText = "OrgId";
            this.OrganizationId.Name = "OrganizationId";
            this.OrganizationId.Width = 58;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 62;
            // 
            // EntityNumber
            // 
            this.EntityNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EntityNumber.DataPropertyName = "EntityNumber";
            this.EntityNumber.HeaderText = "EntityNumber";
            this.EntityNumber.Name = "EntityNumber";
            this.EntityNumber.Width = 95;
            // 
            // FrmOrganizationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 773);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmOrganizationManager";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Organization Manager";
            this.Load += new System.EventHandler(this.frmOrganizationManager_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrganizations)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.OrgTabs.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gvOrganizations;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrgCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrgId;
        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveOrg;
        private System.Windows.Forms.TabControl OrgTabs;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabLocations;
        private System.Windows.Forms.DataGridView gvUsers;
        private System.Windows.Forms.Label lblOrgStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntityNumber;
    }
}

