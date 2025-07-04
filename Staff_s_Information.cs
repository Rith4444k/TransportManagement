using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TransportManagement
{
    public partial class Staff_s_Information : Form
    {
        string connectionString = "Server=192.168.1.189,1433;Database=DbTransport;User Id=rith;Password=Ibm1111@@@@####;TrustServerCertificate=True;";

        public Staff_s_Information()
        {
            InitializeComponent();
            LoadStaffData();
            dgvStaff.CellClick += dgvStaff_CellClick;
            btnAdd.Click += BtnAdd_Click;
            PicStaff.Click += PicStaff_Click;
            btnUpdate.Click += btnUpdate_click;
            btnDelete.Click += bntDelete_click;
        }

        private void ClearForm()
        {

            txtFirstName.Clear();
            txtLastName.Clear();
            txtGender.Clear();
            textAge.Clear();
            txtPhone.Clear();
            txtConAdd.Clear();
            txtPosition.Clear();
            txtSalary.Clear();

            dtpBirthDate.Value = DateTime.Today;
            dtpHiredDate.Value = DateTime.Today;

            chkIsStopwork.Checked = false;
            PicStaff.Image = null;
        }
        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    
                    SqlCommand cmd = new SqlCommand("InsertStaff", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                    cmd.Parameters.AddWithValue("@StaffPosition", txtPosition.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@Salary", double.TryParse(txtSalary.Text, out var salary) ? salary : 0);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Address", txtConAdd.Text);
                    cmd.Parameters.AddWithValue("@Age", textAge.Text);
                    cmd.Parameters.AddWithValue("@HiredDate", dtpHiredDate.Value);
                    cmd.Parameters.AddWithValue("@Stopwork", chkIsStopwork.Checked);


                    if (PicStaff.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            PicStaff.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            cmd.Parameters.AddWithValue("@Photo", ms.ToArray());
                        }
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Photo", DBNull.Value);
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Staff added successfully!");
                    LoadStaffData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void PicStaff_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Staff Photo";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PicStaff.Image = Image.FromFile(openFileDialog.FileName);
                    PicStaff.SizeMode = PictureBoxSizeMode.StretchImage; 
                }
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ColumnClick();
            }
        }

        private void LoadStaffData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LoadStaff", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No rows returned.");

                    dgvStaff.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Staff_s_Information_Load(object sender, EventArgs e)
        {
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


        }




        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColumnClick()
        {
            if (dgvStaff.CurrentRow != null)
            {
                string searchTerm = dgvStaff.CurrentRow.Cells["FirstName"].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("SearchStaff", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SearchFN", searchTerm);

                        try
                        {
                            conn.Open();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {


                                    txtFirstName.Text = reader["FirstName"]?.ToString() ?? "";
                                    txtLastName.Text = reader["LastName"]?.ToString() ?? "";
                                    txtGender.Text = reader["Gender"]?.ToString() ?? "";

                                   if (DateTime.TryParse(reader["BirthDate"]?.ToString(), out DateTime birthDate))
                                    {
                                        dtpBirthDate.Value = birthDate;
                                   }

                                  txtPhone.Text = reader["PhoneNumber"]?.ToString() ?? "";
                                    textAge.Text = reader["Age"]?.ToString() ?? "";
                                    txtConAdd.Text = reader["Address"]?.ToString() ?? "";
                                    txtPosition.Text = reader["StaffPosition"]?.ToString() ?? "";
                                    txtSalary.Text = reader["Salary"]?.ToString() ?? "";
                                    if (DateTime.TryParse(reader["HiredDate"]?.ToString(), out DateTime hiredDate))
                                        dtpHiredDate.Value = hiredDate;


                                    chkIsStopwork.Checked = reader["Stopwork"] != DBNull.Value && Convert.ToBoolean(reader["Stopwork"]);




                                    if (reader["Photo"] != DBNull.Value)
                                    {
                                        byte[] imgData = (byte[])reader["Photo"];
                                        using (MemoryStream ms = new MemoryStream(imgData))
                                        {
                                            PicStaff.Image = Image.FromStream(ms);
                                        }
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("No matching Stagg found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void btnUpdate_click(object? sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow == null || dgvStaff.CurrentRow.Cells["StaffID"].Value == null)
            {
                MessageBox.Show("Please select a staff record to update.");
                return;
            }

            string? staffIDStr = dgvStaff.CurrentRow.Cells["StaffID"].Value?.ToString();
            if (!int.TryParse(staffIDStr, out int staffID))
            {
                MessageBox.Show("Invalid StaffID.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("UpdateStaff", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

               
                cmd.Parameters.AddWithValue("@StaffID", staffID);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text.Trim());
                cmd.Parameters.AddWithValue("@StaffPosition", txtPosition.Text.Trim());
                cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);

                if (!double.TryParse(txtSalary.Text, out double salary))
                {
                    MessageBox.Show("Invalid salary. Please enter a numeric value.");
                    return;
                }
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtConAdd.Text.Trim());
                cmd.Parameters.AddWithValue("@Age", textAge.Text.Trim());
                cmd.Parameters.AddWithValue("@HiredDate", dtpHiredDate.Value);
                cmd.Parameters.AddWithValue("@Stopwork", chkIsStopwork.Checked);


                if (PicStaff.Image != null && !PicStaff.Image.Equals(DBNull.Value))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Bitmap bmp = new Bitmap(PicStaff.Image))
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            cmd.Parameters.AddWithValue("@Photo", ms.ToArray());
                        }
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Photo", DBNull.Value);
                }
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully."); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }
        private void bntDelete_click(object? sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvStaff.CurrentRow.Cells["StaffID"].Value);

                var confirm = MessageBox.Show("Delete this Staff?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("DeleteStaff", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StaffID", id);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    LoadStaffData();
                    ClearForm();
                   
                }
            }
        }


    }
}
