namespace Restaurant_Management_System.Model
{
    partial class ProductAddfrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(914, 130);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Restaurant_Management_System.Properties.Resources.box;
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.Text = "Product Details";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(914, 76);
            // 
            // cbCat
            // 
            this.cbCat.BackColor = System.Drawing.Color.Transparent;
            this.cbCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FocusedColor = System.Drawing.Color.Empty;
            this.cbCat.FocusedState.Parent = this.cbCat;
            this.cbCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCat.FormattingEnabled = true;
            this.cbCat.HoverState.Parent = this.cbCat;
            this.cbCat.ItemHeight = 30;
            this.cbCat.Items.AddRange(new object[] {
            "Waiter",
            "Cleaner ",
            "Manager",
            "Other "});
            this.cbCat.ItemsAppearance.Parent = this.cbCat;
            this.cbCat.Location = new System.Drawing.Point(50, 298);
            this.cbCat.Name = "cbCat";
            this.cbCat.ShadowDecoration.Parent = this.cbCat;
            this.cbCat.Size = new System.Drawing.Size(254, 36);
            this.cbCat.TabIndex = 1;
            this.cbCat.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cbCat.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(351, 192);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(254, 36);
            this.txtPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(50, 192);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(254, 36);
            this.txtName.TabIndex = 0;
            // 
            // txtImage
            // 
            this.txtImage.Image = global::Restaurant_Management_System.Properties.Resources.brand_identity;
            this.txtImage.Location = new System.Drawing.Point(716, 146);
            this.txtImage.Name = "txtImage";
            this.txtImage.ShadowDecoration.Parent = this.txtImage;
            this.txtImage.Size = new System.Drawing.Size(147, 165);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 12;
            this.txtImage.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoRoundedCorners = true;
            this.btnBrowse.BorderRadius = 21;
            this.btnBrowse.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnBrowse.CheckedState.Parent = this.btnBrowse;
            this.btnBrowse.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBrowse.CustomImages.Parent = this.btnBrowse;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowse.FillColor = System.Drawing.Color.Black;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.HoverState.Parent = this.btnBrowse;
            this.btnBrowse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowse.Location = new System.Drawing.Point(716, 329);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.ShadowDecoration.Parent = this.btnBrowse;
            this.btnBrowse.Size = new System.Drawing.Size(147, 45);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowse.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnBrowse.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // ProductAddfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 465);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Name = "ProductAddfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductAddfrm";
            this.Load += new System.EventHandler(this.ProductAddfrm_Load);
            this.Controls.SetChildIndex(this.guna2Panel1, 0);
            this.Controls.SetChildIndex(this.guna2Panel2, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbCat, 0);
            this.Controls.SetChildIndex(this.txtImage, 0);
            this.Controls.SetChildIndex(this.btnBrowse, 0);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ComboBox cbCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2PictureBox txtImage;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
    }
}