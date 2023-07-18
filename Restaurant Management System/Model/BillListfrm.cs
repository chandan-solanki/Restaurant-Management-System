using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Restaurant_Management_System;

namespace Restaurant_Management_System.Model
{
    public partial class BillListfrm : SampleAdd
    {
        public BillListfrm()
        {
            InitializeComponent();
        }

      

        private void BillListfrm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public int MainID = 0;

        private void loadData()
        {
            string qry = @"select MainID , TableName , WaiterName,  orderType ,status, total 
            from tblMain where status <> 'Pending' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);

            MainClass.LoadData(qry, DataGridView, lb);

        }

        //for serial number formating
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int cnt = 0;
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                cnt++;
                row.Cells[0].Value = cnt;
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView.CurrentCell.OwningColumn.Name == "dgvedit")
            {
               
               MainID  = Convert.ToInt32(DataGridView.CurrentRow.Cells["dgvid"].Value);
               this.Close();
            }

            if (DataGridView.CurrentCell.OwningColumn.Name == "dgvprint")
            {
               
               MainID  = Convert.ToInt32(DataGridView.CurrentRow.Cells["dgvid"].Value);
               this.Close();
            }


        }
    }

   
}
