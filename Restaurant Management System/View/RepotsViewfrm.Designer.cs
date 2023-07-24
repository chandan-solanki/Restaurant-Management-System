namespace Restaurant_Management_System.View
{
    partial class RepotsViewfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaleCat = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reports";
            // 
            // btnMenu
            // 
            this.btnMenu.BorderRadius = 5;
            this.btnMenu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnMenu.CheckedState.Parent = this.btnMenu;
            this.btnMenu.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMenu.CustomImages.Parent = this.btnMenu;
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.HoverState.Parent = this.btnMenu;
            this.btnMenu.Image = global::Restaurant_Management_System.Properties.Resources.pie_chart;
            this.btnMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.ImageOffset = new System.Drawing.Point(8, 0);
            this.btnMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMenu.Location = new System.Drawing.Point(84, 156);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.ShadowDecoration.Parent = this.btnMenu;
            this.btnMenu.Size = new System.Drawing.Size(230, 106);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu List";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMenu.TextOffset = new System.Drawing.Point(6, 0);
            this.btnMenu.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnMenu.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BorderRadius = 5;
            this.btnStaff.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnStaff.CheckedState.Parent = this.btnStaff;
            this.btnStaff.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnStaff.CustomImages.Parent = this.btnStaff;
            this.btnStaff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.HoverState.Parent = this.btnStaff;
            this.btnStaff.Image = global::Restaurant_Management_System.Properties.Resources.pie_chart;
            this.btnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.ImageOffset = new System.Drawing.Point(8, 0);
            this.btnStaff.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStaff.Location = new System.Drawing.Point(337, 156);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.ShadowDecoration.Parent = this.btnStaff;
            this.btnStaff.Size = new System.Drawing.Size(230, 106);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Staff List";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStaff.TextOffset = new System.Drawing.Point(6, 0);
            this.btnStaff.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnStaff.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnSaleCat
            // 
            this.btnSaleCat.BorderRadius = 5;
            this.btnSaleCat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnSaleCat.CheckedState.Parent = this.btnSaleCat;
            this.btnSaleCat.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSaleCat.CustomImages.Parent = this.btnSaleCat;
            this.btnSaleCat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaleCat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnSaleCat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleCat.ForeColor = System.Drawing.Color.White;
            this.btnSaleCat.HoverState.Parent = this.btnSaleCat;
            this.btnSaleCat.Image = global::Restaurant_Management_System.Properties.Resources.pie_chart;
            this.btnSaleCat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaleCat.ImageOffset = new System.Drawing.Point(8, 0);
            this.btnSaleCat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaleCat.Location = new System.Drawing.Point(584, 156);
            this.btnSaleCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaleCat.Name = "btnSaleCat";
            this.btnSaleCat.ShadowDecoration.Parent = this.btnSaleCat;
            this.btnSaleCat.Size = new System.Drawing.Size(230, 106);
            this.btnSaleCat.TabIndex = 3;
            this.btnSaleCat.Text = "Sale By Category";
            this.btnSaleCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaleCat.TextOffset = new System.Drawing.Point(14, 0);
            this.btnSaleCat.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSaleCat.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnSaleCat.Click += new System.EventHandler(this.btnSaleCat_Click);
            // 
            // RepotsViewfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 547);
            this.Controls.Add(this.btnSaleCat);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RepotsViewfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepotsViewfrm";
            this.Load += new System.EventHandler(this.RepotsViewfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Button btnSaleCat;
    }
}