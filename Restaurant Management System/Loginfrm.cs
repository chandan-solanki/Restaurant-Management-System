using System;
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
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }

        public static string uname = "";

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registrationfrm rf = new Registrationfrm();
            this.Hide();
            rf.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please enter all fields ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("select *from user_info where uName = '" + txtUser.Text + "' and uPassword = '" + txtPass.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Mainfrm mf = new Mainfrm();
                    this.Hide();
                    uname = txtUser.Text;
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Valid User Name and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                con.Close();
            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else 
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }


    }
}
