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
using System.Xml.Linq;

namespace Cabinet_Inventory_Management_System.Model
{
    public partial class frmProductAdd : Sample
    {
        private int productId;
        public frmProductAdd()
        {
            InitializeComponent();
        }

        public frmProductAdd(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            LoadDataOfProductByPrdId(productId);
        }

        private void LoadDataOfProductByPrdId(int productId)
        {
            string qry = @"SELECT * FROM Products WHERE prdId = @productId";

            using (SqlConnection conn = new SqlConnection(MainClass.con.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(qry, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            dr.Read();
                            // Assuming your textboxes are named appropriately
                            txtPrdName.Text = dr["prdName"].ToString();
                            txtPrdCode.Text = dr["prdCode"].ToString();
                            txtDescription.Text = dr["prdDescription"].ToString();
                            txtPrdPrice.Text = dr["prdCostPrice"].ToString();
                            txtSellPrice.Text = dr["prdSellingPrice"].ToString();
                            txtQtyAvail.Text = dr["prdAvailableQty"].ToString();
                            txtShape.Text = dr["prdShape"].ToString();
                            txtSize.Text = dr["prdSize"].ToString();
                            txtGST.Text = dr["prdGst"].ToString();

                            if (dr["prdImage"] != DBNull.Value)
                            {
                                byte[] imageArray = (byte[])dr["prdImage"];
                                txtPic.Image = Image.FromStream(new MemoryStream(imageArray));
                            }

                            if (dr["categoryId"] != DBNull.Value)
                                cmbCategory.SelectedValue = Convert.ToInt32(dr["categoryId"]);

                            if (dr["subCatId"] != DBNull.Value)
                                cmbSubCategory.SelectedValue = Convert.ToInt32(dr["subCatId"]);

                            if (dr["varietiesId"] != DBNull.Value)
                                cmbVarieties.SelectedValue = Convert.ToInt32(dr["varietiesId"]);
                        }
                        else
                        {
                            MessageBox.Show("No product found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public int id = 0;
        public int catId = 0;
        public int subCatId = 0;
        public int varId = 0;

        private async void frmProductAdd_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                LoadImage();
            }

            // Load Categories asynchronously
            string qry = @"SELECT catId AS 'id', catName AS 'name' FROM Category";
            await MainClass.CBFillAsync(qry, cmbCategory);

            // Add event handlers for dynamic loading
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            cmbSubCategory.SelectedIndexChanged += cmbSubCategory_SelectedIndexChanged;

            // Pre-select values if id > 0
            if (id > 0)
            {
                cmbCategory.SelectedValue = catId;
                cmbCategory_SelectedIndexChanged(null, null); // Manually trigger subcategory loading

                if (subCatId > 0)
                {
                    cmbSubCategory.SelectedValue = subCatId;
                    cmbSubCategory_SelectedIndexChanged(null, null); // Manually trigger variety loading

                    if (varId > 0)
                    {
                        cmbVarieties.SelectedValue = varId;
                    }
                }
            }
        }


        // Event Handler: Load SubCategories when Category is selected
        private async void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue != null)
            {
                if (int.TryParse(cmbCategory.SelectedValue.ToString(), out int selectedCatId))
                {
                    string qry = @"SELECT subCatId AS 'id', subCatName AS 'name' 
                           FROM SubCategory 
                           WHERE catId = @catId";

                    await MainClass.CBFillAsync(qry, cmbSubCategory, new Dictionary<string, object>
            {
                { "@catId", selectedCatId }
            });

                    // Clear the Varieties ComboBox
                    cmbVarieties.DataSource = null;
                }
                else
                {
                    Console.WriteLine("Invalid SelectedValue for Category.");
                }
            }
        }



        // Event Handler: Load Varieties when SubCategory is selected
        private async void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubCategory.SelectedValue != null && cmbCategory.SelectedValue != null)
            {
                if (int.TryParse(cmbCategory.SelectedValue.ToString(), out int selectedCatId) &&
                    int.TryParse(cmbSubCategory.SelectedValue.ToString(), out int selectedSubCatId))
                {
                    string qry = @"SELECT varId AS 'id', varietyName AS 'name' 
                           FROM Varieties 
                           WHERE catId = @catId AND subCatId = @subCatId";

                    await MainClass.CBFillAsync(qry, cmbVarieties, new Dictionary<string, object>
            {
                { "@catId", selectedCatId },
                { "@subCatId", selectedSubCatId }
            });
                }
                else
                {
                    Console.WriteLine("Unable to parse SelectedValue to integer.");
                }
            }
            else
            {
                Console.WriteLine("Category or SubCategory ComboBox SelectedValue is null.");
            }
        }






        public virtual void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        public virtual void btnSave_Click(object sender, EventArgs e)
        {
            if (MainClass.Validation(this) == false)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Please remove errors");
                return;
            }
            else
            {
                string qry = "";
                if (id == 0)//Insert
                {
                    qry = @"INSERT INTO Products (prdName, prdCode, prdDescription,  prdCostPrice, prdSellingPrice,
                            categoryId, subCatId, varietiesId, prdShape, prdSize, prdAvailableQty, prdGst, prdImage)
                            VALUES (@name, @code, @description, @cost_price, @selling_price, @category, @subCategory,
                            @variety, @shape, @size, @qty, @gst, @prdImage)";
                }
                else//Update
                {
                    qry = @"UPDATE Products set prdName =@name,
                                            prdCode = @code,
                                            prdDescription = @description,
                                            prdCostPrice = @cost_price,
                                            prdSellingPrice = @selling_price,
                                            categoryId = @category,
                                            subCatId = @subCategory,
                                            varietiesId = @variety,
                                            prdShape = @shape,
                                            prdSize = @size,
                                            prdAvailableQty = @qty,
                                            prdGst =@gst,
                                            prdImage = @prdImage
                                            where Products = @id";
                }

                Image temp = new Bitmap(txtPic.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", txtPrdName.Text);
                ht.Add("@code", txtPrdCode.Text);
                ht.Add("@description", txtDescription.Text);
                ht.Add("@cost_price", txtPrdPrice.Text);
                ht.Add("@selling_price", txtSellPrice.Text);
                ht.Add("@category", cmbCategory.SelectedValue);
                ht.Add("@subCategory", cmbSubCategory.SelectedValue ?? DBNull.Value);
                ht.Add("@variety", cmbVarieties.SelectedValue ?? DBNull.Value);
                ht.Add("@shape", txtShape.Text);
                ht.Add("@size", txtSize.Text);
                ht.Add("@qty", txtQtyAvail.Text);
                ht.Add("@gst", txtGST.Text);
                ht.Add("@prdImage", imageByteArray);

                if (MainClass.SQl(qry, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Show("Data Saved Successfully");
                    id = 0;
                    txtPrdName.Text = "";
                    txtPrdCode.Text = "";
                    txtQtyAvail.Text = "";
                    txtPrdPrice.Text = "";
                    txtSellPrice.Text = "";
                    cmbCategory.Text = "";
                    cmbSubCategory.Text = "";
                    cmbVarieties.Text = "";
                    txtDescription.Text = "";
                    txtSize.Text = "";
                    txtShape.Text = "";
                    txtGST.Text = "";
                    txtPic.Image = Cabinet_Inventory_Management_System.Properties.Resources.product_image_icon128;
                    txtPrdName.Focus();
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
            string qry = @"Select * from Products where prdId = " + id + "";
            SqlCommand sqlCommand = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Byte[] imageArray = (byte[])dt.Rows[0]["uImage"];
                byte[] imageByteArray = imageArray;
                txtPic.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
