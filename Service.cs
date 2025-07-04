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
    public partial class Service : Form
    {
        string connectionString = "Server=192.168.1.189,1433;Database=DbTransport;User Id=rith;Password=Ibm1111@@@@####;TrustServerCertificate=True;";

        public Service()
        {
            InitializeComponent();
            LoadServiceData();
            dgvService.CellClick += dgvService_CellClick;
            btnAdd.Click += btnAdd_Click;
            btnNew.Click += btnNew_Click;
            btnUpdate.Click += btnUpdate_click;

        }

        private void btnNew_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadServiceData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LoadService", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No rows returned.");

                    dgvService.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ColumnClick();
            }
        }
        private void ColumnClick()
        {
            if (dgvService.CurrentRow != null)
            {
                string searchTerm =dgvService.CurrentRow.Cells["ServiceNo"].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("SearchService", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ServiceNo", searchTerm);

                        try
                        {
                            conn.Open();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    textServiceNo.Text = reader["ServiceNo"]?.ToString() ?? "";
                                    textServiceType.Text = reader["ServiceType"]?.ToString() ?? "";
                                    textCustomerID.Text = reader["CustomerID"]?.ToString() ?? "";
                                    textTransportID.Text = reader["TransportID"]?.ToString() ?? "";
                                   
                                }
                                else
                                {
                                    MessageBox.Show("No matching Service found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void ClearForm()
        {
            textTransportID.Clear();
            textServiceType.Clear();
            textServiceNo.Clear();
            textCustomerID.Clear();
          
        }
        private void btnUpdate_click(object? sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateService", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ServiceNo", Convert.ToInt32(textServiceNo.Text));
                cmd.Parameters.AddWithValue("@ServiceType", textServiceType.Text);
                cmd.Parameters.AddWithValue("@CustomerID", textCustomerID.Text);
                cmd.Parameters.AddWithValue("@TransportID", textTransportID.Text);
              

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully.");
                    LoadServiceData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertService", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ServiceNo", textServiceNo.Text);
                    cmd.Parameters.AddWithValue("@ServiceType", textServiceType.Text);
                    cmd.Parameters.AddWithValue("@CustomerID", textCustomerID.Text);
                    cmd.Parameters.AddWithValue("@TransportID", textTransportID.Text);
                   
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service added successfully!");

                    LoadServiceData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding Service: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
