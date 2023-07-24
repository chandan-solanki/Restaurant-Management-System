using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Restaurant_Management_System;
using Restaurant_Management_System.Reports;
using System.Data.SqlClient;

namespace Restaurant_Management_System.Model
{
    public partial class BillListfrm : SampleAdd
    {
        public BillListfrm()
        {
            InitializeComponent();
        }

      

        private void BillListfrm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public int MainID = 0;

        private void loadData()
        {
            string qry = @"select MainID , TableName , WaiterName,  orderType ,status, total 
            from tblMain where status <> 'Pending' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);

            MainClass.LoadData(qry, DataGridView, lb);

        }

        //for serial number formating
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int cnt = 0;
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                cnt++;
                row.Cells[0].Value = cnt;
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView.CurrentCell.OwningColumn.Name == "dgvedit")
            {
               
               MainID  = Convert.ToInt32(DataGridView.CurrentRow.Cells["dgvid"].Value);
               this.Close();
            }

            if (DataGridView.CurrentCell.OwningColumn.Name == "dgvprint")
            {
                int mainId = Convert.ToInt32(DataGridView.CurrentRow.Cells["dgvid"].Value);
              //print the bill 
                string qry = @"Select * from tblMain m inner join
                            tblDetails d on d.MainID = m.MainID
                            inner join products_info p on p.pId = d.proID
                            where m.MainID ='" + mainId + "' ";

               //string qry = @"select *from tblMain where MainID = '"+MainID+"'";
                Printfrm frm = new Printfrm();
                BillRpt cr = new BillRpt();
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(qry,con);
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string qry1 = @"insert into bill values(@MainID,@aDate,@aTime,@orderType,@custName,@TableName,@WaiterName,
                            @pName,@qty,@price,@amount,@received,@change)";
                    //string qry1 = @"insert into bill values(@MainID,@pName,@qty,@price,@amount)";
                    SqlCommand cmd1 = new SqlCommand(qry1, con);

                    cmd1.Parameters.AddWithValue("@MainID", Convert.ToInt32(row["MainID"]));
                    cmd1.Parameters.AddWithValue("@aDate", row["aDate"]);
                    cmd1.Parameters.AddWithValue("@aTime", row["aTime"].ToString());
                    cmd1.Parameters.AddWithValue("@orderType", row["orderType"].ToString());
                    cmd1.Parameters.AddWithValue("@custName", row["custName"].ToString());
                    cmd1.Parameters.AddWithValue("@TableName", row["TableName"].ToString());
                    cmd1.Parameters.AddWithValue("@WaiterName", row["WaiterName"].ToString());
                    cmd1.Parameters.AddWithValue("@pName", row["pName"].ToString());
                    cmd1.Parameters.AddWithValue("@qty",Convert.ToInt32( row["qty"]));
                    cmd1.Parameters.AddWithValue("@price",Convert.ToDouble( row["price"]));
                    cmd1.Parameters.AddWithValue("@amount", Convert.ToDouble(row["amount"]));
                    cmd1.Parameters.AddWithValue("@received", Convert.ToDouble(row["received"]));
                    cmd1.Parameters.AddWithValue("@change", Convert.ToDouble(row["change"]));

                    cmd1.ExecuteNonQuery();
                }

                string qry2 = "select *from bill";
                SqlCommand cmd2 = new SqlCommand(qry2, con);
                cmd2.CommandType = CommandType.Text;
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);


                cr.SetDataSource(dt2);
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.Refresh();
                frm.Show();
                string qry3 = "delete from bill";
                SqlCommand cmd3 = new SqlCommand(qry3, con);
                cmd3.ExecuteNonQuery();
                con.Close();
            }
        }
    }

   
}
