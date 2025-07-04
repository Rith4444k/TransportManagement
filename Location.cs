using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TransportManagement
{
    public partial class Location : Form
    {
        string connectionString = "Server=192.168.1.189,1433;Database=DbTransport;User Id=rith;Password=Ibm1111@@@@####;TrustServerCertificate=True;";

        public Location()
        {
            InitializeComponent();

            LoadLocationData();
            dgvLocation.CellClick += dgvLocation_CellClick;
            btnSearch.Click += btnSearch_click;
            btnUpdate.Click += btnUpdate_click;
            btnDelete.Click += btnDelete_click;
            btnAdd.Click += btnAdd_Click;
            btnNew.Click += btnNew_Click;
           
        }

        private void dgvLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {    
            if (e.RowIndex >= 0)
            {
                ColumnClick();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertLocation", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LocationID", txtLocationID.Text);
                    cmd.Parameters.AddWithValue("@LocationName", txtLocationName.Text);
                    cmd.Parameters.AddWithValue("@StartLocation", txtStartLocation.Text);
                    cmd.Parameters.AddWithValue("@TargetLocation", TargetLocation.Text);
                    cmd.Parameters.AddWithValue("@Distance", txtDistance.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Location added successfully!");

                    LoadLocationData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding location: " + ex.Message);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtLocationID.Clear();
            txtLocationName.Clear();
            txtStartLocation.Clear();
            TargetLocation.Clear();
            txtDistance.Clear();
        }


        private void LoadLocationData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LoadLocation", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No rows returned.");

                    dgvLocation.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

       private void ColumnClick()
        {
    if (dgvLocation.CurrentRow != null)
    {
        string searchTerm = dgvLocation.CurrentRow.Cells["LocationName"].Value?.ToString();

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SearchLocation", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);

                try
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtLocationID.Text = reader["LocationID"]?.ToString() ?? "";
                            txtLocationName.Text = reader["LocationName"]?.ToString() ?? "";
                            txtStartLocation.Text = reader["StartLocation"]?.ToString() ?? "";
                            TargetLocation.Text = reader["TargetLocation"]?.ToString() ?? "";
                            txtDistance.Text = reader["Distance"]?.ToString() ?? "";
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
        private void btnDelete_click(object? sender, EventArgs e)
        {
            if (dgvLocation.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvLocation.CurrentRow.Cells["LocationID"].Value);

                var confirm = MessageBox.Show("Delete this location?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("DeleteLocation", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@LocationID", id);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    btnSearch_click(sender, e); 
                }
            }
        }

        private void btnUpdate_click(object? sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateLocation", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LocationID", Convert.ToInt32(txtLocationID.Text));
                cmd.Parameters.AddWithValue("@LocationName", txtLocationName.Text);
                cmd.Parameters.AddWithValue("@StartLocation", txtStartLocation.Text);
                cmd.Parameters.AddWithValue("@TargetLocation", TargetLocation.Text);
                cmd.Parameters.AddWithValue("@Distance", txtDistance.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully.");
                    LoadLocationData();
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
                SqlCommand cmd = new SqlCommand("SearchLocation", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvLocation.DataSource = dt;
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
           
            this .Close();
        }
        private void TargetLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtLocationName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}