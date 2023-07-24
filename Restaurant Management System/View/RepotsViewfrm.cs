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


namespace Restaurant_Management_System.View
{
    public partial class RepotsViewfrm : Form
    {
        public RepotsViewfrm()
        {
            InitializeComponent();
        }

        private void RepotsViewfrm_Load(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            string qry = @"Select * from staff_info";

            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            StaffListRpt cr = new StaffListRpt();
            Printfrm frm = new Printfrm();

            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();

        }

        private void btnSaleCat_Click(object sender, EventArgs e)
        {
            SaleByCatefrm frm = new SaleByCatefrm();
            frm.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            string qry = @"Select * from products_info";

            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            MenuListRpt cr = new MenuListRpt();
            Printfrm frm = new Printfrm();

            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }

  
    }
}
