using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Restaurant_Management_System
{
    public partial class Forgetfrm : Form
    {
        public Forgetfrm()
        {
            InitializeComponent();
        }

        private void Forgetfrm_Load(object sender, EventArgs e)
        {

        }

        public int id = -1;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtConPass.Text)
            {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("update user_info set uPassword = '" + txtNewPass.Text + "' where uId = '" + id + "'",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Forget Password Successfully !" , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                con.Close();
                this.Close();
                Loginfrm frm = new Loginfrm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please enter the same Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
