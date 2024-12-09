using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cabinet_Inventory_Management_System.View;

namespace Cabinet_Inventory_Management_System
{
    public partial class frmHome : Sample
    {
        static frmHome _obj;
        public static frmHome Instance
        {
            get
            { 
                if(_obj == null)
                    {
                        _obj = new frmHome();
                    }
                return _obj;
            }
        }

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            _obj = this;
            btnMaximize.PerformClick();

            lblUserName.Text = MainClass.USER;
            guna2CirclePictureBox1.Image = MainClass.img;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AddControls(Form F)
        {
            this.CenterPanel.Controls.Clear();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            CenterPanel.Controls.Add( F );
            F.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
           
        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AddControls(new frmUserView());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AddControls(new frmProductView());
        }
    }
}
