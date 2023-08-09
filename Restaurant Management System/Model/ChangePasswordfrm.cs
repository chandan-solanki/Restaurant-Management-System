using System;
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
    public partial class ChangePasswordfrm : Form
    {
        public ChangePasswordfrm()
        {
            InitializeComponent();
        }

        public int id = -1;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text != txtCnfPass.Text)
            {
                MessageBox.Show("Please enter same password in both field !" , "Error" , MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else if (txtOldPass.Text == "")
            {
                MessageBox.Show("Please Enter the Old Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("select *from user_info where uId = '"+id+"'",con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string oldPwd = dt.Rows[0][2].ToString() ;
                if(oldPwd == txtOldPass.Text)
                {
                    try 
                    {
                        SqlCommand cmd1 = new SqlCommand("update user_info set uPassword = '" + txtNewPass.Text + "' where uId = '" + id + "'", con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Password Change Successfully !","Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                        this.Close();
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.ToString() , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Enter the correct old password !" ,"Error",MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
                con.Close();
            }
        }
    }
}
