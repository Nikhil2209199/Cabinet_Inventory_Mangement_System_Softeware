namespace Cabinet_Inventory_Management_System.View
{
    partial class frmProductView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClearFilter = new Guna.UI2.WinForms.Guna2Button();
            this.lblRecordValue = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSubCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbVarieties = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 134);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1320, 620);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.AutoSizeChanged += new System.EventHandler(this.frmProductView_Load);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.btnClearFilter);
            this.guna2Panel1.Controls.Add(this.lblRecordValue);
            this.guna2Panel1.Controls.Add(this.lblRecordsCount);
            this.guna2Panel1.Controls.Add(this.cmbCategory);
            this.guna2Panel1.Controls.Add(this.cmbSubCategory);
            this.guna2Panel1.Controls.Add(this.cmbVarieties);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(7, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1330, 106);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Animated = true;
            this.btnClearFilter.AutoRoundedCorners = true;
            this.btnClearFilter.BorderRadius = 19;
            this.btnClearFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.filter;
            this.btnClearFilter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClearFilter.Location = new System.Drawing.Point(1161, 39);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(151, 41);
            this.btnClearFilter.TabIndex = 18;
            this.btnClearFilter.Text = "Clear All Filters";
            this.btnClearFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // lblRecordValue
            // 
            this.lblRecordValue.AutoSize = true;
            this.lblRecordValue.Location = new System.Drawing.Point(298, 51);
            this.lblRecordValue.Name = "lblRecordValue";
            this.lblRecordValue.Size = new System.Drawing.Size(19, 23);
            this.lblRecordValue.TabIndex = 17;
            this.lblRecordValue.Text = "0";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Location = new System.Drawing.Point(196, 48);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(104, 23);
            this.lblRecordsCount.TabIndex = 16;
            this.lblRecordsCount.Text = "Records    :";
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoRoundedCorners = true;
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BorderRadius = 17;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(214)))));
            this.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(214)))));
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(214)))));
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.Location = new System.Drawing.Point(372, 46);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(201, 36);
            this.cmbCategory.TabIndex = 15;
            this.cmbCategory.Tag = "v";
            // 
            // cmbSubCategory
            // 
            this.cmbSubCategory.AutoRoundedCorners = true;
            this.cmbSubCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbSubCategory.BorderRadius = 17;
            this.cmbSubCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(214)))));
            this.cmbSubCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(214)))));
            this.cmbSubCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSubCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbSubCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(214)))));
            this.cmbSubCategory.ItemHeight = 30;
            this.cmbSubCategory.Location = new System.Drawing.Point(651, 46);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(201, 36);
            this.cmbSubCategory.TabIndex = 14;
            this.cmbSubCategory.Tag = "v";
            // 
            // cmbVarieties
            // 
            this.cmbVarieties.AutoRoundedCorners = true;
            this.cmbVarieties.BackColor = System.Drawing.Color.Transparent;
            this.cmbVarieties.BorderRadius = 17;
            this.cmbVarieties.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVarieties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVarieties.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(214)))));
            this.cmbVarieties.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(214)))));
            this.cmbVarieties.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbVarieties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbVarieties.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(214)))));
            this.cmbVarieties.ItemHeight = 30;
            this.cmbVarieties.Location = new System.Drawing.Point(929, 46);
            this.cmbVarieties.Name = "cmbVarieties";
            this.cmbVarieties.Size = new System.Drawing.Size(201, 36);
            this.cmbVarieties.TabIndex = 13;
            this.cmbVarieties.Tag = "v";
            this.cmbVarieties.SelectedValueChanged += new System.EventHandler(this.cmbVarieties_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(943, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search By varieties";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search By Subcategory";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search By Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 19;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.add_new;
            this.btnAdd.Location = new System.Drawing.Point(32, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add New";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Products";
            // 
            // frmProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 783);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmProductView";
            this.Text = "Product View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProductView_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2Button btnAdd;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbVarieties;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSubCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private System.Windows.Forms.Label lblRecordValue;
        private System.Windows.Forms.Label lblRecordsCount;
        public Guna.UI2.WinForms.Guna2Button btnClearFilter;
    }
}
