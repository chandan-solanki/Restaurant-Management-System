using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Restaurant_Management_System.Reports;

namespace Restaurant_Management_System
{
    public partial class Printfrm : Form
    {
        public Printfrm()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Printfrm_Load(object sender, EventArgs e)
        {
           btnMax.PerformClick();
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
