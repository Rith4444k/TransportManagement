using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagement
{
    public partial class Goods : Form
    {
        string connectionString = "Server=192.168.1.189,1433;Database=DbTransport;User Id=rith;Password=Ibm1111@@@@####;TrustServerCertificate=True;";

        public Goods()
        {
            InitializeComponent();
            LoadGoodsData();
            dgvGoods.CellClick += dgvGoods_CellClick;
            btnDelete.Click += btnDelete_click;
            btnAdd.Click += btnAdd_Click;
            btnNew.Click += btnNew_Click;
            btnUpdate.Click += btnUpdate_click;
            btnSearch.Click += btnSearch_click;
        }

        private void btnNew_Click(object? sender, EventArgs e)
        {
           ClearForm();
        }

        private void dgvGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ColumnClick();
            }
        }
        private void ColumnClick()
        {
            if (dgvGoods.CurrentRow != null)
            {
                string searchTerm = dgvGoods.CurrentRow.Cells["GoodsName"].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("SearchGoods", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SearchName", searchTerm);

                        try
                        {
                            conn.Open();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                   txtGoodsID.Text = reader["GoodsID"]?.ToString() ?? "";
                                    txtGoodsType.Text = reader["GoodsType"]?.ToString() ?? "";
                                    txtGoodsPrice.Text = reader["GoodsPrice"]?.ToString() ?? "";
                                    txtWeight.Text = reader["Weight"]?.ToString() ?? "";
                                    txtDestination.Text = reader["Destination"]?.ToString() ?? "";
                                    txtSendDate.Text = reader["SendDate"]?.ToString() ?? "";
                                    txtGoodsName.Text = reader["GoodsName"]?.ToString() ?? "";
                                }
                                else
                                {
                                    MessageBox.Show("No matching location found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void LoadGoodsData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LoadGoods", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No rows returned.");

                    dgvGoods.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_click(object? sender, EventArgs e)
        {
            if (dgvGoods.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvGoods.CurrentRow.Cells["GoodsID"].Value);

                var confirm = MessageBox.Show("Delete this Goods?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("DeleteGoods", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@GoodsID", id);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    LoadGoodsData();
                }
            }
        }
        private void ClearForm()
        {
           txtGoodsID.Clear();
            txtGoodsName.Clear();
            txtGoodsType.Clear();
            txtGoodsPrice.Clear();
            txtWeight.Clear();
            txtSendDate.Clear();
            txtDestination.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertGoods", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@GoodsID",txtGoodsID.Text);
                    cmd.Parameters.AddWithValue("@GoodsName", txtGoodsName.Text);
                    cmd.Parameters.AddWithValue("@GoodsPrice", txtGoodsPrice.Text);
                    cmd.Parameters.AddWithValue("@GoodsType", txtGoodsType.Text);
                    cmd.Parameters.AddWithValue("@SendDate", txtSendDate.Text);
                    cmd.Parameters.AddWithValue("@Weight", txtWeight.Text);
                    cmd.Parameters.AddWithValue("@Destination", txtDestination.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Goods added successfully!");

                    LoadGoodsData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding goods: " + ex.Message);
                }
            }
        }

        private void btnUpdate_click(object? sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateGoods", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@GoodsID", Convert.ToInt32(txtGoodsID.Text));
                cmd.Parameters.AddWithValue("@GoodsName", txtGoodsName.Text);
                cmd.Parameters.AddWithValue("@GoodsPrice", txtGoodsPrice.Text);
                cmd.Parameters.AddWithValue("@GoodsType", txtGoodsType.Text);
                cmd.Parameters.AddWithValue("@SendDate", txtSendDate.Text);
                cmd.Parameters.AddWithValue("@Weight", txtWeight.Text);
                cmd.Parameters.AddWithValue("@Destination", txtDestination.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully.");
                    LoadGoodsData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }
        private void btnSearch_click(object? sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchGoods", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SearchID", txtSearch.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvGoods.DataSource = dt;
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGoods_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
