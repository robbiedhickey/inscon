namespace MSI.EF5Benchmark.UI
{
    partial class MainForm
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
            this.btn_Go = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.grp_TestSelection = new System.Windows.Forms.GroupBox();
            this.txtInfinityElapsed = new System.Windows.Forms.TextBox();
            this.txtInfinityStop = new System.Windows.Forms.TextBox();
            this.txtInfinityStart = new System.Windows.Forms.TextBox();
            this.chkInfintyDAL = new System.Windows.Forms.CheckBox();
            this.txt_DapperSp_Elapsed = new System.Windows.Forms.TextBox();
            this.txt_DapperSp_Stop = new System.Windows.Forms.TextBox();
            this.txt_DapperSp_Start = new System.Windows.Forms.TextBox();
            this.chk_dapperSp = new System.Windows.Forms.CheckBox();
            this.txt_SPElapsed = new System.Windows.Forms.TextBox();
            this.txt_SPEnd = new System.Windows.Forms.TextBox();
            this.txt_SPStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_SP = new System.Windows.Forms.CheckBox();
            this.chk_Read1000SP = new System.Windows.Forms.CheckBox();
            this.chk_Read1SP = new System.Windows.Forms.CheckBox();
            this.txt_Read1000SP_Start = new System.Windows.Forms.TextBox();
            this.txt_Read1SP_Start = new System.Windows.Forms.TextBox();
            this.txt_Read1000SP_End = new System.Windows.Forms.TextBox();
            this.txt_Read1000SP_Elapsed = new System.Windows.Forms.TextBox();
            this.txt_Read1SP_Elapsed = new System.Windows.Forms.TextBox();
            this.txt_Read1SP_End = new System.Windows.Forms.TextBox();
            this.grp_TestSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Go
            // 
            this.btn_Go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Go.Location = new System.Drawing.Point(618, 238);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(75, 23);
            this.btn_Go.TabIndex = 0;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(618, 267);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_FileName
            // 
            this.txt_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FileName.BackColor = System.Drawing.SystemColors.Window;
            this.txt_FileName.Location = new System.Drawing.Point(12, 12);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.ReadOnly = true;
            this.txt_FileName.Size = new System.Drawing.Size(645, 20);
            this.txt_FileName.TabIndex = 4;
            this.txt_FileName.TextChanged += new System.EventHandler(this.txt_FileName_TextChanged);
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectFile.Location = new System.Drawing.Point(663, 12);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(30, 20);
            this.btn_SelectFile.TabIndex = 5;
            this.btn_SelectFile.Text = "...";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // grp_TestSelection
            // 
            this.grp_TestSelection.Controls.Add(this.txt_Read1SP_End);
            this.grp_TestSelection.Controls.Add(this.txt_Read1SP_Elapsed);
            this.grp_TestSelection.Controls.Add(this.txt_Read1000SP_Elapsed);
            this.grp_TestSelection.Controls.Add(this.txt_Read1000SP_End);
            this.grp_TestSelection.Controls.Add(this.txt_Read1SP_Start);
            this.grp_TestSelection.Controls.Add(this.txt_Read1000SP_Start);
            this.grp_TestSelection.Controls.Add(this.chk_Read1SP);
            this.grp_TestSelection.Controls.Add(this.chk_Read1000SP);
            this.grp_TestSelection.Controls.Add(this.txtInfinityElapsed);
            this.grp_TestSelection.Controls.Add(this.txtInfinityStop);
            this.grp_TestSelection.Controls.Add(this.txtInfinityStart);
            this.grp_TestSelection.Controls.Add(this.chkInfintyDAL);
            this.grp_TestSelection.Controls.Add(this.txt_DapperSp_Elapsed);
            this.grp_TestSelection.Controls.Add(this.txt_DapperSp_Stop);
            this.grp_TestSelection.Controls.Add(this.txt_DapperSp_Start);
            this.grp_TestSelection.Controls.Add(this.chk_dapperSp);
            this.grp_TestSelection.Controls.Add(this.txt_SPElapsed);
            this.grp_TestSelection.Controls.Add(this.txt_SPEnd);
            this.grp_TestSelection.Controls.Add(this.txt_SPStart);
            this.grp_TestSelection.Controls.Add(this.label5);
            this.grp_TestSelection.Controls.Add(this.label3);
            this.grp_TestSelection.Controls.Add(this.label1);
            this.grp_TestSelection.Controls.Add(this.chk_SP);
            this.grp_TestSelection.Location = new System.Drawing.Point(12, 38);
            this.grp_TestSelection.Name = "grp_TestSelection";
            this.grp_TestSelection.Size = new System.Drawing.Size(681, 177);
            this.grp_TestSelection.TabIndex = 6;
            this.grp_TestSelection.TabStop = false;
            this.grp_TestSelection.Text = "Test Selection";
            // 
            // txtInfinityElapsed
            // 
            this.txtInfinityElapsed.BackColor = System.Drawing.SystemColors.Window;
            this.txtInfinityElapsed.Location = new System.Drawing.Point(453, 87);
            this.txtInfinityElapsed.Name = "txtInfinityElapsed";
            this.txtInfinityElapsed.ReadOnly = true;
            this.txtInfinityElapsed.Size = new System.Drawing.Size(150, 20);
            this.txtInfinityElapsed.TabIndex = 28;
            this.txtInfinityElapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInfinityStop
            // 
            this.txtInfinityStop.BackColor = System.Drawing.SystemColors.Window;
            this.txtInfinityStop.Location = new System.Drawing.Point(299, 87);
            this.txtInfinityStop.Name = "txtInfinityStop";
            this.txtInfinityStop.ReadOnly = true;
            this.txtInfinityStop.Size = new System.Drawing.Size(150, 20);
            this.txtInfinityStop.TabIndex = 27;
            this.txtInfinityStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInfinityStart
            // 
            this.txtInfinityStart.BackColor = System.Drawing.SystemColors.Window;
            this.txtInfinityStart.Location = new System.Drawing.Point(144, 87);
            this.txtInfinityStart.Name = "txtInfinityStart";
            this.txtInfinityStart.ReadOnly = true;
            this.txtInfinityStart.Size = new System.Drawing.Size(149, 20);
            this.txtInfinityStart.TabIndex = 26;
            this.txtInfinityStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkInfintyDAL
            // 
            this.chkInfintyDAL.AutoSize = true;
            this.chkInfintyDAL.Location = new System.Drawing.Point(7, 89);
            this.chkInfintyDAL.Name = "chkInfintyDAL";
            this.chkInfintyDAL.Size = new System.Drawing.Size(80, 17);
            this.chkInfintyDAL.TabIndex = 25;
            this.chkInfintyDAL.Text = "Infinity DAL";
            this.chkInfintyDAL.UseVisualStyleBackColor = true;
            this.chkInfintyDAL.UseWaitCursor = true;
            this.chkInfintyDAL.CheckedChanged += new System.EventHandler(this.chkInfintyDAL_CheckedChanged);
            // 
            // txt_DapperSp_Elapsed
            // 
            this.txt_DapperSp_Elapsed.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DapperSp_Elapsed.Location = new System.Drawing.Point(453, 61);
            this.txt_DapperSp_Elapsed.Name = "txt_DapperSp_Elapsed";
            this.txt_DapperSp_Elapsed.ReadOnly = true;
            this.txt_DapperSp_Elapsed.Size = new System.Drawing.Size(150, 20);
            this.txt_DapperSp_Elapsed.TabIndex = 20;
            this.txt_DapperSp_Elapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_DapperSp_Stop
            // 
            this.txt_DapperSp_Stop.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DapperSp_Stop.Location = new System.Drawing.Point(299, 61);
            this.txt_DapperSp_Stop.Name = "txt_DapperSp_Stop";
            this.txt_DapperSp_Stop.ReadOnly = true;
            this.txt_DapperSp_Stop.Size = new System.Drawing.Size(150, 20);
            this.txt_DapperSp_Stop.TabIndex = 19;
            this.txt_DapperSp_Stop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_DapperSp_Start
            // 
            this.txt_DapperSp_Start.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DapperSp_Start.Location = new System.Drawing.Point(144, 61);
            this.txt_DapperSp_Start.Name = "txt_DapperSp_Start";
            this.txt_DapperSp_Start.ReadOnly = true;
            this.txt_DapperSp_Start.Size = new System.Drawing.Size(149, 20);
            this.txt_DapperSp_Start.TabIndex = 18;
            this.txt_DapperSp_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chk_dapperSp
            // 
            this.chk_dapperSp.AutoSize = true;
            this.chk_dapperSp.Location = new System.Drawing.Point(7, 63);
            this.chk_dapperSp.Name = "chk_dapperSp";
            this.chk_dapperSp.Size = new System.Drawing.Size(126, 17);
            this.chk_dapperSp.TabIndex = 17;
            this.chk_dapperSp.Text = "Dapper - Stored Proc";
            this.chk_dapperSp.UseVisualStyleBackColor = true;
            this.chk_dapperSp.UseWaitCursor = true;
            this.chk_dapperSp.CheckedChanged += new System.EventHandler(this.chk_dapperSp_CheckedChanged);
            // 
            // txt_SPElapsed
            // 
            this.txt_SPElapsed.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SPElapsed.Location = new System.Drawing.Point(453, 35);
            this.txt_SPElapsed.Name = "txt_SPElapsed";
            this.txt_SPElapsed.ReadOnly = true;
            this.txt_SPElapsed.Size = new System.Drawing.Size(150, 20);
            this.txt_SPElapsed.TabIndex = 12;
            this.txt_SPElapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SPEnd
            // 
            this.txt_SPEnd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SPEnd.Location = new System.Drawing.Point(299, 35);
            this.txt_SPEnd.Name = "txt_SPEnd";
            this.txt_SPEnd.ReadOnly = true;
            this.txt_SPEnd.Size = new System.Drawing.Size(150, 20);
            this.txt_SPEnd.TabIndex = 10;
            this.txt_SPEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SPStart
            // 
            this.txt_SPStart.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SPStart.Location = new System.Drawing.Point(144, 35);
            this.txt_SPStart.Name = "txt_SPStart";
            this.txt_SPStart.ReadOnly = true;
            this.txt_SPStart.Size = new System.Drawing.Size(149, 20);
            this.txt_SPStart.TabIndex = 7;
            this.txt_SPStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Elapsed Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stop Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Time";
            // 
            // chk_SP
            // 
            this.chk_SP.AutoSize = true;
            this.chk_SP.Location = new System.Drawing.Point(7, 37);
            this.chk_SP.Name = "chk_SP";
            this.chk_SP.Size = new System.Drawing.Size(131, 17);
            this.chk_SP.TabIndex = 0;
            this.chk_SP.Text = "Use Stored Procedure";
            this.chk_SP.UseVisualStyleBackColor = true;
            this.chk_SP.CheckedChanged += new System.EventHandler(this.chk_SP_CheckedChanged);
            // 
            // chk_Read1000SP
            // 
            this.chk_Read1000SP.AutoSize = true;
            this.chk_Read1000SP.Location = new System.Drawing.Point(7, 115);
            this.chk_Read1000SP.Name = "chk_Read1000SP";
            this.chk_Read1000SP.Size = new System.Drawing.Size(96, 17);
            this.chk_Read1000SP.TabIndex = 29;
            this.chk_Read1000SP.Text = "Read 1000 SP";
            this.chk_Read1000SP.UseVisualStyleBackColor = true;
            this.chk_Read1000SP.CheckedChanged += new System.EventHandler(this.chk_Read1000SP_CheckedChanged);
            // 
            // chk_Read1SP
            // 
            this.chk_Read1SP.AutoSize = true;
            this.chk_Read1SP.Location = new System.Drawing.Point(7, 141);
            this.chk_Read1SP.Name = "chk_Read1SP";
            this.chk_Read1SP.Size = new System.Drawing.Size(72, 17);
            this.chk_Read1SP.TabIndex = 30;
            this.chk_Read1SP.Text = "Read1SP";
            this.chk_Read1SP.UseVisualStyleBackColor = true;
            this.chk_Read1SP.CheckedChanged += new System.EventHandler(this.chk_Read1SP_CheckedChanged);
            // 
            // txt_Read1000SP_Start
            // 
            this.txt_Read1000SP_Start.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Read1000SP_Start.Location = new System.Drawing.Point(144, 113);
            this.txt_Read1000SP_Start.Name = "txt_Read1000SP_Start";
            this.txt_Read1000SP_Start.ReadOnly = true;
            this.txt_Read1000SP_Start.Size = new System.Drawing.Size(149, 20);
            this.txt_Read1000SP_Start.TabIndex = 31;
            this.txt_Read1000SP_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Read1SP_Start
            // 
            this.txt_Read1SP_Start.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Read1SP_Start.Location = new System.Drawing.Point(144, 139);
            this.txt_Read1SP_Start.Name = "txt_Read1SP_Start";
            this.txt_Read1SP_Start.ReadOnly = true;
            this.txt_Read1SP_Start.Size = new System.Drawing.Size(149, 20);
            this.txt_Read1SP_Start.TabIndex = 32;
            this.txt_Read1SP_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Read1000SP_End
            // 
            this.txt_Read1000SP_End.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Read1000SP_End.Location = new System.Drawing.Point(299, 113);
            this.txt_Read1000SP_End.Name = "txt_Read1000SP_End";
            this.txt_Read1000SP_End.ReadOnly = true;
            this.txt_Read1000SP_End.Size = new System.Drawing.Size(150, 20);
            this.txt_Read1000SP_End.TabIndex = 33;
            this.txt_Read1000SP_End.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Read1000SP_Elapsed
            // 
            this.txt_Read1000SP_Elapsed.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Read1000SP_Elapsed.Location = new System.Drawing.Point(453, 113);
            this.txt_Read1000SP_Elapsed.Name = "txt_Read1000SP_Elapsed";
            this.txt_Read1000SP_Elapsed.ReadOnly = true;
            this.txt_Read1000SP_Elapsed.Size = new System.Drawing.Size(150, 20);
            this.txt_Read1000SP_Elapsed.TabIndex = 34;
            this.txt_Read1000SP_Elapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Read1SP_Elapsed
            // 
            this.txt_Read1SP_Elapsed.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Read1SP_Elapsed.Location = new System.Drawing.Point(453, 139);
            this.txt_Read1SP_Elapsed.Name = "txt_Read1SP_Elapsed";
            this.txt_Read1SP_Elapsed.ReadOnly = true;
            this.txt_Read1SP_Elapsed.Size = new System.Drawing.Size(150, 20);
            this.txt_Read1SP_Elapsed.TabIndex = 35;
            this.txt_Read1SP_Elapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Read1SP_End
            // 
            this.txt_Read1SP_End.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Read1SP_End.Location = new System.Drawing.Point(299, 139);
            this.txt_Read1SP_End.Name = "txt_Read1SP_End";
            this.txt_Read1SP_End.ReadOnly = true;
            this.txt_Read1SP_End.Size = new System.Drawing.Size(150, 20);
            this.txt_Read1SP_End.TabIndex = 36;
            this.txt_Read1SP_End.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 302);
            this.Controls.Add(this.grp_TestSelection);
            this.Controls.Add(this.btn_SelectFile);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Go);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "EF 5 - Benchmark";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grp_TestSelection.ResumeLayout(false);
            this.grp_TestSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.GroupBox grp_TestSelection;
        private System.Windows.Forms.TextBox txt_SPElapsed;
        private System.Windows.Forms.TextBox txt_SPEnd;
        private System.Windows.Forms.TextBox txt_SPStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_SP;
        private System.Windows.Forms.TextBox txt_DapperSp_Elapsed;
        private System.Windows.Forms.TextBox txt_DapperSp_Stop;
        private System.Windows.Forms.TextBox txt_DapperSp_Start;
        private System.Windows.Forms.CheckBox chk_dapperSp;
        private System.Windows.Forms.TextBox txtInfinityElapsed;
        private System.Windows.Forms.TextBox txtInfinityStop;
        private System.Windows.Forms.TextBox txtInfinityStart;
        private System.Windows.Forms.CheckBox chkInfintyDAL;
        private System.Windows.Forms.TextBox txt_Read1SP_End;
        private System.Windows.Forms.TextBox txt_Read1SP_Elapsed;
        private System.Windows.Forms.TextBox txt_Read1000SP_Elapsed;
        private System.Windows.Forms.TextBox txt_Read1000SP_End;
        private System.Windows.Forms.TextBox txt_Read1SP_Start;
        private System.Windows.Forms.TextBox txt_Read1000SP_Start;
        private System.Windows.Forms.CheckBox chk_Read1SP;
        private System.Windows.Forms.CheckBox chk_Read1000SP;
    }
}

