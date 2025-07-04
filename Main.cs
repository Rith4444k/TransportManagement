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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff_s_Information si = new Staff_s_Information();
            si.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            cs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transport ts = new Transport();
            ts.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Location loc = new Location();
            loc.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service sv = new Service();
            sv.Show();
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            Goods g = new Goods();
            g.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment pm = new Payment();
            pm.Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice();
            inv.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
