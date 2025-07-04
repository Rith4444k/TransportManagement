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

    public partial class Customer : Form
    {
        string connectionString = "Server=192.168.1.189,1433;Database=DbTransport;User Id=rith;Password=Ibm1111@@@@####;TrustServerCertificate=True;";

        public Customer()
        {
            InitializeComponent();
            LoadCustomer();
            dgvCus.CellClick += dgvCus_CellClick;
            btnAdd.Click += btnAdd_Click;
            btnSearch.Click += btnSearch_Click;
            btnUpdate.Click += btnUpdate_click;
            btnLogout.Click += BtnLogout_Click;
            btnNew.Click += BtnNew_Click;
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
          ClearForm();
        }

        private void BtnLogout_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ColumnClick();
            }
        }
        private void ColumnClick()
        {
            if (dgvCus.CurrentRow != null)
            {
                string searchTerm = dgvCus.CurrentRow.Cells["CustomerID"].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("SearchCustomer", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SearchID", searchTerm);

                        try
                        {
                            conn.Open();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                        
                                    txtCustomerFN.Text = reader["FirstName"]?.ToString() ?? "";
                                    txtCustomerLN.Text = reader["LastName"]?.ToString() ?? "";
                                    txtGender.Text = reader["Sex"]?.ToString() ?? "";
                                    txtPhone.Text = reader["PhoneNumber"]?.ToString() ?? "";
                                    txtAddress.Text = reader["Address"]?.ToString() ?? "";
                                    textCusTypeID.Text = reader["CustomerTypeID"]?.ToString() ?? "";
                                    textCusTN.Text = reader["CustomerTypeName"]?.ToString() ?? "";
                                   
                                   
                                }
                                else
                                {
                                    MessageBox.Show("No matching Customer found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void LoadCustomer()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LoadCustomer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No rows returned.");

                    dgvCus.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void ClearForm()
        {
         
            txtCustomerFN.Clear();
            txtCustomerLN.Clear();
            txtGender.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            textCusTypeID.Clear();
            textCusTN.Clear();
          
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertCustomer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", txtCustomerFN.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtCustomerLN.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtGender.Text);
                    cmd.Parameters.AddWithValue("@Address", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Sex", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CustomerTypeID", textCusTypeID.Text);
                    cmd.Parameters.AddWithValue("@CustomerTypeName ", textCusTN.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added successfully!");

                    LoadCustomer();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding Customer: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SearchID", txtSearch.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvCus.DataSource = dt;
            }
        }




        private void btnUpdate_click(object? sender, EventArgs e)
        {
            string CustomerID = dgvCus.CurrentRow.Cells["CustomerID"].Value?.ToString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(CustomerID));
                cmd.Parameters.AddWithValue("@FirstName", txtCustomerFN.Text);
                cmd.Parameters.AddWithValue("@LastName", txtCustomerLN.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtGender.Text);
                cmd.Parameters.AddWithValue("@Address", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Sex", txtAddress.Text);
                cmd.Parameters.AddWithValue("@CustomerTypeID", textCusTypeID.Text);
                cmd.Parameters.AddWithValue("@CustomerTypeName ", textCusTN.Text);


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully.");
                    LoadCustomer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }
    }
}
