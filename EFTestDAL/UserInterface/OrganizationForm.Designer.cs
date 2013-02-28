namespace UserInterface
{
    partial class OrganizationForm
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
            this.lblStatusID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTypeID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.txtStatusID = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStatusID
            // 
            this.lblStatusID.Location = new System.Drawing.Point(168, 67);
            this.lblStatusID.Name = "lblStatusID";
            this.lblStatusID.Size = new System.Drawing.Size(59, 23);
            this.lblStatusID.TabIndex = 6;
            this.lblStatusID.Text = "Status ID:";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(168, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(12, 41);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(54, 23);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code:";
            // 
            // lblTypeID
            // 
            this.lblTypeID.Location = new System.Drawing.Point(12, 67);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(54, 23);
            this.lblTypeID.TabIndex = 4;
            this.lblTypeID.Text = "Type ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(473, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(392, 122);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtTypeID
            // 
            this.txtTypeID.Location = new System.Drawing.Point(72, 64);
            this.txtTypeID.MaxLength = 8;
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(60, 20);
            this.txtTypeID.TabIndex = 5;
            this.txtTypeID.TextChanged += new System.EventHandler(this.txtTypeID_TextChanged);
            // 
            // txtStatusID
            // 
            this.txtStatusID.Location = new System.Drawing.Point(233, 64);
            this.txtStatusID.MaxLength = 8;
            this.txtStatusID.Name = "txtStatusID";
            this.txtStatusID.Size = new System.Drawing.Size(60, 20);
            this.txtStatusID.TabIndex = 7;
            this.txtStatusID.TextChanged += new System.EventHandler(this.txtStatusID_TextChanged);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(72, 38);
            this.txtCode.MaxLength = 8;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(60, 20);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(233, 38);
            this.txtName.MaxLength = 75;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(315, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // OrganizationForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(565, 151);
            this.ControlBox = false;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtStatusID);
            this.Controls.Add(this.txtTypeID);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTypeID);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStatusID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrganizationForm";
            this.ShowInTaskbar = false;
            this.Text = "Add Organization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatusID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblTypeID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.TextBox txtStatusID;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
    }
}