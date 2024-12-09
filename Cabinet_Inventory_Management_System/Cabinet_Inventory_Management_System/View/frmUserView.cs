//using Cabinet_Inventory_Management_System.Model;
using Cabinet_Inventory_Management_System.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Inventory_Management_System.View
{
    public partial class frmUserView : SampleView
    {
        public frmUserView()
        {
            InitializeComponent();
        }

        private void frmUserView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmUserAdd());
            LoadData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvId);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvUserName);
            lb.Items.Add(dgvPass);
            lb.Items.Add(dgvPhone);

            string qry = @"select userId,uName,uUserName,uPass,uPhone from users
where uName like '%"+txtSearch.Text+"%' order by userId desc";

            
            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmUserAdd frm =new frmUserAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvId"].Value);
                frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.txtPrdCode.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvUserName"].Value);
                frm.txtPass.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPass"].Value);
                frm.txtPrdPrice.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPhone"].Value);

                MainClass.BlurBackground(frm);
                LoadData();
            }

            //Delete
            if(guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDelete")
            {
                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvId"].Value);
                string qry = @"Delete from users where userId = " + id + "";
                Hashtable ht = new Hashtable();
                if(MainClass.SQl(qry, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Show("Deleted Successfully.....");
                    LoadData();
                }

            }
        }
    }
}
