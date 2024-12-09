using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Cabinet_Inventory_Management_System.View;

namespace Cabinet_Inventory_Management_System
{
    class MainClass
    {
        public static readonly string con_string = "Data Source=DESKTOP-4FQFSN2\\SQLEXPRESS01;Initial Catalog=CabinetInventoryDB;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);


        //Method to check user validation
        public static bool IsValidUser(string user, string pass)
        {
            bool isvalid = false;

            string qry = @"Select * from users where uUserName = '" + user+ "' and uPass = '" + pass+"'";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if(dt.Rows.Count > 0 )
            {
                isvalid = true;
                USER = dt.Rows[0]["uName"].ToString();

                Byte[] imageArray = (byte[])dt.Rows[0]["uImage"];
                byte[] imageByteArry = imageArray;
                IMG = Image.FromStream(new MemoryStream(imageArray));
            }
            return isvalid;

        }

        public static void StopBuffering(Panel ctr, bool doubleBuffer)
        {
            try
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, ctr, new object[] { doubleBuffer });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Create Property for username
        public static string user;


        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
        
        //for user Image
        public static Image img;

        public static Image IMG
        {
            get { return img; }
            private set { img = value; }
        }

        //Method for crud operation 

        public static int SQl(string qry, Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qry,con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                res = cmd.ExecuteNonQuery();
                if(con.State == ConnectionState.Open) { con.Close(); }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            return res;
        }

        //for loading data from database
        public static void LoadData(string qry,DataGridView gv,ListBox lb)
        {
            //Serial no in grid view
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;
            foreach(DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.Size =frmHome.Instance.Size;
                Background.Location =frmHome.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }

        //For Cb Fill

        /*public static void CBFill(string qry,ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }*/


        public static void CBFill(string qry, ComboBox cb, Dictionary<string, object> parameters = null)
        {
            using (SqlCommand cmd = new SqlCommand(qry, con))
            {
                cmd.CommandType = CommandType.Text;

                // Increase command timeout (e.g., 120 seconds)
                cmd.CommandTimeout = 120;

                // Add parameters if provided
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cb.DataSource = dt;
                    cb.DisplayMember = "name"; // Column to display in ComboBox
                    cb.ValueMember = "id";    // Column to use as the value
                    cb.SelectedIndex = -1;    // Clear selection
                }
            }
        }


        public static async Task CBFillAsync(string qry, ComboBox cb, Dictionary<string, object> parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con.ConnectionString)) // Use a new connection here
                {
                    await conn.OpenAsync();  // Open connection asynchronously

                    using (SqlCommand cmd = new SqlCommand(qry, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 180; // Set a timeout of 180 seconds

                        // Add parameters if provided
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            // Run the data fill operation asynchronously
                            await Task.Run(() => da.Fill(dt));

                            // Update the ComboBox on the UI thread
                            cb.Invoke((MethodInvoker)delegate
                            {
                                cb.DataSource = dt;
                                cb.DisplayMember = "name"; // Column to display
                                cb.ValueMember = "id";    // Column to use as value
                                cb.SelectedIndex = -1;    // Clear selection
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CBFillAsync: {ex.Message}");
            }
        }






        public static bool Validation(Form F)
        {
            bool isValid = false;


            int count = 0;
            foreach(Control c in F.Controls)
            {
                if(Convert.ToString(c.Tag) != "" && Convert.ToString(c.Tag) != null)
                {
                   if (c is Guna.UI2.WinForms.Guna2TextBox)
                    {
                        Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                        if (t.Text.Trim() == "")
                        {
                            t.BorderColor = Color.Red;
                            t.FocusedState.BorderColor = Color.Red;
                            t.HoverState.BorderColor = Color.Red;
                            count++;
                        }
                        else
                        {
                            t.BorderColor = Color.FromArgb(213, 218, 233);
                            t.FocusedState.BorderColor = Color.FromArgb(95, 61, 204);
                            t.HoverState.BorderColor = Color.FromArgb(95, 61, 204);
                        }
                    }

                }

                if(count == 0)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }

            return isValid;
        }



        public static void RefreshProductView()
        {
            if (Application.OpenForms["frmProductView"] is frmProductView mainForm)
            {
                mainForm.LoadProductFromDatabase();
               //mainForm.ClearFilters();
            }
        }
    }
}
