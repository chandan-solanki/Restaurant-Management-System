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
    public partial class ConfirmFrm : Form
    {
        public ConfirmFrm()
        {
            InitializeComponent();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                MessageBox.Show("Enter your Username !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(cmSecurity.Text == "")
            {
                MessageBox.Show("Select your Security Question !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (ansTxt.Text == "")
            {
                MessageBox.Show("Enter your Security Answer !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("select *from user_info where uName = '" + txtUser.Text + "' and uQuestion = '" + cmSecurity.Text + "' and uAnswer = '" + ansTxt.Text + "'", con);
               // SqlDataReader dr = cmd.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int id = Convert.ToInt32(dt.Rows[0][0]);
                    MessageBox.Show("Your information is right !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forgetfrm frm = new Forgetfrm();
                    frm.Show();
                    frm.id = id;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter the correct information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Loginfrm frm = new Loginfrm();
            frm.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmSecurity.SelectedIndex = 0;
            ansTxt.Clear();
            txtUser.Clear();
        }

        private void ansTxt_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
