namespace UserInterface
{
    partial class AssetForm
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
            this.txtLoanTypeID = new System.Windows.Forms.TextBox();
            this.txtMortgagorName = new System.Windows.Forms.TextBox();
            this.txtAssetNumber = new System.Windows.Forms.TextBox();
            this.txtLoanNumber = new System.Windows.Forms.TextBox();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.txtHudCase = new System.Windows.Forms.TextBox();
            this.dtpVacantDate = new System.Windows.Forms.DateTimePicker();
            this.dtpConveyDate = new System.Windows.Forms.DateTimePicker();
            this.chkBankrupt = new System.Windows.Forms.CheckBox();
            this.lblVacantDate = new System.Windows.Forms.Label();
            this.lblConveyDate = new System.Windows.Forms.Label();
            this.lblHudCase = new System.Windows.Forms.Label();
            this.lblMortgagorPhone = new System.Windows.Forms.Label();
            this.lblMortgagorName = new System.Windows.Forms.Label();
            this.lblLoanTypeID = new System.Windows.Forms.Label();
            this.lblLoanNumber = new System.Windows.Forms.Label();
            this.lblAssetNumber = new System.Windows.Forms.Label();
            this.lblTypeID = new System.Windows.Forms.Label();
            this.txtMortgagorPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoanTypeID
            // 
            this.txtLoanTypeID.Location = new System.Drawing.Point(500, 90);
            this.txtLoanTypeID.Name = "txtLoanTypeID";
            this.txtLoanTypeID.Size = new System.Drawing.Size(100, 20);
            this.txtLoanTypeID.TabIndex = 8;
            this.txtLoanTypeID.TextChanged += new System.EventHandler(this.txtLoanTypeID_TextChanged);
            // 
            // txtMortgagorName
            // 
            this.txtMortgagorName.Location = new System.Drawing.Point(143, 116);
            this.txtMortgagorName.MaxLength = 40;
            this.txtMortgagorName.Name = "txtMortgagorName";
            this.txtMortgagorName.Size = new System.Drawing.Size(229, 20);
            this.txtMortgagorName.TabIndex = 10;
            this.txtMortgagorName.TextChanged += new System.EventHandler(this.txtMortgagorName_TextChanged);
            // 
            // txtAssetNumber
            // 
            this.txtAssetNumber.Location = new System.Drawing.Point(143, 64);
            this.txtAssetNumber.MaxLength = 20;
            this.txtAssetNumber.Name = "txtAssetNumber";
            this.txtAssetNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAssetNumber.TabIndex = 4;
            this.txtAssetNumber.TextChanged += new System.EventHandler(this.txtAssetNumber_TextChanged);
            // 
            // txtLoanNumber
            // 
            this.txtLoanNumber.Location = new System.Drawing.Point(143, 90);
            this.txtLoanNumber.MaxLength = 30;
            this.txtLoanNumber.Name = "txtLoanNumber";
            this.txtLoanNumber.Size = new System.Drawing.Size(100, 20);
            this.txtLoanNumber.TabIndex = 6;
            this.txtLoanNumber.TextChanged += new System.EventHandler(this.txtLoanNumber_TextChanged);
            // 
            // txtTypeID
            // 
            this.txtTypeID.Location = new System.Drawing.Point(143, 38);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(100, 20);
            this.txtTypeID.TabIndex = 2;
            this.txtTypeID.TextChanged += new System.EventHandler(this.txtTypeID_TextChanged);
            // 
            // txtHudCase
            // 
            this.txtHudCase.Location = new System.Drawing.Point(143, 142);
            this.txtHudCase.MaxLength = 20;
            this.txtHudCase.Name = "txtHudCase";
            this.txtHudCase.Size = new System.Drawing.Size(100, 20);
            this.txtHudCase.TabIndex = 14;
            this.txtHudCase.TextChanged += new System.EventHandler(this.txtHudCase_TextChanged);
            // 
            // dtpVacantDate
            // 
            this.dtpVacantDate.Location = new System.Drawing.Point(143, 168);
            this.dtpVacantDate.Name = "dtpVacantDate";
            this.dtpVacantDate.Size = new System.Drawing.Size(200, 20);
            this.dtpVacantDate.TabIndex = 18;
            this.dtpVacantDate.ValueChanged += new System.EventHandler(this.dtpVacantDate_ValueChanged);
            // 
            // dtpConveyDate
            // 
            this.dtpConveyDate.Location = new System.Drawing.Point(504, 142);
            this.dtpConveyDate.Name = "dtpConveyDate";
            this.dtpConveyDate.Size = new System.Drawing.Size(200, 20);
            this.dtpConveyDate.TabIndex = 16;
            this.dtpConveyDate.ValueChanged += new System.EventHandler(this.dtpConveyDate_ValueChanged);
            // 
            // chkBankrupt
            // 
            this.chkBankrupt.AutoSize = true;
            this.chkBankrupt.Location = new System.Drawing.Point(131, 12);
            this.chkBankrupt.Name = "chkBankrupt";
            this.chkBankrupt.Size = new System.Drawing.Size(129, 17);
            this.chkBankrupt.TabIndex = 0;
            this.chkBankrupt.Text = "Bankruptcy Protected";
            this.chkBankrupt.UseVisualStyleBackColor = true;
            this.chkBankrupt.CheckStateChanged += new System.EventHandler(this.chkBankrupt_CheckStateChanged);
            // 
            // lblVacantDate
            // 
            this.lblVacantDate.Location = new System.Drawing.Point(12, 171);
            this.lblVacantDate.Name = "lblVacantDate";
            this.lblVacantDate.Size = new System.Drawing.Size(125, 20);
            this.lblVacantDate.TabIndex = 17;
            this.lblVacantDate.Text = "First Time Vacant Date:";
            this.lblVacantDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblConveyDate
            // 
            this.lblConveyDate.Location = new System.Drawing.Point(394, 146);
            this.lblConveyDate.Name = "lblConveyDate";
            this.lblConveyDate.Size = new System.Drawing.Size(100, 20);
            this.lblConveyDate.TabIndex = 15;
            this.lblConveyDate.Text = "Conveyance Date:";
            this.lblConveyDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHudCase
            // 
            this.lblHudCase.Location = new System.Drawing.Point(12, 145);
            this.lblHudCase.Name = "lblHudCase";
            this.lblHudCase.Size = new System.Drawing.Size(125, 20);
            this.lblHudCase.TabIndex = 13;
            this.lblHudCase.Text = "Hud Case Number:";
            this.lblHudCase.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMortgagorPhone
            // 
            this.lblMortgagorPhone.Location = new System.Drawing.Point(394, 119);
            this.lblMortgagorPhone.Name = "lblMortgagorPhone";
            this.lblMortgagorPhone.Size = new System.Drawing.Size(100, 20);
            this.lblMortgagorPhone.TabIndex = 11;
            this.lblMortgagorPhone.Text = "Mortgagor Phone:";
            this.lblMortgagorPhone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMortgagorName
            // 
            this.lblMortgagorName.Location = new System.Drawing.Point(12, 119);
            this.lblMortgagorName.Name = "lblMortgagorName";
            this.lblMortgagorName.Size = new System.Drawing.Size(125, 20);
            this.lblMortgagorName.TabIndex = 9;
            this.lblMortgagorName.Text = "Mortgagor Name:";
            this.lblMortgagorName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLoanTypeID
            // 
            this.lblLoanTypeID.Location = new System.Drawing.Point(394, 93);
            this.lblLoanTypeID.Name = "lblLoanTypeID";
            this.lblLoanTypeID.Size = new System.Drawing.Size(100, 20);
            this.lblLoanTypeID.TabIndex = 7;
            this.lblLoanTypeID.Text = "Loan Type ID:";
            this.lblLoanTypeID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLoanNumber
            // 
            this.lblLoanNumber.Location = new System.Drawing.Point(12, 93);
            this.lblLoanNumber.Name = "lblLoanNumber";
            this.lblLoanNumber.Size = new System.Drawing.Size(125, 20);
            this.lblLoanNumber.TabIndex = 5;
            this.lblLoanNumber.Text = "Loan Number:";
            this.lblLoanNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAssetNumber
            // 
            this.lblAssetNumber.Location = new System.Drawing.Point(12, 67);
            this.lblAssetNumber.Name = "lblAssetNumber";
            this.lblAssetNumber.Size = new System.Drawing.Size(125, 20);
            this.lblAssetNumber.TabIndex = 3;
            this.lblAssetNumber.Text = "Asset Number:";
            this.lblAssetNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTypeID
            // 
            this.lblTypeID.Location = new System.Drawing.Point(12, 41);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(125, 20);
            this.lblTypeID.TabIndex = 1;
            this.lblTypeID.Text = "Type ID:";
            this.lblTypeID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMortgagorPhone
            // 
            this.txtMortgagorPhone.Location = new System.Drawing.Point(500, 116);
            this.txtMortgagorPhone.Mask = "(999) 000-0000";
            this.txtMortgagorPhone.Name = "txtMortgagorPhone";
            this.txtMortgagorPhone.Size = new System.Drawing.Size(100, 20);
            this.txtMortgagorPhone.TabIndex = 12;
            this.txtMortgagorPhone.TextChanged += new System.EventHandler(this.txtMortgagorPhone_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(548, 194);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(629, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AssetForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(716, 225);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMortgagorPhone);
            this.Controls.Add(this.lblTypeID);
            this.Controls.Add(this.lblAssetNumber);
            this.Controls.Add(this.lblLoanNumber);
            this.Controls.Add(this.lblLoanTypeID);
            this.Controls.Add(this.lblMortgagorName);
            this.Controls.Add(this.lblMortgagorPhone);
            this.Controls.Add(this.lblHudCase);
            this.Controls.Add(this.lblConveyDate);
            this.Controls.Add(this.lblVacantDate);
            this.Controls.Add(this.chkBankrupt);
            this.Controls.Add(this.dtpConveyDate);
            this.Controls.Add(this.dtpVacantDate);
            this.Controls.Add(this.txtHudCase);
            this.Controls.Add(this.txtTypeID);
            this.Controls.Add(this.txtLoanNumber);
            this.Controls.Add(this.txtAssetNumber);
            this.Controls.Add(this.txtMortgagorName);
            this.Controls.Add(this.txtLoanTypeID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AssetForm";
            this.ShowInTaskbar = false;
            this.Text = "AssetForm";
            this.Load += new System.EventHandler(this.AssetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoanTypeID;
        private System.Windows.Forms.TextBox txtMortgagorName;
        private System.Windows.Forms.TextBox txtAssetNumber;
        private System.Windows.Forms.TextBox txtLoanNumber;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.TextBox txtHudCase;
        private System.Windows.Forms.DateTimePicker dtpVacantDate;
        private System.Windows.Forms.DateTimePicker dtpConveyDate;
        private System.Windows.Forms.CheckBox chkBankrupt;
        private System.Windows.Forms.Label lblVacantDate;
        private System.Windows.Forms.Label lblConveyDate;
        private System.Windows.Forms.Label lblHudCase;
        private System.Windows.Forms.Label lblMortgagorPhone;
        private System.Windows.Forms.Label lblMortgagorName;
        private System.Windows.Forms.Label lblLoanTypeID;
        private System.Windows.Forms.Label lblLoanNumber;
        private System.Windows.Forms.Label lblAssetNumber;
        private System.Windows.Forms.Label lblTypeID;
        private System.Windows.Forms.MaskedTextBox txtMortgagorPhone;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}