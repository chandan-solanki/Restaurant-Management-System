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
    public partial class CategoryAddfrm : SampleAdd
    {
        public CategoryAddfrm()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {

                string qry = "";
                //insert the data
                if (id == 0)
                {
                    qry = "insert into category_info values(@Name)";

                }
                //update the data
                else
                {
                    qry = "update category_info set catName = @Name where catId = @id";
                }

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@Name", txtName.Text);

                if (MainClass.SQL(qry, ht) > 0)
                {
                    if (id == 0)
                    {
                        MessageBox.Show("Insert Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    id = 0;
                    txtName.Text = "";
                    txtName.Focus();
                }
            }

            else
            {
                MessageBox.Show("Please enter all fields !!" , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

    }
}
