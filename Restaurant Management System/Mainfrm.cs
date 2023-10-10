using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Restaurant_Management_System.Model;
using Restaurant_Management_System.View;


namespace Restaurant_Management_System
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        public int id = -1;
        //for blur background 
        static Mainfrm _obj;

        public static  Mainfrm Instance
        {
            get
            { 
                if(_obj == null) 
                {
                    _obj = new Mainfrm();
                } return _obj;
            }
        }



        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AddControl(Form f)
        {
            pnlMain.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            pnlMain.Controls.Add(f);
            f.Show();
        }


        private void Mainfrm_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
            lblUser.Text = Loginfrm.uname;
            _obj = this;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControl(new HomeFrm());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddControl(new CategoryViewfrm());

        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            AddControl(new TableViewfrm());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControl(new StaffViewfrm());

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AddControl(new ProductsViewfrm());
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POSfrm fr = new POSfrm();
            fr.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            AddControl(new KitchenViewfrm());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AddControl(new RepotsViewfrm());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingViewfrm frm = new SettingViewfrm();
            frm.id = id;
            AddControl(frm);
        }

    }
}
