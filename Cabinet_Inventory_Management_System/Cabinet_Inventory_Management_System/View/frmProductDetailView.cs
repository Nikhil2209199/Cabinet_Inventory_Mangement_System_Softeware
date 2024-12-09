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

namespace Cabinet_Inventory_Management_System.View
{
    public partial class frmProductDetailView : Sample
    {
        private int productId;
        
        public frmProductDetailView()
        {
            InitializeComponent();
            //this.productId = productId;
        }

        public frmProductDetailView(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            // MainClass.BlurBackground(this);
            this.id = productId;
            LoadDataOfProductByPrdId(productId);
        }

        public int id = 0;
        public int catId = 0;
        public int subCatId = 0;
        public int varId = 0;

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

                            // Store IDs for subsequent combo box loading
                            catId = dr["categoryId"] != DBNull.Value ? Convert.ToInt32(dr["categoryId"]) : 0;
                            subCatId = dr["subCatId"] != DBNull.Value ? Convert.ToInt32(dr["subCatId"]) : 0;
                            varId = dr["varietiesId"] != DBNull.Value ? Convert.ToInt32(dr["varietiesId"]) : 0;

                            LoadCategory();
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

        private void LoadCategory()
        {
            string qry = @"SELECT catId, catName FROM Category";

            using (SqlConnection conn = new SqlConnection(MainClass.con.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(qry, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbCategory.DataSource = dt;
                        cmbCategory.DisplayMember = "catName";
                        cmbCategory.ValueMember = "catId";

                        // Temporarily detach event
                        cmbCategory.SelectedIndexChanged -= cmbCategory_SelectedIndexChanged;
                        cmbCategory.SelectedValue = catId;
                        cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;

                        // Trigger loading subcategories
                        if (catId > 0)
                        {
                            LoadSubCategory(catId);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadSubCategory(int categoryId)
        {
            string qry = @"SELECT subCatId, subCatName FROM SubCategory WHERE catId = @catId";

            using (SqlConnection conn = new SqlConnection(MainClass.con.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(qry, conn))
                    {
                        cmd.Parameters.AddWithValue("@catId", categoryId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbSubCategory.DataSource = dt;
                        cmbSubCategory.DisplayMember = "subCatName";
                        cmbSubCategory.ValueMember = "subCatId";

                        // Temporarily detach event
                        cmbSubCategory.SelectedIndexChanged -= cmbSubCategory_SelectedIndexChanged;
                        cmbSubCategory.SelectedValue = subCatId;
                        cmbSubCategory.SelectedIndexChanged += cmbSubCategory_SelectedIndexChanged;

                        // Trigger loading varieties
                        if (subCatId > 0)
                        {
                            LoadVarieties(categoryId, subCatId);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading subcategories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadVarieties(int categoryId, int subCategoryId)
        {
            string qry = @"SELECT varId, varietyName FROM Varieties WHERE catId = @catId AND subCatId = @subCatId";

            using (SqlConnection conn = new SqlConnection(MainClass.con.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(qry, conn))
                    {
                        cmd.Parameters.AddWithValue("@catId", categoryId);
                        cmd.Parameters.AddWithValue("@subCatId", subCategoryId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbVarieties.DataSource = dt;
                        cmbVarieties.DisplayMember = "varietyName";
                        cmbVarieties.ValueMember = "varId";

                        // Set the selected value
                        cmbVarieties.SelectedValue = varId;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading varieties: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue != null && int.TryParse(cmbCategory.SelectedValue.ToString(), out int selectedCatId))
            {
                LoadSubCategory(selectedCatId);
            }
        }

        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubCategory.SelectedValue != null &&
                int.TryParse(cmbCategory.SelectedValue.ToString(), out int selectedCatId) &&
                int.TryParse(cmbSubCategory.SelectedValue.ToString(), out int selectedSubCatId))
            {
                LoadVarieties(selectedCatId, selectedSubCatId);
            }
        }




        private void frmProductDetailView_Load(object sender, EventArgs e)
        {
            // Use productId to load product details
            // Example: Display the product ID in a label or load product details
            // label1.Text = $"Product ID: {productId}";
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

        /*private void btnUpdate_Click(object sender, EventArgs e)
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
                string qry = @"UPDATE Products set prdName =@name,
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
                                            where prdId = @prdId";
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
                    guna2MessageDialog1.Show("Data Updated Successfully");
                    this.Close();
                }
            }
        }*/


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MainClass.Validation(this) == false)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Please remove errors.");
                return;
            }

            if (id <= 0)
            {
                guna2MessageDialog1.Show("Invalid Product ID. Cannot update.");
                return;
            }

            string qry = @"
        UPDATE Products SET 
            prdName = @name,
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
            prdGst = @gst,
            prdImage = @prdImage
        WHERE prdId = @id";

            try
            {
                Image temp = new Bitmap(txtPic.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageByteArray = ms.ToArray();

                using (SqlConnection connection = new SqlConnection(MainClass.con.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(qry, connection))
                    {
                        // Add parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", txtPrdName.Text);
                        cmd.Parameters.AddWithValue("@code", txtPrdCode.Text);
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@cost_price", txtPrdPrice.Text);
                        cmd.Parameters.AddWithValue("@selling_price", txtSellPrice.Text);
                        cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@subCategory", cmbSubCategory.SelectedValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@variety", cmbVarieties.SelectedValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@shape", txtShape.Text);
                        cmd.Parameters.AddWithValue("@size", txtSize.Text);
                        cmd.Parameters.AddWithValue("@qty", txtQtyAvail.Text);
                        cmd.Parameters.AddWithValue("@gst", txtGST.Text);
                        cmd.Parameters.AddWithValue("@prdImage", imageByteArray);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            guna2MessageDialog1.Show("Product Updated Successfully.");

                            this.Close();
                            MainClass.RefreshProductView();
                        }
                        else
                        {
                            guna2MessageDialog1.Show($"No product with ID {id} found in the database.");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                guna2MessageDialog1.Show($"Database Error: {sqlEx.Message}");
                Console.WriteLine($"SQL Error: {sqlEx.StackTrace}");
            }
            catch (Exception ex)
            {
                guna2MessageDialog1.Show($"Update Error: {ex.Message}");
                Console.WriteLine($"Error: {ex.StackTrace}");
            }
        }





        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // Set up the confirmation dialog using Guna2MessageDialog
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;

            // Show confirmation dialog
            var result = guna2MessageDialog1.Show("Are you sure you want to delete this product?", "Confirmation");

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Products WHERE prdId = @id";

                    using (SqlConnection connection = new SqlConnection(MainClass.con.ConnectionString))
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@id", productId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            // Show success message
                            guna2MessageDialog1.Show("Product deleted successfully.", "Success");

                            // Wait for 2 seconds before closing the form and refreshing the view
                            //await Task.Delay(2000);

                            this.Close();
                            MainClass.RefreshProductView();
                        }
                        else
                        {
                            guna2MessageDialog1.Show("No product was deleted. Please try again.");
                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    guna2MessageDialog1.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

