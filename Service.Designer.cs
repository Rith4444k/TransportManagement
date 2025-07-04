namespace TransportManagement
{
    partial class Service
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
            textServiceNo = new TextBox();
            textServiceType = new TextBox();
            textTransportID = new TextBox();
            textCustomerID = new TextBox();
            btnAdd = new Button();
            btnNew = new Button();
            btnUpdate = new Button();
            btnLogout = new Button();
            dgvService = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvService).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 18);
            label1.TabIndex = 0;
            label1.Text = "ServiceNo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 146);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 18);
            label2.TabIndex = 1;
            label2.Text = "CustomerID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 71);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 2;
            label3.Text = "ServiceType";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 112);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 18);
            label4.TabIndex = 3;
            label4.Text = "TransportID";
            // 
            // textServiceNo
            // 
            textServiceNo.Location = new Point(173, 34);
            textServiceNo.Margin = new Padding(2);
            textServiceNo.Name = "textServiceNo";
            textServiceNo.Size = new Size(196, 23);
            textServiceNo.TabIndex = 4;
            // 
            // textServiceType
            // 
            textServiceType.Location = new Point(173, 71);
            textServiceType.Margin = new Padding(2);
            textServiceType.Name = "textServiceType";
            textServiceType.Size = new Size(196, 23);
            textServiceType.TabIndex = 5;
            // 
            // textTransportID
            // 
            textTransportID.Location = new Point(173, 107);
            textTransportID.Margin = new Padding(2);
            textTransportID.Name = "textTransportID";
            textTransportID.Size = new Size(196, 23);
            textTransportID.TabIndex = 6;
            // 
            // textCustomerID
            // 
            textCustomerID.Location = new Point(173, 146);
            textCustomerID.Margin = new Padding(2);
            textCustomerID.Name = "textCustomerID";
            textCustomerID.Size = new Size(196, 23);
            textCustomerID.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(479, 188);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 30);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(561, 188);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(78, 30);
            btnNew.TabIndex = 9;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(643, 188);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 30);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(725, 188);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(78, 30);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Back";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button5_Click;
            // 
            // dgvService
            // 
            dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvService.Location = new Point(39, 246);
            dgvService.Name = "dgvService";
            dgvService.Size = new Size(764, 162);
            dgvService.TabIndex = 13;
            // 
            // Service
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 420);
            Controls.Add(dgvService);
            Controls.Add(btnLogout);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(btnAdd);
            Controls.Add(textCustomerID);
            Controls.Add(textTransportID);
            Controls.Add(textServiceType);
            Controls.Add(textServiceNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Service";
            Text = "Service";
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textServiceNo;
        private TextBox textServiceType;
        private TextBox textTransportID;
        private TextBox textCustomerID;
        private Button btnAdd;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnLogout;
        private DataGridView dgvService;
    }
}