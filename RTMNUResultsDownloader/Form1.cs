using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebImageLib;

namespace RTMNUResultsDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ConnectionManager.RangeSelect((int)txtBxMin.Value, (int)txtBxMax.Value);
            ConnectionManager.SetScrapeState(true);
            ConnectionManager.Scrape();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionManager.SetCapabilities();
            ConnectionManager.Initialise();
            cbxFaculty.Items.AddRange(ConnectionManager.GetList("ddlselectfaculty").ToArray());
        }

        private void cbxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionManager.ListSelector("ddlselectfaculty", cbxFaculty.SelectedIndex);
            cbxExam.Items.Clear();
            cbxExam.Items.AddRange(ConnectionManager.GetList("ddlselectexam").ToArray());
        }

        private void cbxExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionManager.ListSelector("ddlselectexam", cbxExam.SelectedIndex);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ConnectionManager.SetScrapeState(false);
        }
    }
}
