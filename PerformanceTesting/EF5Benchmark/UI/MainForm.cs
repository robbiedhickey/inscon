using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSI.EF5Benchmark.DAL;

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

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Title = "Select File to Load";
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
            btn_Go.Enabled = (chk_EL.Checked || chk_SP.Checked || chk_ELI.Checked) && _fileOK;
        }

        private void RunTests()
        {
            Repository rep = new Repository();

            if (chk_SP.Checked)
            {
                bool cleared = rep.ClearTable();

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
                    txt_SPElapsed.Text = "Error";
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
                    txt_ELElapsed.Text = "Error";
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
                    txt_ELIElapsed.Text = "Error";
                }
            }
        }
    }
}
