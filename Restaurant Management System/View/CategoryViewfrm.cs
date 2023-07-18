using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Restaurant_Management_System.Model;
using System.Collections;


namespace Restaurant_Management_System.View
{
    public partial class CategoryViewfrm : SampleView
    {
        public CategoryViewfrm()
        {
            InitializeComponent();
        }

        public void getData()
        {
           string qry = "Select *from category_info where catName like '%" + txtSearch.Text + "%'";
           ListBox lb =  new ListBox();
           lb.Items.Add(dgvid);
           lb.Items.Add(dgvName);
           MainClass.LoadData(qry,DataGridView,lb);
        }

        private void CategoryViewfrm_Load(object sender, EventArgs e)
        {
            getData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            //CategoryAddfrm fr = new CategoryAddfrm();
            //fr.ShowDialog();
            MainClass.BlurBackground(new CategoryAddfrm());
            getData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                CategoryAddfrm fr = new CategoryAddfrm();
                fr.id = Convert.ToInt32(DataGridView.CurrentRow.Cells["dgvid"].Value);
                fr.txtName.Text = Convert.ToString(DataGridView.CurrentRow.Cells["dgvName"].Value);
                MainClass.BlurBackground(fr);
                getData();
            }

            if (DataGridView.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure delete record ?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    CategoryAddfrm fr = new CategoryAddfrm();
                    fr.id = Convert.ToInt32(DataGridView.CurrentRow.Cells["dgvid"].Value);
                    string qry = "delete from category_info where catId = '" + fr.id + "'";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);

                    MessageBox.Show("Delete Successfully !");
                    getData();
                }
               
            }
        }

    }
}
