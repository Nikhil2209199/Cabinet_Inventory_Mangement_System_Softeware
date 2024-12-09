using Cabinet_Inventory_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Inventory_Management_System.View
{
    public partial class frmProductView : Sample
    {
        public frmProductView()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int catId = 0;
        public int subCatId = 0;
        public int varId = 0;

        private async void frmProductView_Load(object sender, EventArgs e)
        {
            LoadProductFromDatabase();

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

        private async void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue != null)
            {
                cmbSubCategory.SelectedIndexChanged -= cmbSubCategory_SelectedIndexChanged; // Temporarily detach event

                if (int.TryParse(cmbCategory.SelectedValue.ToString(), out int selectedCatId))
                {
                    string qry = @"SELECT subCatId AS 'id', subCatName AS 'name' 
                                   FROM SubCategory WHERE catId = @catId";

                    // Fill SubCategories asynchronously
                    await MainClass.CBFillAsync(qry, cmbSubCategory, new Dictionary<string, object>
                    {
                        { "@catId", selectedCatId }
                    });

                    cmbSubCategory.SelectedIndex = -1; // Prevent automatic selection
                    cmbVarieties.DataSource = null; // Clear Varieties

                    await LoadProductsFromDatabasebycategory(selectedCatId); // Load products by category
                }

                cmbSubCategory.SelectedIndexChanged += cmbSubCategory_SelectedIndexChanged; // Reattach event
            }
        }

        private async void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure a valid selection is made
            if (cmbSubCategory.SelectedValue != null && cmbSubCategory.SelectedIndex >= 0)
            {
                if (int.TryParse(cmbCategory.SelectedValue.ToString(), out int selectedCatId) &&
                    int.TryParse(cmbSubCategory.SelectedValue.ToString(), out int selectedSubCatId))
                {
                    string qry = @"SELECT varId AS 'id', varietyName AS 'name' 
                           FROM Varieties 
                           WHERE catId = @catId AND subCatId = @subCatId";

                    // Fill Varieties ComboBox asynchronously
                    await MainClass.CBFillAsync(qry, cmbVarieties, new Dictionary<string, object>
            {
                { "@catId", selectedCatId },
                { "@subCatId", selectedSubCatId }
            });

                    // Load products by category and subcategory
                    await LoadProductsFrmDBbyCtgryAndSubCtgry(selectedCatId, selectedSubCatId);
                }
            }
            else
            {
                // Clear Varieties if selection is invalid
                cmbVarieties.DataSource = null;
            }
        }


        public void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmProductAdd());
            LoadProductFromDatabase();
        }

        public void AddItems(string id, string prdName, string prdCode, string qtyAvailable, string prdPrice, Image img)
        {
            var w = new ucProduct()
            {
                Id = Convert.ToInt32(id),
                PName = prdName,
                PCode = prdCode,
                PQtyAvailable = qtyAvailable,
                Price = prdPrice,
                PImage = img
            };

            flowLayoutPanel1.Controls.Add(w);

            // Subscribe to the CardClicked event
            /*w.CardClicked += (productId) =>
            {
                var detailForm = new frmProductDetailView(productId);
                MainClass.BlurBackground(new frmProductDetailView());
            };*/
        }

        public void LoadProductFromDatabase()
        {
            flowLayoutPanel1.Controls.Clear();

            string qry = @"SELECT prdId, prdName, prdCode, prdAvailableQty, prdSellingPrice, prdImage FROM Products";

            using (SqlConnection conn = new SqlConnection(MainClass.con.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();

                var recordCount = 0;
                flowLayoutPanel1.Controls.Clear();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        recordCount++;
                        Byte[] imageArray = (byte[])row["prdImage"];
                        AddItems(row["prdId"].ToString(), row["prdName"].ToString(),
                                 row["prdCode"].ToString(), row["prdAvailableQty"].ToString(),
                                 row["prdSellingPrice"].ToString(),
                                 Image.FromStream(new MemoryStream(imageArray)));
                    }
                }
                lblRecordValue.Text = recordCount.ToString();
            }
        }

        private async Task LoadProductsFromDatabasebycategory(int catId)
        {
            flowLayoutPanel1.Controls.Clear();

            string qry = @"SELECT prdId, prdName, prdCode, prdAvailableQty, prdSellingPrice, prdImage 
                           FROM Products WHERE categoryId = @catId";

            using (SqlConnection conn = new SqlConnection(MainClass.con.ConnectionString))
            {
                await conn.OpenAsync();

                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@catId", catId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                await Task.Run(() => da.Fill(dt));
                conn.Close();

                var recordCount = 0;
                flowLayoutPanel1.Controls.Clear();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        recordCount++;
                        Byte[] imageArray = (byte[])row["prdImage"];
                        AddItems(row["prdId"].ToString(), row["prdName"].ToString(),
                                 row["prdCode"].ToString(), row["prdAvailableQty"].ToString(),
                                 row["prdSellingPrice"].ToString(),
                                 Image.FromStream(new MemoryStream(imageArray)));
                    }
                }
                lblRecordValue.Text = recordCount.ToString();
            }
        }

        private async Task LoadProductsFrmDBbyCtgryAndSubCtgry(int catId, int subCatId)
        {
            flowLayoutPanel1.Controls.Clear();

            string qry = @"SELECT prdId, prdName, prdCode, prdAvailableQty, prdSellingPrice, prdImage 
                           FROM Products WHERE categoryId = @catId AND subCatId = @subCatId";

            using (SqlConnection conn = new SqlConnection(MainClass.con.ConnectionString))
            {
                await conn.OpenAsync();

                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@catId", catId);
                cmd.Parameters.AddWithValue("@subCatId", subCatId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                await Task.Run(() => da.Fill(dt));
                conn.Close();

                var recordCount = 0;
                flowLayoutPanel1.Controls.Clear();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        recordCount++;
                        Byte[] imageArray = (byte[])row["prdImage"];
                        AddItems(row["prdId"].ToString(), row["prdName"].ToString(),
                                 row["prdCode"].ToString(), row["prdAvailableQty"].ToString(),
                                 row["prdSellingPrice"].ToString(),
                                 Image.FromStream(new MemoryStream(imageArray)));
                    }
                }
                lblRecordValue.Text = recordCount.ToString();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnClearFilter_Click(object sender, EventArgs e)
        {
            // Reset ComboBox selections
            cmbCategory.DataSource = null;
            cmbSubCategory.DataSource = null;
            cmbVarieties.DataSource = null;

            flowLayoutPanel1.Controls.Clear();

            // Reload categories asynchronously
            string qry = @"SELECT catId AS 'id', catName AS 'name' FROM Category";
            await MainClass.CBFillAsync(qry, cmbCategory);

            // Explicitly clear selection to prevent automatic selection
            cmbCategory.SelectedIndex = -1;
            cmbSubCategory.SelectedIndex = -1;
            cmbVarieties.SelectedIndex = -1;

            lblRecordValue.Text = "0"; // Optionally reset record count label

            LoadProductFromDatabase();
        }


        private async void cmbVarieties_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure all ComboBox selections are valid
            if (cmbCategory.SelectedValue != null && cmbSubCategory.SelectedValue != null && cmbVarieties.SelectedValue != null)
            {
                // Parse selected values
                if (int.TryParse(cmbCategory.SelectedValue.ToString(), out int selectedCatId) &&
                    int.TryParse(cmbSubCategory.SelectedValue.ToString(), out int selectedSubCatId) &&
                    int.TryParse(cmbVarieties.SelectedValue.ToString(), out int selectedVarId))
                {
                    // Fetch and load products based on the selected category, subcategory, and variety
                    await LoadPrdFrmDBByCtgrySbCtgryAndVariety(selectedCatId, selectedSubCatId, selectedVarId);
                }
                else
                {
                    Console.WriteLine("Failed to parse ComboBox SelectedValue into integers.");
                }
            }
            else
            {
                Console.WriteLine("One or more ComboBox SelectedValue is null.");
            }
        }


        private async Task LoadPrdFrmDBByCtgrySbCtgryAndVariety(int catId, int subCatId, int varId)
        {
            // Clear existing products
            flowLayoutPanel1.Controls.Clear();

            string qry = @"SELECT prdId, prdName, prdCode, prdAvailableQty, prdSellingPrice, prdImage 
                   FROM Products 
                   WHERE categoryId = @catId AND subCatId = @subCatId AND varietiesId = @varId";

            using (SqlConnection conn = new SqlConnection(MainClass.con.ConnectionString))
            {
                await conn.OpenAsync();

                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@catId", catId);
                cmd.Parameters.AddWithValue("@subCatId", subCatId);
                cmd.Parameters.AddWithValue("@varId", varId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                await Task.Run(() => da.Fill(dt)); // Use Task.Run to avoid blocking the UI thread
                conn.Close();

                int recordCount = 0;
                flowLayoutPanel1.Controls.Clear();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        recordCount++;
                        Byte[] imageArray = (byte[])row["prdImage"];
                        AddItems(row["prdId"].ToString(), row["prdName"].ToString(),
                                 row["prdCode"].ToString(), row["prdAvailableQty"].ToString(),
                                 row["prdSellingPrice"].ToString(),
                                 Image.FromStream(new MemoryStream(imageArray)));
                    }
                }

                lblRecordValue.Text = recordCount.ToString();
            }
        }


    }
}