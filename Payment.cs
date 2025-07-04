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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TransportManagement
{
    public partial class Payment : Form
    {

        string connectionString = "Server=192.168.1.189,1433;Database=DbTransport;User Id=rith;Password=Ibm1111@@@@####;TrustServerCertificate=True;";

        public Payment()
        {
            InitializeComponent();
            LoadPaymentData();
            btnAdd.Click += btnAdd_Click;
            btnNew.Click += btnNew_Click;
            dgvPayment.CellClick += dgvPayment_CellClick;
            btnUpdate.Click += btnUpdate_click;
            btnSearch.Click += btnSearch_click;

        }
        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ColumnClick();
            }
        }
        private void btnNew_Click(object? sender, EventArgs e)
        {
                ClearForm();
        }

        private void LoadPaymentData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LoadPayment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No rows returned.");

                    dgvPayment.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void ClearForm()
        {
            textPaymentID.Clear();
           textPaisAmount.Clear();
           textCustomerID.Clear();
            textTransportID.Clear();
            textStaffID.Clear();
            textStaffFN.Clear();
            textStaffLN.Clear();
            textStaffPos.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Insertpayment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PaymentNo", textPaymentID.Text);
                    cmd.Parameters.AddWithValue("@PaymentDate",dtpPaymentDate.Value);
                    cmd.Parameters.AddWithValue("@PaidAmount", textPaisAmount.Text);
                    cmd.Parameters.AddWithValue("@CustomerID", textCustomerID.Text);
                    cmd.Parameters.AddWithValue("@TransportID", textTransportID.Text);
                    cmd.Parameters.AddWithValue("@StaffID", textStaffID.Text);
                    cmd.Parameters.AddWithValue("@FirstName", textStaffFN.Text);
                    cmd.Parameters.AddWithValue("@LastName", textStaffLN.Text);
                    cmd.Parameters.AddWithValue("@StaffPosition", textStaffPos.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment added successfully!");

                    LoadPaymentData();
                   ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding Invoice: " + ex.Message);
                }
            }
        }
        private void ColumnClick()
        {
            if (dgvPayment.CurrentRow != null)
            {
                string searchTerm = dgvPayment.CurrentRow?.Cells["PaymentNo"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    int invoiceNo;
                    if (int.TryParse(searchTerm, out invoiceNo))
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand("SearchPayment", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@PaymentNo", searchTerm);

                            try
                            {
                                conn.Open();

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        textPaymentID.Text = reader["PaymentNo"]?.ToString() ?? "";

                                        if (DateTime.TryParse(reader["PaymentDate"]?.ToString(), out DateTime payDate))
                                        {
                                            dtpPaymentDate.Value = payDate;
                                        }
                                        textPaisAmount.Text = reader["PaidAmount"]?.ToString() ?? "";
                                        textCustomerID.Text = reader["CustomerID"]?.ToString() ?? "";
                                        textTransportID.Text = reader["TransportID"]?.ToString() ?? "";
                                        textStaffID.Text = reader["StaffID"]?.ToString() ?? "";
                                        textStaffFN.Text = reader["FirstName"]?.ToString() ?? "";
                                       textStaffLN.Text = reader["LastName"]?.ToString() ?? "";
                                        textStaffPos.Text = reader["StaffPosition"]?.ToString() ?? "";
                                       
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
        private void btnUpdate_click(object? sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdatePayment", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PaymentNo", Convert.ToInt32(textPaymentID.Text));
                cmd.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value);
                cmd.Parameters.AddWithValue("@PaidAmount", textPaisAmount.Text);
                cmd.Parameters.AddWithValue("@CustomerID", textCustomerID.Text);
                cmd.Parameters.AddWithValue("@TransportID", textTransportID.Text);
                cmd.Parameters.AddWithValue("@StaffID", textStaffID.Text);
                cmd.Parameters.AddWithValue("@FirstName", textStaffFN.Text);
                cmd.Parameters.AddWithValue("@LastName", textStaffLN.Text);
                cmd.Parameters.AddWithValue("@StaffPosition", textStaffPos.Text);


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully.");
                    LoadPaymentData();
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
                SqlCommand cmd = new SqlCommand("SearchPayment", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PaymentNo", txtSearch.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

               dgvPayment.DataSource = dt;
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           this.Close();    
        }
    }
}
