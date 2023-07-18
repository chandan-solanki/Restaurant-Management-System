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

namespace Restaurant_Management_System
{
    class MainClass
    {
        
        //Method for CRUD Operation 
        public static int SQL(string qry, Hashtable ht)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                
                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString() , item.Value);

                }

                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

            return res;
        }


        //Load Data from the database
        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            try
            {
                
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colname1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colname1].DataPropertyName = dt.Columns[i].ToString();

                }

                gv.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

 
        }

        //cell formating event 
        public static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int cnt = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                cnt++;
                row.Cells[0].Value = cnt;
            }
           
        }


        //for blur background 
        public static void BlurBackground(Form Model)
        {
            Form background = new Form();
            using (Model)
            {
                background.StartPosition = FormStartPosition.Manual;
                background.FormBorderStyle= FormBorderStyle.None;
                background.Opacity = 0.5d;
                background.BackColor = Color.Black;
                background.Size = Mainfrm.Instance.Size;
                background.Location = Mainfrm.Instance.Location;
                background.ShowInTaskbar =false;
                background.Show();
                Model.Owner = background;
                Model.ShowDialog(background);
                background.Dispose();

            }
        }

        //for cb fill
        public static void CBfil(string qry , ComboBox cb)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();

            try
            {

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cb.DisplayMember = "name";
                cb.ValueMember = "id";
                cb.DataSource = dt;
                cb.SelectedIndex = -1;

            }

            catch(Exception ex)
            {
                MessageBox.Show("combo box not filled " + ex.ToString(),"error",MessageBoxButtons.OK);
            }
            if (con.State == ConnectionState.Closed) { con.Open(); }
            if (con.State == ConnectionState.Open) { con.Close(); }
        }
    }
}
