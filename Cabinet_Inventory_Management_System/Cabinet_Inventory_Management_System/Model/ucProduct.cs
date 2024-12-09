using Cabinet_Inventory_Management_System.View;
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
    public partial class ucProduct : UserControl
    {
        public event EventHandler onSelect = null;
        // Define a custom event
        public event Action<int> CardClicked;
        public ucProduct()
        {
            InitializeComponent();
        }

        private void txtPic_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        public int Id { get; set; }
        public string PName
        {
            get { return lblName2.Text; }
            set { lblName2.Text = value; }
        }

        public string Price
        {
            get { return lblPrice2.Text; }
            set { lblPrice2.Text = value; }
        }

        public string PQtyAvailable
        {
            get { return lblQty2.Text; }
            set { lblQty2.Text = value; }
        }

        public string PCode
        {
            get { return lblCode2.Text; }
            set { lblCode2.Text = value; }
        }

        public Image PImage
        {
            get { return txtPic.Image;}
            set { txtPic.Image = value;}    
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            
            
        }

        private void lblQty_Click(object sender, EventArgs e)
        {

        }

        private void lblCode_Click(object sender, EventArgs e)
        {

        }

        private void btnPrdDetailView_Click(object sender, EventArgs e)
        {

            var detailForm = new frmProductDetailView(Id);
             MainClass.BlurBackground(detailForm);

        }

        private void uc_click(object sender, EventArgs e)
        {

            var detailForm = new frmProductDetailView(Id);
            MainClass.BlurBackground(detailForm);
        }
    }
}
