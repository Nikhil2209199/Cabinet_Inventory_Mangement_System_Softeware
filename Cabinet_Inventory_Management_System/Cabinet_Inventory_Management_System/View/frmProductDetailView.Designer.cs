namespace Cabinet_Inventory_Management_System.View
{
    partial class frmProductDetailView
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
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtGST = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGST = new System.Windows.Forms.Label();
            this.txtSize = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtShape = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblShape = new System.Windows.Forms.Label();
            this.cmbVarieties = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSubCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtSellPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.txtPrdPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrdPrice = new System.Windows.Forms.Label();
            this.txtQtyAvail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQtyAvail = new System.Windows.Forms.Label();
            this.txtPrdCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrdCode = new System.Windows.Forms.Label();
            this.txtPrdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrdName = new System.Windows.Forms.Label();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.lblVarieties = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = " Product Detail View";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1065, 100);
            this.guna2Panel2.TabIndex = 16;
            // 
            // txtPic
            // 
            this.txtPic.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.product_image_icon_png;
            this.txtPic.ImageRotate = 0F;
            this.txtPic.Location = new System.Drawing.Point(807, 204);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(225, 211);
            this.txtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtPic.TabIndex = 41;
            this.txtPic.TabStop = false;
            // 
            // txtGST
            // 
            this.txtGST.AutoRoundedCorners = true;
            this.txtGST.BorderRadius = 15;
            this.txtGST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGST.DefaultText = "";
            this.txtGST.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGST.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGST.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGST.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGST.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtGST.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGST.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtGST.Location = new System.Drawing.Point(57, 527);
            this.txtGST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGST.Name = "txtGST";
            this.txtGST.PasswordChar = '\0';
            this.txtGST.PlaceholderText = "";
            this.txtGST.SelectedText = "";
            this.txtGST.Size = new System.Drawing.Size(203, 32);
            this.txtGST.TabIndex = 38;
            this.txtGST.Tag = "";
            this.txtGST.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblGST
            // 
            this.lblGST.Location = new System.Drawing.Point(72, 500);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(132, 23);
            this.lblGST.TabIndex = 37;
            this.lblGST.Text = "GST";
            // 
            // txtSize
            // 
            this.txtSize.AutoRoundedCorners = true;
            this.txtSize.BorderRadius = 15;
            this.txtSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSize.DefaultText = "";
            this.txtSize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtSize.Location = new System.Drawing.Point(528, 433);
            this.txtSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.PlaceholderText = "";
            this.txtSize.SelectedText = "";
            this.txtSize.Size = new System.Drawing.Size(203, 32);
            this.txtSize.TabIndex = 35;
            this.txtSize.Tag = "";
            this.txtSize.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblSize
            // 
            this.lblSize.Location = new System.Drawing.Point(543, 406);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(132, 23);
            this.lblSize.TabIndex = 36;
            this.lblSize.Text = "Size";
            // 
            // txtShape
            // 
            this.txtShape.AutoRoundedCorners = true;
            this.txtShape.BorderRadius = 15;
            this.txtShape.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShape.DefaultText = "";
            this.txtShape.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtShape.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtShape.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShape.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShape.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtShape.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtShape.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtShape.Location = new System.Drawing.Point(287, 433);
            this.txtShape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShape.Name = "txtShape";
            this.txtShape.PasswordChar = '\0';
            this.txtShape.PlaceholderText = "";
            this.txtShape.SelectedText = "";
            this.txtShape.Size = new System.Drawing.Size(203, 32);
            this.txtShape.TabIndex = 33;
            this.txtShape.Tag = "";
            this.txtShape.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblShape
            // 
            this.lblShape.Location = new System.Drawing.Point(302, 406);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(132, 23);
            this.lblShape.TabIndex = 34;
            this.lblShape.Text = "Shape";
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
            this.cmbVarieties.Location = new System.Drawing.Point(57, 434);
            this.cmbVarieties.Name = "cmbVarieties";
            this.cmbVarieties.Size = new System.Drawing.Size(201, 36);
            this.cmbVarieties.TabIndex = 32;
            this.cmbVarieties.Tag = "v";
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
            this.cmbSubCategory.Location = new System.Drawing.Point(530, 347);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(201, 36);
            this.cmbSubCategory.TabIndex = 30;
            this.cmbSubCategory.Tag = "v";
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.Location = new System.Drawing.Point(545, 324);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(134, 23);
            this.lblSubCategory.TabIndex = 31;
            this.lblSubCategory.Text = "Sub Category";
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
            this.cmbCategory.Location = new System.Drawing.Point(289, 347);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(201, 36);
            this.cmbCategory.TabIndex = 28;
            this.cmbCategory.Tag = "v";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(540, 168);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(246, 125);
            this.txtDescription.TabIndex = 21;
            this.txtDescription.Text = "";
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(304, 324);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(134, 23);
            this.lblCategory.TabIndex = 29;
            this.lblCategory.Text = "Category";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.AutoRoundedCorners = true;
            this.txtSellPrice.BorderRadius = 15;
            this.txtSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellPrice.DefaultText = "";
            this.txtSellPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSellPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSellPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtSellPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSellPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtSellPrice.Location = new System.Drawing.Point(63, 351);
            this.txtSellPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.PasswordChar = '\0';
            this.txtSellPrice.PlaceholderText = "";
            this.txtSellPrice.SelectedText = "";
            this.txtSellPrice.Size = new System.Drawing.Size(201, 32);
            this.txtSellPrice.TabIndex = 27;
            this.txtSellPrice.Tag = "v";
            this.txtSellPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.Location = new System.Drawing.Point(78, 324);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(134, 23);
            this.lblSellPrice.TabIndex = 26;
            this.lblSellPrice.Text = "Selling Price";
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
            this.txtPrdPrice.Location = new System.Drawing.Point(287, 261);
            this.txtPrdPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrdPrice.Name = "txtPrdPrice";
            this.txtPrdPrice.PasswordChar = '\0';
            this.txtPrdPrice.PlaceholderText = "";
            this.txtPrdPrice.SelectedText = "";
            this.txtPrdPrice.Size = new System.Drawing.Size(201, 32);
            this.txtPrdPrice.TabIndex = 25;
            this.txtPrdPrice.Tag = "v";
            this.txtPrdPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblPrdPrice
            // 
            this.lblPrdPrice.Location = new System.Drawing.Point(302, 234);
            this.lblPrdPrice.Name = "lblPrdPrice";
            this.lblPrdPrice.Size = new System.Drawing.Size(167, 23);
            this.lblPrdPrice.TabIndex = 24;
            this.lblPrdPrice.Text = "Product Cost Price";
            // 
            // txtQtyAvail
            // 
            this.txtQtyAvail.AutoRoundedCorners = true;
            this.txtQtyAvail.BorderRadius = 15;
            this.txtQtyAvail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQtyAvail.DefaultText = "";
            this.txtQtyAvail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQtyAvail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQtyAvail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQtyAvail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQtyAvail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtQtyAvail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQtyAvail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtQtyAvail.Location = new System.Drawing.Point(63, 261);
            this.txtQtyAvail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQtyAvail.Name = "txtQtyAvail";
            this.txtQtyAvail.PasswordChar = '\0';
            this.txtQtyAvail.PlaceholderText = "";
            this.txtQtyAvail.SelectedText = "";
            this.txtQtyAvail.Size = new System.Drawing.Size(203, 32);
            this.txtQtyAvail.TabIndex = 23;
            this.txtQtyAvail.Tag = "v";
            this.txtQtyAvail.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblQtyAvail
            // 
            this.lblQtyAvail.Location = new System.Drawing.Point(61, 234);
            this.lblQtyAvail.Name = "lblQtyAvail";
            this.lblQtyAvail.Size = new System.Drawing.Size(220, 43);
            this.lblQtyAvail.TabIndex = 22;
            this.lblQtyAvail.Tag = "v";
            this.lblQtyAvail.Text = "Quantity available in stock";
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
            this.txtPrdCode.Location = new System.Drawing.Point(287, 170);
            this.txtPrdCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrdCode.Name = "txtPrdCode";
            this.txtPrdCode.PasswordChar = '\0';
            this.txtPrdCode.PlaceholderText = "";
            this.txtPrdCode.SelectedText = "";
            this.txtPrdCode.Size = new System.Drawing.Size(201, 32);
            this.txtPrdCode.TabIndex = 20;
            this.txtPrdCode.Tag = "v";
            this.txtPrdCode.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblPrdCode
            // 
            this.lblPrdCode.Location = new System.Drawing.Point(302, 143);
            this.lblPrdCode.Name = "lblPrdCode";
            this.lblPrdCode.Size = new System.Drawing.Size(123, 23);
            this.lblPrdCode.TabIndex = 19;
            this.lblPrdCode.Text = "Product Code";
            // 
            // txtPrdName
            // 
            this.txtPrdName.AutoRoundedCorners = true;
            this.txtPrdName.BorderRadius = 15;
            this.txtPrdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrdName.DefaultText = "";
            this.txtPrdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtPrdName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.txtPrdName.Location = new System.Drawing.Point(59, 170);
            this.txtPrdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrdName.Name = "txtPrdName";
            this.txtPrdName.PasswordChar = '\0';
            this.txtPrdName.PlaceholderText = "";
            this.txtPrdName.SelectedText = "";
            this.txtPrdName.Size = new System.Drawing.Size(203, 32);
            this.txtPrdName.TabIndex = 18;
            this.txtPrdName.Tag = "v";
            this.txtPrdName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblPrdName
            // 
            this.lblPrdName.Location = new System.Drawing.Point(74, 143);
            this.lblPrdName.Name = "lblPrdName";
            this.lblPrdName.Size = new System.Drawing.Size(132, 23);
            this.lblPrdName.TabIndex = 17;
            this.lblPrdName.Text = "Product Name";
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
            this.btnBrowse.Location = new System.Drawing.Point(861, 431);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(110, 41);
            this.btnBrowse.TabIndex = 39;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.BorderRadius = 21;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(64, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.btnClose);
            this.guna2Panel3.Controls.Add(this.btnDelete);
            this.guna2Panel3.Controls.Add(this.btnUpdate);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 595);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1065, 100);
            this.guna2Panel3.TabIndex = 40;
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.BorderRadius = 21;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(189, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 45);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblVarieties
            // 
            this.lblVarieties.Location = new System.Drawing.Point(74, 405);
            this.lblVarieties.Name = "lblVarieties";
            this.lblVarieties.Size = new System.Drawing.Size(134, 23);
            this.lblVarieties.TabIndex = 43;
            this.lblVarieties.Text = "Varieties";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(543, 137);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(167, 23);
            this.lblDescription.TabIndex = 42;
            this.lblDescription.Text = "Product Description";
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
            this.btnClose.Location = new System.Drawing.Point(896, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmProductDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 695);
            this.Controls.Add(this.lblVarieties);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.txtGST);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtShape);
            this.Controls.Add(this.lblShape);
            this.Controls.Add(this.cmbVarieties);
            this.Controls.Add(this.cmbSubCategory);
            this.Controls.Add(this.lblSubCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.txtPrdPrice);
            this.Controls.Add(this.lblPrdPrice);
            this.Controls.Add(this.txtQtyAvail);
            this.Controls.Add(this.lblQtyAvail);
            this.Controls.Add(this.txtPrdCode);
            this.Controls.Add(this.lblPrdCode);
            this.Controls.Add(this.txtPrdName);
            this.Controls.Add(this.lblPrdName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.guna2Panel3);
            this.Name = "frmProductDetailView";
            this.Text = "frmProductDetailView";
            this.Load += new System.EventHandler(this.frmProductDetailView_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox txtPic;
        public Guna.UI2.WinForms.Guna2TextBox txtGST;
        private System.Windows.Forms.Label lblGST;
        public Guna.UI2.WinForms.Guna2TextBox txtSize;
        private System.Windows.Forms.Label lblSize;
        public Guna.UI2.WinForms.Guna2TextBox txtShape;
        private System.Windows.Forms.Label lblShape;
        private Guna.UI2.WinForms.Guna2ComboBox cmbVarieties;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSubCategory;
        private System.Windows.Forms.Label lblSubCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblCategory;
        public Guna.UI2.WinForms.Guna2TextBox txtSellPrice;
        private System.Windows.Forms.Label lblSellPrice;
        public Guna.UI2.WinForms.Guna2TextBox txtPrdPrice;
        private System.Windows.Forms.Label lblPrdPrice;
        public Guna.UI2.WinForms.Guna2TextBox txtQtyAvail;
        private System.Windows.Forms.Label lblQtyAvail;
        public Guna.UI2.WinForms.Guna2TextBox txtPrdCode;
        private System.Windows.Forms.Label lblPrdCode;
        public Guna.UI2.WinForms.Guna2TextBox txtPrdName;
        private System.Windows.Forms.Label lblPrdName;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label lblVarieties;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}