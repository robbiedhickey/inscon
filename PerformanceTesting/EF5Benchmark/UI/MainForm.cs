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
        private DateTime _elStartTime;
        private DateTime _elEndTime ;
        private DateTime _eliStartTime;
        private DateTime _eliEndTime;

        private DateTime _dapperStartTime;
        private DateTime _dapperEndTime;

        private DateTime _llblStartTime;
        private DateTime _llblEndTime;

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

        private void chk_EL_CheckedChanged(object sender, EventArgs e)
        {
            SetGoState();
        }

        private void chk_llblAdapter_CheckedChanged(object sender, EventArgs e)
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
            btn_Go.Enabled = (chk_EL.Checked || chk_SP.Checked || chk_ELI.Checked || chk_dapperSp.Checked || chk_llblAdapter.Checked || chkInfintyDAL.Checked) && _fileOK;
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

            if (chk_EL.Checked)
            {
                bool cleared = rep.ClearTable();

                _elStartTime = DateTime.Now;
                txt_ELStart.Text = _elStartTime.ToString("HH:mm:ss");

                if (rep.LoadUsingLinq(txt_FileName.Text))
                {
                    _elEndTime = DateTime.Now;
                    txt_ELEnd.Text = _elEndTime.ToString("HH:mm:ss");

                    txt_ELElapsed.Text = (_elEndTime - _elStartTime).ToString();
                }
                else
                {
                    txt_ELElapsed.Text = @"Error";
                }
            }

            if (chk_ELI.Checked)
            {
                bool cleared = rep.ClearTable();

                _eliStartTime = DateTime.Now;
                txt_ELIStart.Text = _eliStartTime.ToString("HH:mm:ss");

                if (rep.LoadUsingLinq(txt_FileName.Text))
                {
                    _eliEndTime = DateTime.Now;
                    txt_ELIEnd.Text = _eliEndTime.ToString("HH:mm:ss");

                    txt_ELIElapsed.Text = (_eliEndTime - _eliStartTime).ToString();
                }
                else
                {
                    txt_ELIElapsed.Text = @"Error";
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

            if (chk_llblAdapter.Checked)
            {
                bool cleared = rep.ClearTable();

                _llblStartTime = DateTime.Now;
                txt_Llbl_Start.Text = _llblStartTime.ToString("HH:mm:ss");

                if (new LLBLTestSuite().ExecuteWriteTest<DapperRunner.Model.People>(Constants.ConnectionString, txt_FileName.Text))
                {
                    _llblEndTime = DateTime.Now;

                    txt_Llbl_Stop.Text = _llblEndTime.ToString("HH:mm:ss");

                    txt_Llbl_Elapsed.Text = (_llblEndTime - _llblStartTime).ToString();
                }
                else
                {
                    txt_Llbl_Elapsed.Text = @"Error";
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
        }

       

        

        
    }
}
