using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Inventory_Management_System.Model
{
    partial class frmUserAdd
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrdCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPrdPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 100);
            this.guna2Panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Details";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnClose);
            this.guna2Panel2.Controls.Add(this.btnSave);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 350);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(800, 100);
            this.guna2Panel2.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.BorderRadius = 21;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(166, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.BorderRadius = 21;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(64, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(79, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 23);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.AutoRoundedCorners = true;
            this.txtName.BorderRadius = 15;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtName.Location = new System.Drawing.Point(64, 149);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(203, 32);
            this.txtName.TabIndex = 0;
            this.txtName.Tag = "v";
            this.txtName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtPrdCode
            // 
            this.txtPrdCode.AutoRoundedCorners = true;
            this.txtPrdCode.BorderRadius = 15;
            this.txtPrdCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrdCode.DefaultText = "";
            this.txtPrdCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrdCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrdCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrdCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrdCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtPrdCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrdCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtPrdCode.Location = new System.Drawing.Point(292, 149);
            this.txtPrdCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrdCode.Name = "txtPrdCode";
            this.txtPrdCode.PasswordChar = '\0';
            this.txtPrdCode.PlaceholderText = "";
            this.txtPrdCode.SelectedText = "";
            this.txtPrdCode.Size = new System.Drawing.Size(201, 32);
            this.txtPrdCode.TabIndex = 1;
            this.txtPrdCode.Tag = "v";
            this.txtPrdCode.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(307, 122);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(123, 23);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Username";
            // 
            // txtPass
            // 
            this.txtPass.AutoRoundedCorners = true;
            this.txtPass.BorderRadius = 15;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtPass.Location = new System.Drawing.Point(64, 227);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(203, 32);
            this.txtPass.TabIndex = 2;
            this.txtPass.Tag = "v";
            this.txtPass.TextOffset = new System.Drawing.Point(10, 0);
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.Location = new System.Drawing.Point(60, 200);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(220, 43);
            this.lblPass.TabIndex = 8;
            this.lblPass.Text = "Password";
            // 
            // txtPrdPrice
            // 
            this.txtPrdPrice.AutoRoundedCorners = true;
            this.txtPrdPrice.BorderRadius = 15;
            this.txtPrdPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrdPrice.DefaultText = "";
            this.txtPrdPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrdPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrdPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrdPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrdPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtPrdPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrdPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtPrdPrice.Location = new System.Drawing.Point(292, 227);
            this.txtPrdPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrdPrice.Name = "txtPrdPrice";
            this.txtPrdPrice.PasswordChar = '\0';
            this.txtPrdPrice.PlaceholderText = "";
            this.txtPrdPrice.SelectedText = "";
            this.txtPrdPrice.Size = new System.Drawing.Size(201, 32);
            this.txtPrdPrice.TabIndex = 3;
            this.txtPrdPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(307, 200);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(134, 23);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // txtPic
            // 
            this.txtPic.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.userpic;
            this.txtPic.ImageRotate = 0F;
            this.txtPic.Location = new System.Drawing.Point(597, 122);
            this.txtPic.Name = "txtPic";
            this.txtPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.txtPic.Size = new System.Drawing.Size(122, 121);
            this.txtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtPic.TabIndex = 10;
            this.txtPic.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoRoundedCorners = true;
            this.btnBrowse.BorderRadius = 19;
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(611, 259);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 41);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // frmUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.txtPrdPrice);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPrdCode);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmUserAdd";
            this.Text = "frmUserAdd";
            this.Load += new System.EventHandler(this.frmUserAdd_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Label lblName;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        public Guna.UI2.WinForms.Guna2TextBox txtPrdCode;
        private Label lblUserName;
        public Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Label lblPass;
        public Guna.UI2.WinForms.Guna2TextBox txtPrdPrice;
        private Label lblPhone;
        private Guna.UI2.WinForms.Guna2CirclePictureBox txtPic;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
    }
}