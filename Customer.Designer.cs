namespace TransportManagement
{
    partial class Customer
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtGender = new TextBox();
            txtCustomerFN = new TextBox();
            btnNew = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnLogout = new Button();
            label6 = new Label();
            txtCustomerLN = new TextBox();
            dgvCus = new DataGridView();
            textCusTN = new TextBox();
            textCusTypeID = new TextBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCus).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(83, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 18);
            label2.TabIndex = 1;
            label2.Text = "FirstName";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(799, 18);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(621, 22);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(174, 23);
            txtSearch.TabIndex = 3;
            //txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(83, 99);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 18);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(83, 140);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 18);
            label4.TabIndex = 5;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(84, 180);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 18);
            label5.TabIndex = 6;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(256, 180);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(269, 23);
            txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(256, 140);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(269, 23);
            txtPhone.TabIndex = 8;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(256, 99);
            txtGender.Margin = new Padding(2);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(269, 23);
            txtGender.TabIndex = 9;
            // 
            // txtCustomerFN
            // 
            txtCustomerFN.Location = new Point(256, 24);
            txtCustomerFN.Margin = new Padding(2);
            txtCustomerFN.Name = "txtCustomerFN";
            txtCustomerFN.Size = new Size(269, 23);
            txtCustomerFN.TabIndex = 10;
            // 
            // btnNew
            // 
            btnNew.ForeColor = SystemColors.ControlText;
            btnNew.Location = new Point(553, 248);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(78, 32);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
          //  btnNew.Click += btnNew_Click;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(635, 248);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 32);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = SystemColors.ControlText;
            btnUpdate.Location = new Point(717, 248);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 32);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.ForeColor = SystemColors.ControlText;
            btnLogout.Location = new Point(799, 248);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(78, 32);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Back";
            btnLogout.UseVisualStyleBackColor = true;
           // btnLogout.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(83, 60);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 18);
            label6.TabIndex = 17;
            label6.Text = "LastName";
            // 
            // txtCustomerLN
            // 
            txtCustomerLN.Location = new Point(256, 60);
            txtCustomerLN.Margin = new Padding(2);
            txtCustomerLN.Name = "txtCustomerLN";
            txtCustomerLN.Size = new Size(269, 23);
            txtCustomerLN.TabIndex = 18;
            // 
            // dgvCus
            // 
            dgvCus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCus.Location = new Point(83, 310);
            dgvCus.Name = "dgvCus";
            dgvCus.Size = new Size(794, 204);
            dgvCus.TabIndex = 19;
            // 
            // textCusTN
            // 
            textCusTN.Location = new Point(256, 257);
            textCusTN.Margin = new Padding(2);
            textCusTN.Name = "textCusTN";
            textCusTN.Size = new Size(269, 23);
            textCusTN.TabIndex = 21;
            // 
            // textCusTypeID
            // 
            textCusTypeID.Location = new Point(256, 221);
            textCusTypeID.Margin = new Padding(2);
            textCusTypeID.Name = "textCusTypeID";
            textCusTypeID.Size = new Size(269, 23);
            textCusTypeID.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(83, 254);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(135, 18);
            label8.TabIndex = 24;
            label8.Text = "CusTypeName";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(83, 221);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(158, 18);
            label9.TabIndex = 25;
            label9.Text = "CustomerTypeID";
            //label9.Click += label9_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 526);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textCusTypeID);
            Controls.Add(textCusTN);
            Controls.Add(dgvCus);
            Controls.Add(txtCustomerLN);
            Controls.Add(label6);
            Controls.Add(btnLogout);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnNew);
            Controls.Add(txtCustomerFN);
            Controls.Add(txtGender);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(2);
            Name = "Customer";
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dgvCus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtGender;
        private TextBox txtCustomerFN;
        private Button btnNew;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnLogout;
        private Label label6;
        private TextBox txtCustomerLN;
        private DataGridView dgvCus;
        private TextBox textCusTN;
        private TextBox textCusTypeID;
        private Label label8;
        private Label label9;
    }
}