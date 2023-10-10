using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Data.SqlClient;


namespace Restaurant_Management_System.Model
{
    public partial class ProductAddfrm : SampleAdd
    {
        public ProductAddfrm()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int cID = 0;

        private void ProductAddfrm_Load(object sender, EventArgs e)
        {
            //for fill cb
            string qry = "select catId 'id' , catName 'name' from category_info";

            MainClass.CBfil(qry,cbCat);

            if(cID > 0) //for update
            {
                cbCat.SelectedValue = cID;
            }

            if(id > 0)
            {
                updateLoadData();
            }
        }


        public string filePath;
        Byte[] imageBytearr;

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|*.png; *jpg";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                txtImage.Image = new Bitmap(filePath);
            }
        }


        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text == "" || txtName.Text == "" || cbCat.Text == "")
            {
                MessageBox.Show("Please enter all fields !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                string qry = "";
                //insert the data
                if (id == 0)
                {
                    qry = "insert into products_info values(@Name,@Price,@Cat,@Image)";

                }
                //update the data
                else
                {
                    qry = "update products_info set pName = @Name , pPrice = @Price, CategoryID = @Cat,pImage = @Image where pId = '" + id + "'";
                }

                //for image store
                Image temp = new Bitmap(txtImage.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageBytearr = ms.ToArray();
                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@Name", txtName.Text);
                ht.Add("@Price", txtPrice.Text);
                ht.Add("@Cat", Convert.ToInt32(cbCat.SelectedValue));
                ht.Add("@Image", imageBytearr);

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
                    cID = 0;
                    txtName.Text = "";
                    txtName.Focus();
                    txtPrice.Clear();
                    cbCat.SelectedIndex = -1;
                    txtImage.Image = Restaurant_Management_System.Properties.Resources.brand_identity;
                }
            }
        }

        private void updateLoadData()
        {
            string qry = "select *from products_info where pId = '" + id + "'";
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(qry,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["pName"].ToString();
                txtPrice.Text = dt.Rows[0]["pPrice"].ToString();


                Byte[] imageArr = (byte[])(dt.Rows[0]["pImage"]);
                byte[] imgBytearr = imageArr;
                txtImage.Image = Image.FromStream(new MemoryStream(imgBytearr));

            }


        }

    }
}
