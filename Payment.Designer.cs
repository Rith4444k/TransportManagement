namespace TransportManagement
{
    partial class Payment
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textPaymentID = new TextBox();
            textPaisAmount = new TextBox();
            textCustomerID = new TextBox();
            textTransportID = new TextBox();
            textStaffID = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnNew = new Button();
            btnUpdate = new Button();
            btnLogout = new Button();
            dtpPaymentDate = new DateTimePicker();
            dgvPayment = new DataGridView();
            textStaffPos = new TextBox();
            textStaffLN = new TextBox();
            textStaffFN = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 0;
            label1.Text = "PaymentID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 18);
            label2.TabIndex = 1;
            label2.Text = "PaymentDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 95);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 18);
            label3.TabIndex = 2;
            label3.Text = "PaidAmount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 122);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 18);
            label4.TabIndex = 3;
            label4.Text = "CustomerID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 155);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 18);
            label5.TabIndex = 4;
            label5.Text = "TransportID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 187);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 18);
            label6.TabIndex = 5;
            label6.Text = "StaffID";
            // 
            // textPaymentID
            // 
            textPaymentID.Location = new Point(207, 34);
            textPaymentID.Margin = new Padding(2);
            textPaymentID.Name = "textPaymentID";
            textPaymentID.Size = new Size(203, 23);
            textPaymentID.TabIndex = 6;
            // 
            // textPaisAmount
            // 
            textPaisAmount.Location = new Point(207, 92);
            textPaisAmount.Margin = new Padding(2);
            textPaisAmount.Name = "textPaisAmount";
            textPaisAmount.Size = new Size(203, 23);
            textPaisAmount.TabIndex = 8;
            // 
            // textCustomerID
            // 
            textCustomerID.Location = new Point(207, 122);
            textCustomerID.Margin = new Padding(2);
            textCustomerID.Name = "textCustomerID";
            textCustomerID.Size = new Size(203, 23);
            textCustomerID.TabIndex = 9;
            // 
            // textTransportID
            // 
            textTransportID.Location = new Point(207, 155);
            textTransportID.Margin = new Padding(2);
            textTransportID.Name = "textTransportID";
            textTransportID.Size = new Size(203, 23);
            textTransportID.TabIndex = 10;
            // 
            // textStaffID
            // 
            textStaffID.Location = new Point(207, 187);
            textStaffID.Margin = new Padding(2);
            textStaffID.Name = "textStaffID";
            textStaffID.Size = new Size(203, 23);
            textStaffID.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(625, 11);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(203, 23);
            txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(832, 7);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 30);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(586, 212);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(668, 212);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(78, 29);
            btnNew.TabIndex = 15;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(750, 212);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 29);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(832, 212);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(78, 29);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "Back";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Format = DateTimePickerFormat.Custom;
            dtpPaymentDate.Location = new Point(207, 65);
            dtpPaymentDate.Margin = new Padding(2);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(203, 23);
            dtpPaymentDate.TabIndex = 20;
            // 
            // dgvPayment
            // 
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Location = new Point(46, 282);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.Size = new Size(864, 150);
            dgvPayment.TabIndex = 21;
            // 
            // textStaffPos
            // 
            textStaffPos.Location = new Point(625, 145);
            textStaffPos.Margin = new Padding(2);
            textStaffPos.Name = "textStaffPos";
            textStaffPos.Size = new Size(203, 23);
            textStaffPos.TabIndex = 22;
            // 
            // textStaffLN
            // 
            textStaffLN.Location = new Point(625, 107);
            textStaffLN.Margin = new Padding(2);
            textStaffLN.Name = "textStaffLN";
            textStaffLN.Size = new Size(203, 23);
            textStaffLN.TabIndex = 23;
            // 
            // textStaffFN
            // 
            textStaffFN.Location = new Point(625, 68);
            textStaffFN.Margin = new Padding(2);
            textStaffFN.Name = "textStaffFN";
            textStaffFN.Size = new Size(203, 23);
            textStaffFN.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(454, 150);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 18);
            label7.TabIndex = 25;
            label7.Text = "StaffPosition";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(454, 107);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(139, 18);
            label8.TabIndex = 26;
            label8.Text = "StaffLastName";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(454, 70);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(140, 18);
            label9.TabIndex = 27;
            label9.Text = "StaffFirstName";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 453);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textStaffFN);
            Controls.Add(textStaffLN);
            Controls.Add(textStaffPos);
            Controls.Add(dgvPayment);
            Controls.Add(dtpPaymentDate);
            Controls.Add(btnLogout);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(textStaffID);
            Controls.Add(textTransportID);
            Controls.Add(textCustomerID);
            Controls.Add(textPaisAmount);
            Controls.Add(textPaymentID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textPaymentID;
        private TextBox textPaisAmount;
        private TextBox textCustomerID;
        private TextBox textTransportID;
        private TextBox textStaffID;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnLogout;
        private DateTimePicker dtpPaymentDate;
        private DataGridView dgvPayment;
        private TextBox textStaffPos;
        private TextBox textStaffLN;
        private TextBox textStaffFN;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}