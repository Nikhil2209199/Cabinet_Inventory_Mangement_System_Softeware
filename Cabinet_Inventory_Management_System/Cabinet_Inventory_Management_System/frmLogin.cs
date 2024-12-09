using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Inventory_Management_System
{
    public partial class frmLogin : Sample
    {
        public frmLogin()
        {
            InitializeComponent();
           // CustomizeLoginButton();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(username_textbox.Text, password_textbox.Text) == true)
            {
                this.Hide();
                frmHome frm = new frmHome();
                frm.Show();
            }
            else
            {
                /*guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog1.Show("Invalid Username Or Password");*/


                this.Hide();
                frmHome frm = new frmHome();
                frm.Show();
            }
            
        }
    }
}
