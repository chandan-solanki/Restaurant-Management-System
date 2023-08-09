namespace Restaurant_Management_System.View
{
    partial class SettingViewfrm
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
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Settings";
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
            this.btnStaff.Image = global::Restaurant_Management_System.Properties.Resources.padlock;
            this.btnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.ImageOffset = new System.Drawing.Point(4, -5);
            this.btnStaff.ImageSize = new System.Drawing.Size(40, 40);
            this.btnStaff.Location = new System.Drawing.Point(339, 171);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.ShadowDecoration.Parent = this.btnStaff;
            this.btnStaff.Size = new System.Drawing.Size(230, 106);
            this.btnStaff.TabIndex = 6;
            this.btnStaff.Text = "   Change Password";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStaff.TextOffset = new System.Drawing.Point(6, 0);
            this.btnStaff.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnStaff.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
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
            this.btnMenu.Image = global::Restaurant_Management_System.Properties.Resources.logout;
            this.btnMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.ImageOffset = new System.Drawing.Point(8, 0);
            this.btnMenu.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.Location = new System.Drawing.Point(86, 171);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.ShadowDecoration.Parent = this.btnMenu;
            this.btnMenu.Size = new System.Drawing.Size(230, 106);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Log Out";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMenu.TextOffset = new System.Drawing.Point(6, 0);
            this.btnMenu.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnMenu.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // SettingViewfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 561);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingViewfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingViewfrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
    }
}