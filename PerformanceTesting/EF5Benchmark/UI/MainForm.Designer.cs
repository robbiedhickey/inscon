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
            this.txt_DapperSp_Elapsed = new System.Windows.Forms.TextBox();
            this.txt_DapperSp_Stop = new System.Windows.Forms.TextBox();
            this.txt_DapperSp_Start = new System.Windows.Forms.TextBox();
            this.chk_dapperSp = new System.Windows.Forms.CheckBox();
            this.txt_ELIElapsed = new System.Windows.Forms.TextBox();
            this.txt_ELIEnd = new System.Windows.Forms.TextBox();
            this.txt_ELIStart = new System.Windows.Forms.TextBox();
            this.chk_ELI = new System.Windows.Forms.CheckBox();
            this.txt_SPElapsed = new System.Windows.Forms.TextBox();
            this.txt_ELElapsed = new System.Windows.Forms.TextBox();
            this.txt_SPEnd = new System.Windows.Forms.TextBox();
            this.txt_ELEnd = new System.Windows.Forms.TextBox();
            this.txt_ELStart = new System.Windows.Forms.TextBox();
            this.txt_SPStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_EL = new System.Windows.Forms.CheckBox();
            this.chk_SP = new System.Windows.Forms.CheckBox();
            this.txt_Llbl_Elapsed = new System.Windows.Forms.TextBox();
            this.txt_Llbl_Stop = new System.Windows.Forms.TextBox();
            this.txt_Llbl_Start = new System.Windows.Forms.TextBox();
            this.chk_llblAdapter = new System.Windows.Forms.CheckBox();
            this.grp_TestSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Go
            // 
            this.btn_Go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Go.Location = new System.Drawing.Point(452, 256);
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
            this.btn_Exit.Location = new System.Drawing.Point(452, 285);
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
            this.txt_FileName.Size = new System.Drawing.Size(479, 20);
            this.txt_FileName.TabIndex = 4;
            this.txt_FileName.TextChanged += new System.EventHandler(this.txt_FileName_TextChanged);
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectFile.Location = new System.Drawing.Point(497, 12);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(30, 20);
            this.btn_SelectFile.TabIndex = 5;
            this.btn_SelectFile.Text = "...";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // grp_TestSelection
            // 
            this.grp_TestSelection.Controls.Add(this.txt_Llbl_Elapsed);
            this.grp_TestSelection.Controls.Add(this.txt_Llbl_Stop);
            this.grp_TestSelection.Controls.Add(this.txt_Llbl_Start);
            this.grp_TestSelection.Controls.Add(this.chk_llblAdapter);
            this.grp_TestSelection.Controls.Add(this.txt_DapperSp_Elapsed);
            this.grp_TestSelection.Controls.Add(this.txt_DapperSp_Stop);
            this.grp_TestSelection.Controls.Add(this.txt_DapperSp_Start);
            this.grp_TestSelection.Controls.Add(this.chk_dapperSp);
            this.grp_TestSelection.Controls.Add(this.txt_ELIElapsed);
            this.grp_TestSelection.Controls.Add(this.txt_ELIEnd);
            this.grp_TestSelection.Controls.Add(this.txt_ELIStart);
            this.grp_TestSelection.Controls.Add(this.chk_ELI);
            this.grp_TestSelection.Controls.Add(this.txt_SPElapsed);
            this.grp_TestSelection.Controls.Add(this.txt_ELElapsed);
            this.grp_TestSelection.Controls.Add(this.txt_SPEnd);
            this.grp_TestSelection.Controls.Add(this.txt_ELEnd);
            this.grp_TestSelection.Controls.Add(this.txt_ELStart);
            this.grp_TestSelection.Controls.Add(this.txt_SPStart);
            this.grp_TestSelection.Controls.Add(this.label5);
            this.grp_TestSelection.Controls.Add(this.label3);
            this.grp_TestSelection.Controls.Add(this.label1);
            this.grp_TestSelection.Controls.Add(this.chk_EL);
            this.grp_TestSelection.Controls.Add(this.chk_SP);
            this.grp_TestSelection.Location = new System.Drawing.Point(12, 38);
            this.grp_TestSelection.Name = "grp_TestSelection";
            this.grp_TestSelection.Size = new System.Drawing.Size(500, 203);
            this.grp_TestSelection.TabIndex = 6;
            this.grp_TestSelection.TabStop = false;
            this.grp_TestSelection.Text = "Test Selection";
            // 
            // txt_DapperSp_Elapsed
            // 
            this.txt_DapperSp_Elapsed.Location = new System.Drawing.Point(356, 113);
            this.txt_DapperSp_Elapsed.Name = "txt_DapperSp_Elapsed";
            this.txt_DapperSp_Elapsed.Size = new System.Drawing.Size(100, 20);
            this.txt_DapperSp_Elapsed.TabIndex = 20;
            // 
            // txt_DapperSp_Stop
            // 
            this.txt_DapperSp_Stop.Location = new System.Drawing.Point(250, 113);
            this.txt_DapperSp_Stop.Name = "txt_DapperSp_Stop";
            this.txt_DapperSp_Stop.Size = new System.Drawing.Size(100, 20);
            this.txt_DapperSp_Stop.TabIndex = 19;
            // 
            // txt_DapperSp_Start
            // 
            this.txt_DapperSp_Start.Location = new System.Drawing.Point(144, 113);
            this.txt_DapperSp_Start.Name = "txt_DapperSp_Start";
            this.txt_DapperSp_Start.Size = new System.Drawing.Size(100, 20);
            this.txt_DapperSp_Start.TabIndex = 18;
            // 
            // chk_dapperSp
            // 
            this.chk_dapperSp.AutoSize = true;
            this.chk_dapperSp.Location = new System.Drawing.Point(6, 115);
            this.chk_dapperSp.Name = "chk_dapperSp";
            this.chk_dapperSp.Size = new System.Drawing.Size(126, 17);
            this.chk_dapperSp.TabIndex = 17;
            this.chk_dapperSp.Text = "Dapper - Stored Proc";
            this.chk_dapperSp.UseVisualStyleBackColor = true;
            this.chk_dapperSp.UseWaitCursor = true;
            this.chk_dapperSp.CheckedChanged += new System.EventHandler(this.chk_dapperSp_CheckedChanged);
            // 
            // txt_ELIElapsed
            // 
            this.txt_ELIElapsed.Location = new System.Drawing.Point(356, 87);
            this.txt_ELIElapsed.Name = "txt_ELIElapsed";
            this.txt_ELIElapsed.Size = new System.Drawing.Size(100, 20);
            this.txt_ELIElapsed.TabIndex = 16;
            // 
            // txt_ELIEnd
            // 
            this.txt_ELIEnd.Location = new System.Drawing.Point(250, 87);
            this.txt_ELIEnd.Name = "txt_ELIEnd";
            this.txt_ELIEnd.Size = new System.Drawing.Size(100, 20);
            this.txt_ELIEnd.TabIndex = 15;
            // 
            // txt_ELIStart
            // 
            this.txt_ELIStart.Location = new System.Drawing.Point(144, 87);
            this.txt_ELIStart.Name = "txt_ELIStart";
            this.txt_ELIStart.Size = new System.Drawing.Size(100, 20);
            this.txt_ELIStart.TabIndex = 14;
            // 
            // chk_ELI
            // 
            this.chk_ELI.AutoSize = true;
            this.chk_ELI.Location = new System.Drawing.Point(7, 89);
            this.chk_ELI.Name = "chk_ELI";
            this.chk_ELI.Size = new System.Drawing.Size(121, 17);
            this.chk_ELI.TabIndex = 13;
            this.chk_ELI.Text = "EF5 - LINQ - Int chk";
            this.chk_ELI.UseVisualStyleBackColor = true;
            // 
            // txt_SPElapsed
            // 
            this.txt_SPElapsed.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SPElapsed.Location = new System.Drawing.Point(356, 35);
            this.txt_SPElapsed.Name = "txt_SPElapsed";
            this.txt_SPElapsed.ReadOnly = true;
            this.txt_SPElapsed.Size = new System.Drawing.Size(100, 20);
            this.txt_SPElapsed.TabIndex = 12;
            this.txt_SPElapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ELElapsed
            // 
            this.txt_ELElapsed.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ELElapsed.Location = new System.Drawing.Point(356, 61);
            this.txt_ELElapsed.Name = "txt_ELElapsed";
            this.txt_ELElapsed.ReadOnly = true;
            this.txt_ELElapsed.Size = new System.Drawing.Size(100, 20);
            this.txt_ELElapsed.TabIndex = 11;
            this.txt_ELElapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SPEnd
            // 
            this.txt_SPEnd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SPEnd.Location = new System.Drawing.Point(250, 35);
            this.txt_SPEnd.Name = "txt_SPEnd";
            this.txt_SPEnd.ReadOnly = true;
            this.txt_SPEnd.Size = new System.Drawing.Size(100, 20);
            this.txt_SPEnd.TabIndex = 10;
            this.txt_SPEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ELEnd
            // 
            this.txt_ELEnd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ELEnd.Location = new System.Drawing.Point(250, 61);
            this.txt_ELEnd.Name = "txt_ELEnd";
            this.txt_ELEnd.ReadOnly = true;
            this.txt_ELEnd.Size = new System.Drawing.Size(100, 20);
            this.txt_ELEnd.TabIndex = 9;
            this.txt_ELEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ELStart
            // 
            this.txt_ELStart.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ELStart.Location = new System.Drawing.Point(144, 61);
            this.txt_ELStart.Name = "txt_ELStart";
            this.txt_ELStart.ReadOnly = true;
            this.txt_ELStart.Size = new System.Drawing.Size(100, 20);
            this.txt_ELStart.TabIndex = 8;
            this.txt_ELStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SPStart
            // 
            this.txt_SPStart.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SPStart.Location = new System.Drawing.Point(144, 35);
            this.txt_SPStart.Name = "txt_SPStart";
            this.txt_SPStart.ReadOnly = true;
            this.txt_SPStart.Size = new System.Drawing.Size(100, 20);
            this.txt_SPStart.TabIndex = 7;
            this.txt_SPStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Elapsed Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stop Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Time";
            // 
            // chk_EL
            // 
            this.chk_EL.AutoSize = true;
            this.chk_EL.Location = new System.Drawing.Point(7, 63);
            this.chk_EL.Name = "chk_EL";
            this.chk_EL.Size = new System.Drawing.Size(94, 17);
            this.chk_EL.TabIndex = 1;
            this.chk_EL.Text = "EF5 and LINQ";
            this.chk_EL.UseVisualStyleBackColor = true;
            this.chk_EL.CheckedChanged += new System.EventHandler(this.chk_EL_CheckedChanged);
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
            // txt_Llbl_Elapsed
            // 
            this.txt_Llbl_Elapsed.Location = new System.Drawing.Point(356, 139);
            this.txt_Llbl_Elapsed.Name = "txt_Llbl_Elapsed";
            this.txt_Llbl_Elapsed.Size = new System.Drawing.Size(100, 20);
            this.txt_Llbl_Elapsed.TabIndex = 24;
            // 
            // txt_Llbl_Stop
            // 
            this.txt_Llbl_Stop.Location = new System.Drawing.Point(250, 139);
            this.txt_Llbl_Stop.Name = "txt_Llbl_Stop";
            this.txt_Llbl_Stop.Size = new System.Drawing.Size(100, 20);
            this.txt_Llbl_Stop.TabIndex = 23;
            // 
            // txt_Llbl_Start
            // 
            this.txt_Llbl_Start.Location = new System.Drawing.Point(144, 139);
            this.txt_Llbl_Start.Name = "txt_Llbl_Start";
            this.txt_Llbl_Start.Size = new System.Drawing.Size(100, 20);
            this.txt_Llbl_Start.TabIndex = 22;
            // 
            // chk_llblAdapter
            // 
            this.chk_llblAdapter.AutoSize = true;
            this.chk_llblAdapter.Location = new System.Drawing.Point(6, 141);
            this.chk_llblAdapter.Name = "chk_llblAdapter";
            this.chk_llblAdapter.Size = new System.Drawing.Size(111, 17);
            this.chk_llblAdapter.TabIndex = 21;
            this.chk_llblAdapter.Text = "LLBLGen Adapter";
            this.chk_llblAdapter.UseVisualStyleBackColor = true;
            this.chk_llblAdapter.UseWaitCursor = true;
            this.chk_llblAdapter.CheckedChanged += new System.EventHandler(this.chk_llblAdapter_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 320);
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
        private System.Windows.Forms.TextBox txt_ELElapsed;
        private System.Windows.Forms.TextBox txt_SPEnd;
        private System.Windows.Forms.TextBox txt_ELEnd;
        private System.Windows.Forms.TextBox txt_ELStart;
        private System.Windows.Forms.TextBox txt_SPStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_EL;
        private System.Windows.Forms.CheckBox chk_SP;
        private System.Windows.Forms.TextBox txt_ELIElapsed;
        private System.Windows.Forms.TextBox txt_ELIEnd;
        private System.Windows.Forms.TextBox txt_ELIStart;
        private System.Windows.Forms.CheckBox chk_ELI;
        private System.Windows.Forms.TextBox txt_DapperSp_Elapsed;
        private System.Windows.Forms.TextBox txt_DapperSp_Stop;
        private System.Windows.Forms.TextBox txt_DapperSp_Start;
        private System.Windows.Forms.CheckBox chk_dapperSp;
        private System.Windows.Forms.TextBox txt_Llbl_Elapsed;
        private System.Windows.Forms.TextBox txt_Llbl_Stop;
        private System.Windows.Forms.TextBox txt_Llbl_Start;
        private System.Windows.Forms.CheckBox chk_llblAdapter;
    }
}

