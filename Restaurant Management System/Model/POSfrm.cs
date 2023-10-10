using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Restaurant_Management_System.Model
{
    public partial class POSfrm : Form
    {
        public POSfrm()
        {
            InitializeComponent();
        }

        public int MainId = 0;
        public int DriverID = 0;

        public string orderType = "";
        public string cusName = "";
        public string cusPhone = "";

        private void POSfrm_Load(object sender, EventArgs e)
        {
            dgvProductList.BorderStyle = BorderStyle.FixedSingle;
            AddCategoryBtn();
            ProductPanel.Controls.Clear();
            getProducts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //this method retrive data from the category table 
        //and paste information in the buttton 
        private void AddCategoryBtn()
        {
            string qry = "select *from category_info";

            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();

            if(dt.Rows.Count > 0)
            {

                foreach(DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(180, 45);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["catName"].ToString();
                    b.Font = new Font("Segoe UI,", 15);

                    //event for click 
                    b.Click += new EventHandler(b_Click);
                    CategoryPanel.Controls.Add(b);
                }
               
            }

            con.Close();

        }

        //this button for categoreies selection 
        private void b_Click(object sender , EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;

            if (b.Text == "All Categories")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.pCategory.ToLower().Contains(b.Text.Trim().ToLower());
            } 
        }


        //add item in the data grid view using user control product 
        //and update value like qty and amount of the price if the 
        //same product id exist in the datagridview  
        private void AddItem(string id, string  proID,string name, string cat, string price, Image pimage)
        {
            var pro = new ucProduct()
            {
                pName = name,
                pPrice = price,
                pCategory = cat,
                pImage = pimage,
                id = Convert.ToInt32(proID)
            };

            //this line add the ucProduct in --> the product panel
            ProductPanel.Controls.Add(pro);


            //event on the onSelect 
            pro.onSelect += (ss, ee) =>
            {
                var ucPro = (ucProduct)ss;

                foreach(DataGridViewRow item in dgvProductList.Rows)
                {

                    //this line check the already product here then update quanty and amount(qty * price)
                    if (Convert.ToInt32(item.Cells["dgvproId"].Value) == ucPro.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString())
                            * double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        getTotal();
                        //this line important for new product in row 
                        return;
                    }

                }

                //this line for add new row of product 
                dgvProductList.Rows.Add(new object[] { 0, 0,ucPro.id, ucPro.pName, 1, ucPro.pPrice, ucPro.pPrice });
                getTotal();
            };
        }


        //get products from the database
        private void getProducts()
        {
            string qry = "select *from products_info inner join category_info on catId = CategoryID";
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imageBytearr = (byte[])item["pImage"];
                byte[] imagebytearr = imageBytearr;

                AddItem("0",item["pId"].ToString(), item["pName"].ToString(), item["catName"].ToString(),
                item["pPrice"].ToString(),Image.FromStream(new MemoryStream(imagebytearr)));
            }

            con.Close();

        }


        //for search products in text box and visible item
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.pName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }


        //for serial number formating
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int cnt = 0;
            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                cnt++;
                row.Cells[0].Value = cnt;
            }
        }


        //get Total
        private void getTotal()
        {
            double total = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                total += double.Parse(row.Cells["dgvAmount"].Value.ToString());
            }

            lblTotal.Text = total.ToString("N2");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblWaiter.Text = "";
            lblTable.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            dgvProductList.Rows.Clear();
            MainId = 0;
            lblTotal.Text = "0.00";
            orderType = "";
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            lblWaiter.Text = "";
            lblTable.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            orderType = "Delivery";

            AddCustomer frm = new AddCustomer();
            frm.MainID = MainId;
            frm.ordertype = orderType;
            MainClass.BlurBackground(frm);

            if (frm.txtName.Text != "") 
            {
                DriverID = frm.DriverID;
                lblDriverName.Text = "Customer Name : " + frm.txtName.Text + " Phone : " + frm.txtPhone.Text + " Driver : " + frm.cbDriver.Text;
                lblDriverName.Visible = true;
                cusName = frm.txtName.Text;
                cusPhone = frm.txtPhone.Text;
            }

        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            lblWaiter.Text = "";
            lblTable.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            orderType = "Take Away";

            AddCustomer frm = new AddCustomer();
            frm.MainID = MainId;
            frm.ordertype = orderType;
            MainClass.BlurBackground(frm);

            if(frm.txtName.Text != "") //as take away did  not have driver info
            {
                DriverID = frm.DriverID;
                lblDriverName.Text = "Customer Name : " + frm.txtName.Text + " Phone : " + frm.txtPhone.Text;
                lblDriverName.Visible = true;
                cusName = frm.txtName.Text;
                cusPhone = frm.txtPhone.Text;
            }
        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            //create form of table select and waiter select
            orderType = "Din in";
            lblDriverName.Visible = false;
            TableSelectfrm ts = new TableSelectfrm();
            MainClass.BlurBackground(ts);
            if (ts.tableName != "")
            {
                lblTable.Text = ts.tableName;
                lblTable.Visible = true;
            }
            else 
            {
                lblTable.Text = "";
                lblTable.Visible = false;
            }

            WaiterSelectfrm ws = new WaiterSelectfrm();
            MainClass.BlurBackground(ws);

            if (ws.waiterName != "")
            {
                lblWaiter.Text = ws.waiterName;
                lblWaiter.Visible = true;
            }
            else
            {
                lblWaiter.Text = "";
                lblWaiter.Visible = false;
            }
        }

        private void btnKOT_Click(object sender, EventArgs e)
        {
            //SAVE THE DATA IN THE DATABASE 
            //save the addtional driver information save 

            string qry1 = "";//for Main Table
            string qry2 = "";//for Table Details

            int detailID = 0;

            if (orderType == "")
            {
                MessageBox.Show("Please select order type !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (MainId == 0)//insert 
            {
                qry1 = @"insert into tblMain values(@aDate,@aTime,
                        @TableName,@WaiterName,@status,@orderType,@total,@received,@change,@driverID,@custName,@custPhone);
                            Select SCOPE_IDENTITY()";

                //this line will get recent add id value 
            }
            else //update
            {
                qry1 = @"update tblMain set status = @status , total = @total , 
                received = @received, change = @change where MainID = @ID";
            }


            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(qry1,con);

            cmd.Parameters.AddWithValue("@ID",MainId);
            cmd.Parameters.AddWithValue("@aDate", DateTime.Now.ToString("d"));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", orderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", DriverID);
            cmd.Parameters.AddWithValue("@custName", cusName);
            cmd.Parameters.AddWithValue("@custPhone", cusPhone);


            if (con.State == ConnectionState.Closed) { con.Open(); }
            if (MainId == 0) { MainId = Convert.ToInt32(cmd.ExecuteScalar());} else { cmd.ExecuteNonQuery();}
            if (con.State == ConnectionState.Open) { con.Close(); }


            //insert the datagrid productlist grid view in to tblDetails table 
            foreach(DataGridViewRow row in dgvProductList.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

               if (detailID == 0) //insert
               {
                    qry2 = @"insert into tblDetails values(@MainID,@proID,@qty,@price,@amount)";
               }
               else //update  
               {
                   qry2 = @"update tblDetails set proID = @proID, qty = @qty,price = @price,amount = @amount
                                where DetailID = @ID";
               }

                SqlCommand cmd2 = new SqlCommand(qry2, con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainId);
                cmd2.Parameters.AddWithValue("@proID",Convert.ToInt32( row.Cells["dgvproId"].Value));
                cmd2.Parameters.AddWithValue("@qty",Convert.ToInt32( row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price",Convert.ToDouble( row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount",Convert.ToDouble( row.Cells["dgvAmount"].Value));

                if (con.State == ConnectionState.Closed) { con.Open(); }
                cmd2.ExecuteNonQuery(); 
                if (con.State == ConnectionState.Open) { con.Close(); }
            }

                MessageBox.Show("Saved Successfully !" ,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MainId = 0;
                detailID = 0;
                dgvProductList.Rows.Clear();

                //all reset 
                lblWaiter.Text = "";
                lblTable.Text = "";
                lblTable.Visible = false;
                lblWaiter.Visible = false;
                lblTotal.Text = "0.00";
                lblDriverName.Text = "";
                orderType = "";
   
        }

        public int billid = 0;

        private void btnBill_Click(object sender, EventArgs e)
        {
            BillListfrm frm = new BillListfrm();
            MainClass.BlurBackground(frm);
            
            if(frm.MainID > 0)
            {
                billid = frm.MainID;
                MainId = frm.MainID;
                loadEntries();
            }
        }

        private void loadEntries()
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            string qry = @"select *from tblMain m inner join tblDetails d on m.MainID = d.MainID
                inner join products_info p on p.pId = d.proID
                where m.MainID = '" + billid + "'";


            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if(dt.Rows[0]["orderType"].ToString() == "Delivery")
            {
                btnDelivery.Checked = true;
                lblWaiter.Visible = false;
                lblTable.Visible = false;
                lblDriverName.Visible = true;
            }

            else if(dt.Rows[0]["orderType"].ToString() == "Take Away")
            {
                btnTake.Checked = true;
                lblWaiter.Visible = false;
                lblTable.Visible = false;
                lblDriverName.Visible = true;
            }

            else
            {
                btnDin.Checked = true;
                lblWaiter.Visible = true;
                lblTable.Visible = true;
            }


            dgvProductList.Rows.Clear();

            foreach(DataRow item in dt.Rows)
            {
                lblTable.Text = item["TableName"].ToString();
                lblWaiter.Text = item["WaiterName"].ToString();
                lblDriverName.Text = "Customer Name : " + item["custName"].ToString() + " Phone : " + item["custPhone"].ToString();
                string detailId = item["DetailID"].ToString();
                string proName = item["pName"].ToString();
                string proId = item["pId"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();

                object[] obj = { 0, detailId, proId, proName,qty, price, amount };
                dgvProductList.Rows.Add(obj);
            }
            getTotal();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckOutfrm frm = new CheckOutfrm();
            frm.MainID = billid;
            frm.amount = Convert.ToDouble(lblTotal.Text);
            MainClass.BlurBackground(frm);

            MainId = 0;
            billid = 0;
            dgvProductList.Rows.Clear();

            ////all reset 
            lblWaiter.Text = "";
            lblTable.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.00";
        }


        private void btnHold_Click(object sender, EventArgs e)
        {
            //SAVE THE DATA IN THE DATABASE 

            string qry1 = "";//for Main Table
            string qry2 = "";//for Table Details

            int detailID = 0;

            if(orderType == "")
            {
                MessageBox.Show("Please select order type !","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (MainId == 0)//insert 
            {
                qry1 = @"insert into tblMain values(@aDate,@aTime,
                        @TableName,@WaiterName,@status,@orderType,@total,@received,@change,@driverID,@custName,@custPhone);
                            Select SCOPE_IDENTITY()";

                //this line will get recent add id value 
            }

            else //update
            {
                qry1 = @"update tblMain set status = @status , total = @total , 
                received = @received, change = @change where MainID = @ID";
            }


            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(qry1, con);

            cmd.Parameters.AddWithValue("@ID", MainId);
            cmd.Parameters.AddWithValue("@aDate", DateTime.Now.ToString("d"));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Hold");
            cmd.Parameters.AddWithValue("@orderType", orderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", DriverID);
            cmd.Parameters.AddWithValue("@custName", cusName);
            cmd.Parameters.AddWithValue("@custPhone", cusPhone);

            if (con.State == ConnectionState.Closed) { con.Open(); }
            if (MainId == 0) { MainId = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (con.State == ConnectionState.Open) { con.Close(); }


            //insert the datagrid productlist grid view in to tblDetails table 
            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0) //insert
                {
                    qry2 = @"insert into tblDetails values(@MainID,@proID,@qty,@price,@amount)";
                }
                else //update  
                {
                    qry2 = @"update tblDetails set proID = @proID, qty = @qty,price = @price,amount = @amount
                                where DetailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainId);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproId"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (con.State == ConnectionState.Closed) { con.Open(); }
                cmd2.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }

            MessageBox.Show("Saved Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainId = 0;
            detailID = 0;
            dgvProductList.Rows.Clear();

            //all reset 
            lblWaiter.Text = "";
            lblTable.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.00";
            lblDriverName.Text = "";
            orderType = "";
        }

        private void ProductPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
