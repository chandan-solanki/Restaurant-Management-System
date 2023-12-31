﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    public partial class Registrationfrm : Form
    {
        public Registrationfrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Loginfrm lf = new Loginfrm();
            this.Hide();
            lf.Show();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please enter all fields ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

                con.Open();
                //SqlCommand cmd = new SqlCommand("insert into user_info values('" + txtUser.Text + "','" + txtPass.Text + "','" + txtPhone.Text + "')", con);
                SqlCommand cmd = new SqlCommand("insert into user_info values(@uname,@upassword,@usecurity,@uanswer,@uphone)", con);
                cmd.Parameters.AddWithValue("@uname", txtUser.Text);
                cmd.Parameters.AddWithValue("@upassword", txtPass.Text);
                cmd.Parameters.AddWithValue("@usecurity", cmSecurity.Text);
                cmd.Parameters.AddWithValue("@uanswer", ansTxt.Text);
                cmd.Parameters.AddWithValue("@uphone", txtPhone.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    clearField();
                    MessageBox.Show("Create Account Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
            
        }

        private void clearField()
        {
            txtPass.Clear();
            txtUser.Clear();
            txtPhone.Clear();
            cmSecurity.SelectedIndex = 0;
            ansTxt.Clear();
 
        }

        private void Registrationfrm_Load(object sender, EventArgs e)
        {
            cmSecurity.SelectedIndex = 0;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
