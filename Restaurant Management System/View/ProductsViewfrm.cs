using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Restaurant_Management_System.Model;

namespace Restaurant_Management_System.View
{
    public partial class ProductsViewfrm : SampleView
    {
        public ProductsViewfrm()
        {
            InitializeComponent();
        }

        private void ProductsViewfrm_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            string qry = "SELECT p.pId, p.pName, p.pPrice, p.CategoryID, c.catName FROM products_info AS p INNER JOIN category_info AS c ON c.catId = p.CategoryID where pName like '%" + txtSearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvCatID);
            lb.Items.Add(dgvCat);

            MainClass.LoadData(qry, DataGridView, lb);
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            //CategoryAddfrm fr = new CategoryAddfrm();
            //fr.ShowDialog();
            MainClass.BlurBackground(new ProductAddfrm());
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
                ProductAddfrm fr = new ProductAddfrm();
                fr.id = Convert.ToInt32(DataGridView.CurrentRow.Cells["dgvid"].Value);
                fr.txtName.Text = Convert.ToString(DataGridView.CurrentRow.Cells["dgvName"].Value);
                fr.txtPrice.Text = Convert.ToString(DataGridView.CurrentRow.Cells["dgvPrice"].Value);
                fr.cbCat.Text = Convert.ToString(DataGridView.CurrentRow.Cells["dgvCat"].Value);
                fr.cID = Convert.ToInt32(DataGridView.CurrentRow.Cells["dgvCatID"].Value);

                MainClass.BlurBackground(fr);
                getData();
            }

            if (DataGridView.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure delete record ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ProductAddfrm fr = new ProductAddfrm();
                    fr.id = Convert.ToInt32(DataGridView.CurrentRow.Cells["dgvid"].Value);
                    string qry = "delete from products_info where pId = '" + fr.id + "'";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);

                    MessageBox.Show("Delete Successfully !");
                    getData();
                }

            }

        }


       
    }
}
