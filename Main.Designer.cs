namespace TransportManagement
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnInvoice = new Button();
            btnPayment = new Button();
            btnGoods = new Button();
            button2 = new Button();
            button1 = new Button();
            btnTransport = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            btnCustomer = new Button();
            btnStaff = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 39);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 18);
            label1.TabIndex = 0;
            label1.Text = "Transport Management";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnInvoice);
            panel2.Controls.Add(btnPayment);
            panel2.Controls.Add(btnGoods);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnTransport);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnCustomer);
            panel2.Controls.Add(btnStaff);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 39);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 719);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnInvoice
            // 
            btnInvoice.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInvoice.Location = new Point(42, 401);
            btnInvoice.Margin = new Padding(2);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(122, 36);
            btnInvoice.TabIndex = 7;
            btnInvoice.Text = "Invoice";
            btnInvoice.UseVisualStyleBackColor = true;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(42, 362);
            btnPayment.Margin = new Padding(2);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(122, 35);
            btnPayment.TabIndex = 6;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnGoods
            // 
            btnGoods.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGoods.Location = new Point(42, 285);
            btnGoods.Margin = new Padding(2);
            btnGoods.Name = "btnGoods";
            btnGoods.Size = new Size(122, 36);
            btnGoods.TabIndex = 5;
            btnGoods.Text = "Goods";
            btnGoods.UseVisualStyleBackColor = true;
            btnGoods.Click += btnGoods_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(42, 325);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(122, 33);
            button2.TabIndex = 4;
            button2.Text = "Service";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(42, 247);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(122, 34);
            button1.TabIndex = 3;
            button1.Text = "Location";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnTransport
            // 
            btnTransport.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransport.Location = new Point(42, 208);
            btnTransport.Margin = new Padding(2);
            btnTransport.Name = "btnTransport";
            btnTransport.Size = new Size(122, 35);
            btnTransport.TabIndex = 0;
            btnTransport.Text = "Transport";
            btnTransport.UseVisualStyleBackColor = true;
            btnTransport.Click += button1_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(42, 441);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(122, 37);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImage = Properties.Resources.logo_school;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(42, 10);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 101);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomer.Location = new Point(42, 168);
            btnCustomer.Margin = new Padding(2);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(122, 36);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStaff.Location = new Point(42, 124);
            btnStaff.Margin = new Padding(2);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(122, 40);
            btnStaff.TabIndex = 0;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Moccasin;
            panel3.BackgroundImage = Properties.Resources.Pano;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(210, 39);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(652, 719);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 758);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Main";
            Text = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnCustomer;
        private Button btnStaff;
        private Button btnLogout;
        private Button btnTransport;
        private Button button2;
        private Button button1;
        private Button btnPayment;
        private Button btnGoods;
        private Button btnInvoice;
    }
}