namespace TransportManagement
{
    partial class Invoice
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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textInNo = new TextBox();
            textInDate = new TextBox();
            textTotalAm = new TextBox();
            textPaidAm = new TextBox();
            textCusID = new TextBox();
            textStaID = new TextBox();
            textFN = new TextBox();
            textLN = new TextBox();
            textPos = new TextBox();
            textSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            dgvInvoice = new DataGridView();
            textTranID = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 18);
            label1.TabIndex = 0;
            label1.Text = "InvoiceNo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 18);
            label2.TabIndex = 1;
            label2.Text = "InvoiceDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 93);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 18);
            label3.TabIndex = 2;
            label3.Text = "TotalAmount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 135);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 18);
            label4.TabIndex = 3;
            label4.Text = "PaidAmount";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 171);
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
            label6.Location = new Point(482, 93);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 18);
            label6.TabIndex = 5;
            label6.Text = "StaffFirstName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(482, 59);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 18);
            label7.TabIndex = 6;
            label7.Text = "StaffID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(52, 213);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(117, 18);
            label8.TabIndex = 7;
            label8.Text = "TransportID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(482, 138);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(139, 18);
            label9.TabIndex = 8;
            label9.Text = "StaffLastName";
            // 
            // textInNo
            // 
            textInNo.Location = new Point(181, 18);
            textInNo.Margin = new Padding(2);
            textInNo.Name = "textInNo";
            textInNo.Size = new Size(181, 23);
            textInNo.TabIndex = 9;
            // 
            // textInDate
            // 
            textInDate.Location = new Point(181, 54);
            textInDate.Margin = new Padding(2);
            textInDate.Name = "textInDate";
            textInDate.Size = new Size(181, 23);
            textInDate.TabIndex = 10;
            // 
            // textTotalAm
            // 
            textTotalAm.Location = new Point(181, 93);
            textTotalAm.Margin = new Padding(2);
            textTotalAm.Name = "textTotalAm";
            textTotalAm.Size = new Size(181, 23);
            textTotalAm.TabIndex = 11;
            // 
            // textPaidAm
            // 
            textPaidAm.Location = new Point(181, 133);
            textPaidAm.Margin = new Padding(2);
            textPaidAm.Name = "textPaidAm";
            textPaidAm.Size = new Size(181, 23);
            textPaidAm.TabIndex = 12;
            // 
            // textCusID
            // 
            textCusID.Location = new Point(181, 171);
            textCusID.Margin = new Padding(2);
            textCusID.Name = "textCusID";
            textCusID.Size = new Size(181, 23);
            textCusID.TabIndex = 13;
            // 
            // textStaID
            // 
            textStaID.Location = new Point(628, 54);
            textStaID.Margin = new Padding(2);
            textStaID.Name = "textStaID";
            textStaID.Size = new Size(181, 23);
            textStaID.TabIndex = 14;
            // 
            // textFN
            // 
            textFN.Location = new Point(627, 93);
            textFN.Margin = new Padding(2);
            textFN.Name = "textFN";
            textFN.Size = new Size(181, 23);
            textFN.TabIndex = 15;
            // 
            // textLN
            // 
            textLN.Location = new Point(627, 135);
            textLN.Margin = new Padding(2);
            textLN.Name = "textLN";
            textLN.Size = new Size(181, 23);
            textLN.TabIndex = 16;
            // 
            // textPos
            // 
            textPos.Location = new Point(627, 170);
            textPos.Margin = new Padding(2);
            textPos.Name = "textPos";
            textPos.Size = new Size(181, 23);
            textPos.TabIndex = 17;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(627, 17);
            textSearch.Margin = new Padding(2);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(181, 23);
            textSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(834, 16);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 24);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(421, 224);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 36);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(524, 224);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(78, 36);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(628, 224);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 36);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(730, 224);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 36);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(834, 224);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(78, 36);
            btnLogout.TabIndex = 24;
            btnLogout.Text = "Back";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvInvoice
            // 
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.Location = new Point(55, 277);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.Size = new Size(857, 220);
            dgvInvoice.TabIndex = 25;
            dgvInvoice.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textTranID
            // 
            textTranID.Location = new Point(181, 208);
            textTranID.Margin = new Padding(2);
            textTranID.Name = "textTranID";
            textTranID.Size = new Size(181, 23);
            textTranID.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(482, 176);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(120, 18);
            label10.TabIndex = 27;
            label10.Text = "StaffPosition";
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 509);
            Controls.Add(label10);
            Controls.Add(textTranID);
            Controls.Add(dgvInvoice);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(textSearch);
            Controls.Add(textPos);
            Controls.Add(textLN);
            Controls.Add(textFN);
            Controls.Add(textStaID);
            Controls.Add(textCusID);
            Controls.Add(textPaidAm);
            Controls.Add(textTotalAm);
            Controls.Add(textInDate);
            Controls.Add(textInNo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Invoice";
            Text = "Invoice";
            Load += Invoice_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
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
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textInNo;
        private TextBox textInDate;
        private TextBox textTotalAm;
        private TextBox textPaidAm;
        private TextBox textCusID;
        private TextBox textStaID;
        private TextBox textFN;
        private TextBox textLN;
        private TextBox textPos;
        private TextBox textSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLogout;
        private DataGridView dgvInvoice;
        private TextBox textTranID;
        private Label label10;
    }
}