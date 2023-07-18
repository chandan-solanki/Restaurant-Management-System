﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Restaurant_Management_System.Model
{
    public partial class TableSelectfrm : Form
    {
        public TableSelectfrm()
        {
            InitializeComponent();
        }

        public string tableName;

        private void TableSelectfrm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            string qry = "select *from table_info";
            SqlCommand cmd = new SqlCommand(qry,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.Text = row["tName"].ToString();
                b.Width = 150;
                b.Height = 50;
                b.FillColor = Color.FromArgb(241,85,126);
                b.HoverState.FillColor = Color.FromArgb(50, 55, 89);

                //event for click 
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);
            }
        }


        private void b_Click(object sender, EventArgs e)
        {
            tableName = (sender as Guna.UI2.WinForms.Guna2Button).Text.ToString();
            this.Close();
        }
    }
}
