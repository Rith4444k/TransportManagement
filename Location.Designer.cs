namespace TransportManagement
{
    partial class Location
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtLocationID = new TextBox();
            txtLocationName = new TextBox();
            txtStartLocation = new TextBox();
            TargetLocation = new TextBox();
            txtDistance = new TextBox();
            btnAdd = new Button();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            dgvLocation = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLocation).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(822, 17);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 25);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(642, 17);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(176, 23);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 2;
            label1.Text = "LocationID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 66);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 18);
            label2.TabIndex = 3;
            label2.Text = "LocationName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 115);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 18);
            label3.TabIndex = 4;
            label3.Text = "StartLocation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 163);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 18);
            label4.TabIndex = 5;
            label4.Text = "TargetLocation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 210);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 18);
            label5.TabIndex = 6;
            label5.Text = "Distance";
            label5.Click += label5_Click;
            // 
            // txtLocationID
            // 
            txtLocationID.Location = new Point(203, 17);
            txtLocationID.Margin = new Padding(2);
            txtLocationID.Name = "txtLocationID";
            txtLocationID.Size = new Size(250, 23);
            txtLocationID.TabIndex = 7;
            // 
            // txtLocationName
            // 
            txtLocationName.Location = new Point(203, 66);
            txtLocationName.Margin = new Padding(2);
            txtLocationName.Name = "txtLocationName";
            txtLocationName.Size = new Size(250, 23);
            txtLocationName.TabIndex = 8;
            txtLocationName.TextChanged += txtLocationName_TextChanged;
            // 
            // txtStartLocation
            // 
            txtStartLocation.Location = new Point(203, 115);
            txtStartLocation.Margin = new Padding(2);
            txtStartLocation.Name = "txtStartLocation";
            txtStartLocation.Size = new Size(250, 23);
            txtStartLocation.TabIndex = 9;
            // 
            // TargetLocation
            // 
            TargetLocation.Location = new Point(203, 160);
            TargetLocation.Margin = new Padding(2);
            TargetLocation.Name = "TargetLocation";
            TargetLocation.Size = new Size(250, 23);
            TargetLocation.TabIndex = 10;
            TargetLocation.TextChanged += TargetLocation_TextChanged;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(203, 210);
            txtDistance.Margin = new Padding(2);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(250, 23);
            txtDistance.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(494, 210);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Lime;
            btnNew.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(576, 210);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(78, 29);
            btnNew.TabIndex = 13;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.RosyBrown;
            btnUpdate.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(658, 210);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(740, 210);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(822, 210);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(78, 29);
            btnLogout.TabIndex = 16;
            btnLogout.Text = "Back";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvLocation
            // 
            dgvLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocation.Location = new Point(66, 304);
            dgvLocation.Name = "dgvLocation";
            dgvLocation.Size = new Size(834, 214);
            dgvLocation.TabIndex = 17;
            // 
            // Location
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 533);
            Controls.Add(dgvLocation);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(btnAdd);
            Controls.Add(txtDistance);
            Controls.Add(TargetLocation);
            Controls.Add(txtStartLocation);
            Controls.Add(txtLocationName);
            Controls.Add(txtLocationID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Margin = new Padding(2);
            Name = "Location";
            Text = "Location";
            ((System.ComponentModel.ISupportInitialize)dgvLocation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtLocationID;
        private TextBox txtLocationName;
        private TextBox txtStartLocation;
        private TextBox TargetLocation;
        private TextBox txtDistance;
        private Button btnAdd;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLogout;
        private DataGridView dgvLocation;
    }
}