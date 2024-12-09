namespace Cabinet_Inventory_Management_System
{
    partial class frmHome
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
            this.btnMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnSales = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrders = new Guna.UI2.WinForms.Guna2Button();
            this.btnBilling = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchase = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.CenterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMaximize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1022, 9);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 29);
            this.btnMaximize.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(970, 9);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 29);
            this.btnMinimize.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.CustomClick = true;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1072, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnMaximize);
            this.guna2Panel1.Controls.Add(this.btnMinimize);
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1124, 48);
            this.guna2Panel1.TabIndex = 3;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 60;
            this.guna2Panel3.Controls.Add(this.btnUsers);
            this.guna2Panel3.Controls.Add(this.lblUserName);
            this.guna2Panel3.Controls.Add(this.btnReports);
            this.guna2Panel3.Controls.Add(this.btnSales);
            this.guna2Panel3.Controls.Add(this.btnOrders);
            this.guna2Panel3.Controls.Add(this.btnBilling);
            this.guna2Panel3.Controls.Add(this.btnCustomers);
            this.guna2Panel3.Controls.Add(this.btnProducts);
            this.guna2Panel3.Controls.Add(this.btnPurchase);
            this.guna2Panel3.Controls.Add(this.btnHome);
            this.guna2Panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel3.CustomizableEdges.BottomLeft = false;
            this.guna2Panel3.CustomizableEdges.BottomRight = false;
            this.guna2Panel3.CustomizableEdges.TopLeft = false;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 48);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(218, 824);
            this.guna2Panel3.TabIndex = 4;
            // 
            // btnUsers
            // 
            this.btnUsers.Animated = true;
            this.btnUsers.AutoRoundedCorners = true;
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnUsers.BorderRadius = 18;
            this.btnUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.userpic;
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(22, 22);
            this.btnUsers.Location = new System.Drawing.Point(20, 759);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(168, 38);
            this.btnUsers.TabIndex = 11;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.TextOffset = new System.Drawing.Point(22, 0);
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(15, 165);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(184, 32);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "UserName";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReports
            // 
            this.btnReports.Animated = true;
            this.btnReports.AutoRoundedCorners = true;
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnReports.BorderRadius = 18;
            this.btnReports.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.rep_removebg_preview;
            this.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.ImageSize = new System.Drawing.Size(22, 22);
            this.btnReports.Location = new System.Drawing.Point(20, 697);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(168, 38);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // btnSales
            // 
            this.btnSales.Animated = true;
            this.btnSales.AutoRoundedCorners = true;
            this.btnSales.BackColor = System.Drawing.Color.Transparent;
            this.btnSales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnSales.BorderRadius = 18;
            this.btnSales.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.btnSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.sell_removebg_preview;
            this.btnSales.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSales.ImageSize = new System.Drawing.Size(22, 20);
            this.btnSales.Location = new System.Drawing.Point(23, 632);
            this.btnSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(168, 38);
            this.btnSales.TabIndex = 8;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSales.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // btnOrders
            // 
            this.btnOrders.Animated = true;
            this.btnOrders.AutoRoundedCorners = true;
            this.btnOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrders.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnOrders.BorderRadius = 18;
            this.btnOrders.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.btnOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.order_removebg_preview;
            this.btnOrders.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrders.ImageSize = new System.Drawing.Size(19, 20);
            this.btnOrders.Location = new System.Drawing.Point(23, 567);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(168, 38);
            this.btnOrders.TabIndex = 7;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrders.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // btnBilling
            // 
            this.btnBilling.Animated = true;
            this.btnBilling.AutoRoundedCorners = true;
            this.btnBilling.BackColor = System.Drawing.Color.Transparent;
            this.btnBilling.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnBilling.BorderRadius = 18;
            this.btnBilling.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.btnBilling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBilling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBilling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBilling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBilling.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnBilling.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBilling.ForeColor = System.Drawing.Color.White;
            this.btnBilling.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.bill_removebg_preview;
            this.btnBilling.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBilling.ImageSize = new System.Drawing.Size(18, 16);
            this.btnBilling.Location = new System.Drawing.Point(19, 502);
            this.btnBilling.Margin = new System.Windows.Forms.Padding(2);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(168, 38);
            this.btnBilling.TabIndex = 6;
            this.btnBilling.Text = "BIlling";
            this.btnBilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBilling.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Animated = true;
            this.btnCustomers.AutoRoundedCorners = true;
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnCustomers.BorderRadius = 18;
            this.btnCustomers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.customers_removebg_preview;
            this.btnCustomers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCustomers.Location = new System.Drawing.Point(20, 316);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(168, 38);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.TextOffset = new System.Drawing.Point(22, 0);
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Animated = true;
            this.btnProducts.AutoRoundedCorners = true;
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnProducts.BorderRadius = 18;
            this.btnProducts.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.btnProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProducts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.product_removebg_preview;
            this.btnProducts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProducts.ImageSize = new System.Drawing.Size(19, 16);
            this.btnProducts.Location = new System.Drawing.Point(20, 378);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(168, 38);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProducts.TextOffset = new System.Drawing.Point(22, 0);
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Animated = true;
            this.btnPurchase.AutoRoundedCorners = true;
            this.btnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnPurchase.BorderRadius = 18;
            this.btnPurchase.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.btnPurchase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.png_transparent_black_and_white_point_angle_pattern_shopping_cart_texture_angle_white_thumbnail_removebg_preview;
            this.btnPurchase.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPurchase.ImageSize = new System.Drawing.Size(20, 16);
            this.btnPurchase.Location = new System.Drawing.Point(20, 438);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(168, 38);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "Purchases";
            this.btnPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPurchase.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.AutoRoundedCorners = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnHome.BorderRadius = 18;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Cabinet_Inventory_Management_System.Properties.Resources.home2_removebg_preview;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageSize = new System.Drawing.Size(22, 17);
            this.btnHome.Location = new System.Drawing.Point(23, 254);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(168, 38);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(48, 41);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(119, 113);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterPanel.AutoScroll = true;
            this.CenterPanel.Location = new System.Drawing.Point(222, 52);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(893, 809);
            this.CenterPanel.TabIndex = 5;
            this.CenterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CenterPanel_Paint);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1124, 872);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btnMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnOrders;
        private Guna.UI2.WinForms.Guna2Button btnBilling;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnProducts;
        private Guna.UI2.WinForms.Guna2Button btnPurchase;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnSales;
        private Guna.UI2.WinForms.Guna2Panel CenterPanel;
        private System.Windows.Forms.Label lblUserName;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
    }
}

