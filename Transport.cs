using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TransportManagement
{
    public partial class Transport : Form
    {
        string connectionString = "Server=192.168.1.189,1433;Database=DbTransport;User Id=rith;Password=Ibm1111@@@@####;TrustServerCertificate=True;";

        public Transport()
        {
            InitializeComponent();
            LoadTransportData();
            btnAdd.Click += btnAdd_Click;
            dgvTransport.CellClick += dgvTransport_CellClick;
            btnNew.Click += btnNew_Clibk;
            btnUpdate.Click += btnUpdate_Click;
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {

            if (dgvTransport.CurrentRow == null || dgvTransport.CurrentRow.Cells["TransportID"].Value == null)
            {
                MessageBox.Show("Please select a staff record to update.");
                return;
            }

            string? staffIDStr = dgvTransport.CurrentRow.Cells["TransportID"].Value?.ToString();
            if (!int.TryParse(staffIDStr, out int TransportID))
            {
                MessageBox.Show("Invalid TransportID.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateTransport", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TransportID", TransportID);
                cmd.Parameters.AddWithValue("@TransportDate", dtpTransport.Value);
                cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                cmd.Parameters.AddWithValue("@FirstName", textFN.Text);
                cmd.Parameters.AddWithValue("@LastName", textLN.Text);
                cmd.Parameters.AddWithValue("@CustomerTypeName", textCusTp.Text);
                cmd.Parameters.AddWithValue("@GoodsID", txtGoodsID.Text);
                cmd.Parameters.AddWithValue("@GoodsName", textGoodsName.Text);
                cmd.Parameters.AddWithValue("@LocationID", textLocationID.Text);
                cmd.Parameters.AddWithValue("@LocationName", textLocationName.Text);



                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully.");
                    LoadTransportData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }
        

        private void btnNew_Clibk(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvTransport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ColumnClick();
            }
        }
        private void LoadTransportData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LoadTransport", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No rows returned.");

                    dgvTransport.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertTransport", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TransportDate", dtpTransport.Value);
                    cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                    cmd.Parameters.AddWithValue("@FirstName", textFN.Text);
                    cmd.Parameters.AddWithValue("@LastName", textLN.Text);
                    cmd.Parameters.AddWithValue("@CustomerTypeName", textCusTp.Text);
                    cmd.Parameters.AddWithValue("@GoodsID", txtGoodsID.Text);
                    cmd.Parameters.AddWithValue("@GoodsName", textGoodsName.Text);
                    cmd.Parameters.AddWithValue("@LocationID", textLocationID.Text);
                    cmd.Parameters.AddWithValue("@LocationName", textLocationName.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transport added successfully!");

                    LoadTransportData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding Transport: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
           
            txtGoodsID.Clear();
           txtCustomerID.Clear();
            textLocationName.Clear();
            textLN.Clear();
            textFN.Clear();
            textCusTp.Clear();
            textGoodsName.Clear();
            textLocationID.Clear();
            
        }

        private void ColumnClick()
        {
            if (dgvTransport.CurrentRow != null)
            {
                string searchTerm = dgvTransport.CurrentRow?.Cells["TransportID"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    int invoiceNo;
                    if (int.TryParse(searchTerm, out invoiceNo))
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand("SearchTransport", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@TransportID", searchTerm);

                            try
                            {
                                conn.Open();

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        if (DateTime.TryParse(reader["TransportDate"]?.ToString(), out DateTime transportDate))
                                            dtpTransport.Value = transportDate;
                                        txtCustomerID.Text = reader["CustomerID"]?.ToString() ?? "";
                                        txtGoodsID.Text = reader["GoodsID"]?.ToString() ?? "";
                                        textGoodsName.Text = reader["GoodsName"]?.ToString() ?? "";
                                        textLocationID.Text = reader["LocationID"]?.ToString() ?? "";
                                        textLN.Text = reader["LastName"]?.ToString() ?? "";
                                        textFN.Text = reader["FirstName"]?.ToString() ?? "";
                                        textCusTp.Text = reader["CustomerTypeName"]?.ToString() ?? "";
                                         textLocationName.Text = reader["LocationName"]?.ToString() ?? "";

                                    }
                                    else
                                    {
                                        MessageBox.Show("No matching Transport found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
