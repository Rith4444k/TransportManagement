namespace TransportManagement;
using Microsoft.Data.SqlClient;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Close.Click += Close_Click;
    }

    private void Close_Click(object? sender, EventArgs e)
    {
      this.Close();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text.Trim();
         string connectionString = "Server=192.168.1.189,1433;Database=DbTransport;User Id=rith;Password=Ibm1111@@@@####;TrustServerCertificate=True;";
        string query = "SELECT COUNT(*) FROM dbo.tbLogin WHERE Username = @username AND Password = @password";

        SqlConnection conn = new(connectionString);
        SqlCommand cmd = new(query, conn);
        {
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count == 1)
                {
                    // ✅ Login successful
                    Main mn = new Main();
                    mn.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

}
