using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Restaurant_Management_System.Model;

namespace Restaurant_Management_System.View
{
    public partial class SettingViewfrm : Form
    {
        public SettingViewfrm()
        {
            InitializeComponent();
        }

        public int id = -1;



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangePasswordfrm frm = new ChangePasswordfrm();
            frm.id = id;
            frm.Show();
        }


    }
}
