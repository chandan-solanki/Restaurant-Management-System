using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace Restaurant_Management_System.View
{
    public partial class KitchenViewfrm : Form
    {
        public KitchenViewfrm()
        {
            InitializeComponent();
        }

        private void KitchenViewfrm_Load(object sender, EventArgs e)
        {
            getOrders();
        }

        private void getOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry = @"select *from tblMain where status = 'Pending'";
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            FlowLayoutPanel p1;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 230;
                p1.Height = 450;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(20,20,20,20);

                FlowLayoutPanel p2 = new FlowLayoutPanel();
                p2.BackColor = Color.FromArgb(50,55,89);
                p2.AutoSize = true;
                p2.Width = 230;
                p2.Height = 350;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(0, 0, 0, 0);

                Label l1 = new Label();
                l1.ForeColor = Color.White;
                l1.Margin = new Padding(10,10,3,10);
                l1.AutoSize = true;

                Label l2 = new Label();
                l2.ForeColor = Color.White;
                l2.Margin = new Padding(10, 5, 3, 10);
                l2.AutoSize = true;

                Label l3 = new Label();
                l3.ForeColor = Color.White;
                l3.Margin = new Padding(10, 5, 3, 10);
                l3.AutoSize = true;

                Label l4 = new Label();
                l4.ForeColor = Color.White;
                l4.Margin = new Padding(10, 5, 3, 10);
                l4.AutoSize = true;

                l1.Text = "Table : " + dt.Rows[i]["TableName"].ToString();
                l2.Text = "Waiter Name : " + dt.Rows[i]["WaiterName"].ToString();
                l3.Text = "Order Time : " + dt.Rows[i]["aTime"].ToString();
                l4.Text = "Order Type : " + dt.Rows[i]["orderType"].ToString();

                p2.Controls.Add(l1);
                p2.Controls.Add(l2);
                p2.Controls.Add(l3);
                p2.Controls.Add(l4);

                p1.Controls.Add(p2);

                //now add products
                int mId = 0;
                mId = Convert.ToInt32(dt.Rows[i]["MainId"].ToString());
                string qry1 = @"Select *from tblMain m inner join tblDetails d on m.MainID = d.MainID
                inner join products_info p on p.pId = d.proID
                where m.MainID = '"+mId+"'";

                SqlCommand cmd1 = new SqlCommand(qry1, con);
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);

                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    Label l5 = new Label();
                    l5.ForeColor = Color.Black;
                    l5.Margin = new Padding(10, 5, 3, 5);
                    l5.AutoSize = true;

                    int no = j + 1;
                    l5.Text = "" + no + " " + dt1.Rows[j]["pName"].ToString() + " " + dt1.Rows[j]["qty"].ToString(); 
                    p1.Controls.Add(l5);
                }

                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.AutoRoundedCorners = true;
                b.Size = new Size(100,35);
                b.FillColor = Color.FromArgb(241,85,126);
                b.Margin = new Padding(30,5,3,10);
                b.Text = "Complete";
                b.Tag = dt.Rows[i]["MainID"].ToString(); // store the id
                b.Click += new EventHandler(b_click);
                p1.Controls.Add(b);
                flowLayoutPanel1.Controls.Add(p1);

            }
        }

        private void b_click(object sender , EventArgs e)
        {
            int id = Convert.ToInt32((sender as Guna.UI2.WinForms.Guna2Button).Tag.ToString());

            DialogResult dr = MessageBox.Show("Are you sure you want to delete ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
          
                string qry = @"update tblMain set status = 'Complete' where MainID = @ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID",id);
                if(MainClass.SQL(qry,ht) > 0) 
                {
                    MessageBox.Show("Save Succssfully !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                getOrders();       
            }
        }
    }
}
