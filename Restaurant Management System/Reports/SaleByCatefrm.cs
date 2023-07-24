using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant_Management_System.Reports
{
    public partial class SaleByCatefrm : Form
    {
        public SaleByCatefrm()
        {
            InitializeComponent();
        }

        private void SaleByCatefrm_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string qry = @"Select * from tblMain m  
                            inner join tblDetails d on m.MainID = d.MainID
                            inner join products_info p on p.pId = d.proID
                            inner join category_info c on c.catId = p.CategoryID
                            where m.aDate between @sdate and @edate";

            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@sdate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@edate", dateTimePicker2.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                string qry1 = @"insert into salebycat values(@MainID,@catName,@aDate,@pName,
                                @qty,@price,@amount)";
                SqlCommand cmd1 = new SqlCommand(qry1, con);

                cmd1.Parameters.AddWithValue("@MainID", Convert.ToInt32(row["MainID"]));
                cmd1.Parameters.AddWithValue("@catName", row["catName"].ToString());
                cmd1.Parameters.AddWithValue("@aDate", row["aDate"].ToString());
                cmd1.Parameters.AddWithValue("@pName", row["pName"].ToString());
                cmd1.Parameters.AddWithValue("@qty", Convert.ToInt32(row["qty"]));
                cmd1.Parameters.AddWithValue("@price", Convert.ToDouble(row["price"]));
                cmd1.Parameters.AddWithValue("@amount", Convert.ToDouble(row["amount"]));

                cmd1.ExecuteNonQuery();
            }

            string qry2 = "select *from salebycat";
            SqlCommand cmd2 = new SqlCommand(qry2, con);
            cmd2.CommandType = CommandType.Text;
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            saleByCatRpt cr = new saleByCatRpt();
            Printfrm frm = new Printfrm();

            cr.SetDataSource(dt2);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
            string qry3 = "delete from salebycat";
            SqlCommand cmd3 = new SqlCommand(qry3, con);
            cmd3.ExecuteNonQuery();
            con.Close();
        }
    }
}
