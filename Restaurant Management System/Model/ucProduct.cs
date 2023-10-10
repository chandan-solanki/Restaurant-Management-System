using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Restaurant_Management_System.Model;


namespace Restaurant_Management_System.Model
{

    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }


        public int id { get; set; }

        public string pPrice { get; set; }

        public string pCategory { get; set; }

        public event EventHandler onSelect = null;

        public string pName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        public Image pImage
        {
            get {  return txtImage.Image; }
            set { txtImage.Image = value; }
        }


        private void txtImage_Click(object sender, EventArgs e)
        {
            try 
            {
                if (this.onSelect != null)
                {
                    this.onSelect(this, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error of select product : " + ex.ToString());
            }
        }

    }
}
