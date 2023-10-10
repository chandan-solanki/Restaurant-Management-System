using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Restaurant_Management_System.Model
{
    public partial class CheckOutfrm : SampleAdd
    {
        public CheckOutfrm()
        {
            InitializeComponent();
        }

        public double amount = 0;
        public int MainID = 0;

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {
            double amount = 0;
            double receipt = 0;
            double change = 0;


            double.TryParse(txtBillAmount.Text, out amount);
            double.TryParse(txtReceived.Text , out receipt);

            change = Math.Abs( amount - receipt); // convert negative values into postive 
            txtChange.Text = change.ToString();
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = @"update tblMain set total = @total , received = @rec , change = @change,
                status = 'Paid' where MainID = @ID";
            Hashtable ht = new Hashtable();
            ht.Add("@ID", MainID);
            ht.Add("@total",txtBillAmount.Text);
            ht.Add("@rec", txtReceived.Text);
            ht.Add("@change", txtChange.Text);

            if(MainClass.SQL(qry,ht) > 0)
            {
                MessageBox.Show("Save Successfully !","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CheckOutfrm_Load(object sender, EventArgs e)
        {
            txtBillAmount.Text = amount.ToString() ;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBillAmount_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
