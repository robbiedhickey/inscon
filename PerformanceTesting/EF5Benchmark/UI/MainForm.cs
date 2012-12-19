using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DapperRunner.Model;
using LinqToExcel;
using MSI.EF5Benchmark.DAL;
using DapperRunner;

using iData.Core;

namespace MSI.EF5Benchmark.UI
{
    public partial class MainForm : Form
    {
        private bool _fileOK = false;
        private DateTime _spStartTime;
        private DateTime _spEndTime;
        private DateTime _spRead1000StartTime;
        private DateTime _spRead1000EndTime;
        private DateTime _spRead1StartTime;
        private DateTime _spRead1EndTime;
        private DateTime _dapperStartTime;
        private DateTime _dapperEndTime;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetGoState();
        }

        private void txt_FileName_TextChanged(object sender, EventArgs e)
        {
            SetGoState();
        }

        private void chk_SP_CheckedChanged(object sender, EventArgs e)
        {
            SetGoState();
        }

        private void chk_dapperSp_CheckedChanged(object sender, EventArgs e)
        {
            SetGoState();
        }
        private void chkInfintyDAL_CheckedChanged(object sender, EventArgs e)
        {
            SetGoState();
        }

        private void chk_Read1000SP_CheckedChanged(object sender, EventArgs e)
        {
            SetGoState();
        }

        private void chk_Read1SP_CheckedChanged(object sender, EventArgs e)
        {
            SetGoState();
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Title = @"Select File to Load";
            DialogResult dr = fd.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                txt_FileName.Text = fd.FileName;
                _fileOK = true;
            }
            SetGoState();
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            RunTests();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetGoState()
        {
            btn_Go.Enabled = (  chk_SP.Checked || 
                                chk_dapperSp.Checked || 
                                chkInfintyDAL.Checked || 
                                chk_Read1000SP.Checked || 
                                chk_Read1SP.Checked) && _fileOK;
        }

        private void RunTests()
        {
            var rep = new Repository();

            if (chk_SP.Checked)
            {
                var cleared = rep.ClearTable();

                _spStartTime = DateTime.Now;
                txt_SPStart.Text = _spStartTime.ToString("HH:mm:ss");

                if (rep.LoadUsingSproc(txt_FileName.Text))
                {
                    _spEndTime = DateTime.Now;
                    txt_SPEnd.Text = _spEndTime.ToString("HH:mm:ss");

                    txt_SPElapsed.Text = (_spEndTime - _spStartTime).ToString();
                }
                else
                {
                    txt_SPElapsed.Text = @"Error";
                }
            }

            if (chk_dapperSp.Checked)
            {
                // Clear Table
                bool cleared = rep.ClearTable();

                _dapperStartTime = DateTime.Now;
                txt_DapperSp_Start.Text = _dapperStartTime.ToString("HH:mm:ss");

                if (new DapperTestSuite().ExecuteWriteTest<DapperRunner.Model.People>(Constants.ConnectionString,
                                                                                        txt_FileName.Text))
                {
                    _dapperEndTime = DateTime.Now;
                    txt_DapperSp_Stop.Text = _dapperEndTime.ToString("HH:mm:ss");

                    txt_DapperSp_Elapsed.Text = (_dapperEndTime - _dapperStartTime).ToString();
                }
                else
                {
                    txt_DapperSp_Elapsed.Text = @"Error";
                }  
            }

            if (chkInfintyDAL.Checked)
            {
               
                // Clear Database Table
                var genService = new iData.Core.Service.GenericService();
                genService.RunProc(iData.Core.Type.Database.patrickTest, "ClearTestPeople");

                try
                {


                    // Set Start Time
                    var starttime = DateTime.Now;
                    txtInfinityStart.Text = starttime.ToString(CultureInfo.InvariantCulture);

                    // Read Excel File
                    var excel = new ExcelQueryFactory {FileName = txt_FileName.Text};
                    var output = from x in excel.Worksheet<iData.Core.People>(0)
                                 select x;

                    // Insert Data
                    foreach (var people in output)
                    {
                        people.InsertRecord();
                    }

                    // Set End Time
                    var endtime = DateTime.Now;
                    txtInfinityStop.Text = endtime.ToString(CultureInfo.InvariantCulture);

                    // Set Elapsed Time
                    txtInfinityElapsed.Text = (endtime - starttime).ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Infinity DAL Error\n" + ex.Message);
                }
            }

            if (chk_Read1000SP.Checked)
            {
                _spRead1000StartTime = DateTime.Now;
                txt_Read1000SP_Start.Text = _spRead1000StartTime.ToString("HH:mm:ss");

                if (rep.GetUsingEFStoredProc())
                {
                    _spRead1000EndTime = DateTime.Now;
                    txt_Read1000SP_End.Text = _spRead1000EndTime.ToString("HH:mm:ss");

                    txt_Read1000SP_Elapsed.Text = (_spRead1000EndTime - _spRead1000StartTime).ToString();
                }
                else
                {
                    txt_Read1000SP_Elapsed.Text = @"Error";
                }
            }

            if (chk_Read1SP.Checked)
            {
                _spRead1StartTime = DateTime.Now;
                txt_Read1SP_Start.Text = _spRead1StartTime.ToString("HH:mm:ss");

                if (rep.GetOneUsingEFStoredProc())
                {
                    _spRead1EndTime = DateTime.Now;
                    txt_Read1SP_End.Text = _spRead1EndTime.ToString("HH:mm:ss");

                    txt_Read1SP_Elapsed.Text = (_spRead1EndTime - _spRead1StartTime).ToString();
                }
                else
                {
                    txt_Read1SP_Elapsed.Text = @"Error";
                }
            }
        }
    }
}
