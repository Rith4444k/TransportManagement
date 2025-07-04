namespace TransportManagement
{
    partial class Transport
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textLN = new TextBox();
            txtCustomerID = new TextBox();
            textFN = new TextBox();
            txtGoodsID = new TextBox();
            textCusTp = new TextBox();
            dtpTransport = new DateTimePicker();
            btnAdd = new Button();
            btnNew = new Button();
            btnUpdate = new Button();
            btnLogout = new Button();
            dgvTransport = new DataGridView();
            textGoodsName = new TextBox();
            textLocationID = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textLocationName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTransport).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(445, 149);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 18);
            label2.TabIndex = 1;
            label2.Text = "CustomerType";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(485, 78);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 18);
            label3.TabIndex = 2;
            label3.Text = "FirstName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 43);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 18);
            label4.TabIndex = 3;
            label4.Text = "TransportDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(468, 38);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 18);
            label5.TabIndex = 4;
            label5.Text = "CustomerID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 188);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 18);
            label6.TabIndex = 5;
            label6.Text = "LocationName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(62, 78);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(84, 18);
            label7.TabIndex = 6;
            label7.Text = "GoodsID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(486, 114);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(96, 18);
            label8.TabIndex = 7;
            label8.Text = "LastName";
            // 
            // textLN
            // 
            textLN.Location = new Point(596, 109);
            textLN.Margin = new Padding(2);
            textLN.Name = "textLN";
            textLN.Size = new Size(179, 23);
            textLN.TabIndex = 12;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(596, 38);
            txtCustomerID.Margin = new Padding(2);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(179, 23);
            txtCustomerID.TabIndex = 14;
            // 
            // textFN
            // 
            textFN.Location = new Point(596, 73);
            textFN.Margin = new Padding(2);
            textFN.Name = "textFN";
            textFN.Size = new Size(179, 23);
            textFN.TabIndex = 15;
            // 
            // txtGoodsID
            // 
            txtGoodsID.Location = new Point(224, 73);
            txtGoodsID.Margin = new Padding(2);
            txtGoodsID.Name = "txtGoodsID";
            txtGoodsID.Size = new Size(179, 23);
            txtGoodsID.TabIndex = 16;
            // 
            // textCusTp
            // 
            textCusTp.Location = new Point(596, 144);
            textCusTp.Margin = new Padding(2);
            textCusTp.Name = "textCusTp";
            textCusTp.Size = new Size(179, 23);
            textCusTp.TabIndex = 17;
            // 
            // dtpTransport
            // 
            dtpTransport.CalendarFont = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTransport.Format = DateTimePickerFormat.Custom;
            dtpTransport.Location = new Point(224, 38);
            dtpTransport.Margin = new Padding(2);
            dtpTransport.Name = "dtpTransport";
            dtpTransport.Size = new Size(179, 23);
            dtpTransport.TabIndex = 19;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(568, 192);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 31);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(660, 192);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(88, 31);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(752, 192);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 31);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(844, 192);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(88, 31);
            btnLogout.TabIndex = 23;
            btnLogout.Text = "Back";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button4_Click;
            // 
            // dgvTransport
            // 
            dgvTransport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransport.Location = new Point(60, 238);
            dgvTransport.Name = "dgvTransport";
            dgvTransport.Size = new Size(872, 177);
            dgvTransport.TabIndex = 24;
            dgvTransport.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textGoodsName
            // 
            textGoodsName.Location = new Point(224, 109);
            textGoodsName.Margin = new Padding(2);
            textGoodsName.Name = "textGoodsName";
            textGoodsName.Size = new Size(179, 23);
            textGoodsName.TabIndex = 25;
            // 
            // textLocationID
            // 
            textLocationID.Location = new Point(224, 144);
            textLocationID.Margin = new Padding(2);
            textLocationID.Name = "textLocationID";
            textLocationID.Size = new Size(179, 23);
            textLocationID.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(62, 149);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(103, 18);
            label9.TabIndex = 27;
            label9.Text = "LocationID";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(62, 114);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(114, 18);
            label10.TabIndex = 28;
            label10.Text = "GoodsName";
            // 
            // textLocationName
            // 
            textLocationName.Location = new Point(224, 183);
            textLocationName.Margin = new Padding(2);
            textLocationName.Name = "textLocationName";
            textLocationName.Size = new Size(179, 23);
            textLocationName.TabIndex = 29;
            // 
            // Transport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 424);
            Controls.Add(textLocationName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textLocationID);
            Controls.Add(textGoodsName);
            Controls.Add(dgvTransport);
            Controls.Add(btnLogout);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(btnAdd);
            Controls.Add(dtpTransport);
            Controls.Add(textCusTp);
            Controls.Add(txtGoodsID);
            Controls.Add(textFN);
            Controls.Add(txtCustomerID);
            Controls.Add(textLN);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "Transport";
            Text = "TransportType";
            ((System.ComponentModel.ISupportInitialize)dgvTransport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textLN;
        private TextBox txtCustomerID;
        private TextBox textFN;
        private TextBox txtGoodsID;
        private TextBox textCusTp;
        private DateTimePicker dtpTransport;
        private Button btnAdd;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnLogout;
        private DataGridView dgvTransport;
        private TextBox textGoodsName;
        private TextBox textLocationID;
        private Label label9;
        private Label label10;
        private TextBox textLocationName;
    }
}