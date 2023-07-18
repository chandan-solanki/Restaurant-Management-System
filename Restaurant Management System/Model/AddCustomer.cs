using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_Management_System.Model
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        public string ordertype = "";
        public int MainID = 0;
        public int DriverID = 0;
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            if(ordertype == "Take Away")
            {
                lblDriver.Visible = false;
                cbDriver.Visible = false;

            }

            string qry = "select  staffId 'id', sName 'name' from staff_info where sRole = 'Driver'";
            MainClass.CBfil(qry,cbDriver);

            if(MainID > 0)
            {
                cbDriver.SelectedValue = DriverID;
            }

        }

        private void cbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriverID = Convert.ToInt32(cbDriver.SelectedValue);

        }
    }
}
