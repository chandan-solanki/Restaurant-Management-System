namespace Restaurant_Management_System.Model
{
    partial class ucProduct
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            this.pnlProduct = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlProduct.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProduct
            // 
            this.pnlProduct.BackColor = System.Drawing.Color.Transparent;
            this.pnlProduct.Controls.Add(this.guna2Separator1);
            this.pnlProduct.Controls.Add(this.guna2Panel1);
            this.pnlProduct.Controls.Add(this.txtImage);
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProduct.FillColor = System.Drawing.Color.White;
            this.pnlProduct.Location = new System.Drawing.Point(0, 0);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.ShadowColor = System.Drawing.Color.Black;
            this.pnlProduct.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Surrounded;
            this.pnlProduct.Size = new System.Drawing.Size(178, 181);
            this.pnlProduct.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(3, 137);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(172, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblProductName);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 141);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(178, 40);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(19, 6);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(141, 23);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImage
            // 
            this.txtImage.Image = ((System.Drawing.Image)(resources.GetObject("txtImage.Image")));
            this.txtImage.Location = new System.Drawing.Point(16, 16);
            this.txtImage.Name = "txtImage";
            this.txtImage.ShadowDecoration.Parent = this.txtImage;
            this.txtImage.Size = new System.Drawing.Size(147, 113);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 0;
            this.txtImage.TabStop = false;
            this.txtImage.Click += new System.EventHandler(this.txtImage_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlProduct);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(178, 181);
            this.pnlProduct.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlProduct;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblProductName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2PictureBox txtImage;
    }
}
