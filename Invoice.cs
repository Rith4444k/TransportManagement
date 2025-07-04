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
    public partial class Invoice : Form
    {
        string connectionString = "Server=192.168.1.189,1433;Database=DbTransport;User Id=rith;Password=Ibm1111@@@@####;TrustServerCertificate=True;";

        public Invoice()
        {
            InitializeComponent();
            LoadInvoiceData();
            dgvInvoice.CellClick += dgvInvoice_CellClick;
            btnAdd.Click += btnAdd_Click;
            btnNew.Click += btnNew_Click;
            btnSearch.Click += btnSearch_click;
            btnUpdate.Click += btnUpdate_click;
        }

        private void btnNew_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ColumnClick();
            }
        }

        private void ClearForm()
        {
            textCusID.Clear();
            textFN.Clear();
            textInDate.Clear();
            textInNo.Clear();
            textLN.Clear();
           textPaidAm.Clear();
            textPos.Clear();
            textStaID.Clear();
            textTotalAm.Clear();
            textTranID.Clear();
        }

        private void ColumnClick()
        {
            if (dgvInvoice.CurrentRow != null)
            {
                string searchTerm = dgvInvoice.CurrentRow?.Cells["InvoiceNo"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    int invoiceNo;
                    if (int.TryParse(searchTerm, out invoiceNo))
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand("SearchInvoice", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@InvoiceNo", searchTerm);

                            try
                            {
                                conn.Open();

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        textInNo.Text = reader["InvoiceNo"]?.ToString() ?? "";
                                        textInDate.Text = reader["InvoiceDate"]?.ToString() ?? "";
                                        textCusID.Text = reader["CustomerID"]?.ToString() ?? "";
                                        textTotalAm.Text = reader["TotalAmount"]?.ToString() ?? "";
                                        textPaidAm.Text = reader["PaidAmount"]?.ToString() ?? "";
                                        textTranID.Text = reader["TransportID"]?.ToString() ?? "";
                                        textStaID.Text = reader["StaffID"]?.ToString() ?? "";
                                        textFN.Text = reader["FirstName"]?.ToString() ?? "";
                                        textLN.Text = reader["LastName"]?.ToString() ?? "";
                                        textPos.Text = reader["StaffPosition"]?.ToString() ?? "";
                                    }
                                    else
                                    {
                                        MessageBox.Show("No matching Invoice found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void LoadInvoiceData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LoadInvoice", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No rows returned.");

                    dgvInvoice.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertInvoice", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InvoiceNo", textInNo.Text);
                    cmd.Parameters.AddWithValue("@InvoiceDate", textInDate.Text);
                    cmd.Parameters.AddWithValue("@TotalAmount", textTotalAm.Text);
                    cmd.Parameters.AddWithValue("@PaidAmount", textPaidAm.Text);
                    cmd.Parameters.AddWithValue("@CustomerID", textCusID.Text);
                    cmd.Parameters.AddWithValue("@TransportID", textTranID.Text);
                    cmd.Parameters.AddWithValue("@StaffID", textStaID.Text);
                    cmd.Parameters.AddWithValue("@FirstName", textFN.Text);
                    cmd.Parameters.AddWithValue("@LastName", textLN.Text);
                    cmd.Parameters.AddWithValue("@StaffPosition", textPos.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Invoive added successfully!");

                    LoadInvoiceData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding Invoice: " + ex.Message);
                }
            }
        }
        private void btnSearch_click(object? sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchInvoice", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@InvoiceNo", textSearch.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvInvoice.DataSource = dt;
            }
        }
        private void btnUpdate_click(object? sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateInvoice", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@InvoiceNo", Convert.ToInt32(textInNo.Text));
                cmd.Parameters.AddWithValue("@InvoiceDate", textInDate.Text);
                cmd.Parameters.AddWithValue("@TotalAmount", textTotalAm.Text);
                cmd.Parameters.AddWithValue("@PaidAmount", textPaidAm.Text);
                cmd.Parameters.AddWithValue("@CustomerID", textCusID.Text);
                cmd.Parameters.AddWithValue("@TransportID",textTranID.Text);
                cmd.Parameters.AddWithValue("@StaffID", textStaID.Text);
                cmd.Parameters.AddWithValue("@FirstName", textFN.Text);
                cmd.Parameters.AddWithValue("@LastName", textLN.Text);
                cmd.Parameters.AddWithValue("@StaffPosition", textPos.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully.");
                    LoadInvoiceData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Invoice_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
