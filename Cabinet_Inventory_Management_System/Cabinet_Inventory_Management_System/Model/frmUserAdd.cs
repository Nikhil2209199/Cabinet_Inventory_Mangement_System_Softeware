using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Inventory_Management_System.Model
{
    public partial class frmUserAdd : Sample
    {
        public frmUserAdd()
        {
            InitializeComponent();
        }

        public virtual void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int id = 0;
        public virtual void btnSave_Click(object sender, EventArgs e)
        {
            if(MainClass.Validation(this) == false)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Please remove errors");
                return;
            }
            else
            {
                string qry = "";
                if(id == 0)//Insert
                {
                    qry = @"INSERT INTO users (uName, uUserName, uPass, uPhone, uImage) VALUES (@name, @username, @pass, @phone, @image)";
                }
                else//Update
                {
                    qry = @"UPDATE users set uName =@name,
                                            uUserName = @username,
                                            uPass = @pass,
                                            uPhone = @phone,
                                            uImage = @image
                                            where userId = @id";
                }

                Image temp = new Bitmap(txtPic.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", txtName.Text);
                ht.Add("@username", txtPrdCode.Text);
                ht.Add("@pass", txtPass.Text);
                ht.Add("@phone", txtPrdPrice.Text);
                ht.Add("@image", imageByteArray);

                if(MainClass.SQl(qry, ht)>0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Show("Data Saved Successfully");
                    id = 0;
                    txtName.Text = "";
                    txtPrdCode.Text = "";
                    txtPass.Text = "";
                    txtPrdPrice.Text = "";
                    txtPic.Image = Cabinet_Inventory_Management_System.Properties.Resources.userpic;
                    txtName.Focus();
                }
            }
        }

        public string filepath = "";
        Byte[] imageByteArray;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                txtPic.Image = new Bitmap(filepath);
            }
        }

        private void LoadImage()
        {
            string qry = @"Select * from users where userId = " + id + "";
            SqlCommand sqlCommand = new SqlCommand(qry,MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand); 
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                Byte[] imageArray = (byte[])dt.Rows[0]["uImage"];
                byte[] imageByteArray = imageArray;
                txtPic.Image = Image.FromStream(new  MemoryStream(imageArray));
            }
        }

        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            if(id>0)
            {
                LoadImage();
            }
        }
    }
}
