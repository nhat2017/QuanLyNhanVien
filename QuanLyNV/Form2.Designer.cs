namespace QuanLyNV
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtMapb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTpb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.maPhongBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quan_li_hoc_sinhDataSet4 = new QuanLyNV.Quan_li_hoc_sinhDataSet4();
            this.quan_li_hoc_sinhDataSet1 = new QuanLyNV.Quan_li_hoc_sinhDataSet1();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QuanLyNV.Quan_li_hoc_sinhDataSet1TableAdapters.NhanVienTableAdapter();
            this.quan_li_hoc_sinhDataSet3 = new QuanLyNV.Quan_li_hoc_sinhDataSet3();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phong_BanTableAdapter = new QuanLyNV.Quan_li_hoc_sinhDataSet3TableAdapters.Phong_BanTableAdapter();
            this.phong_BanTableAdapter1 = new QuanLyNV.Quan_li_hoc_sinhDataSet4TableAdapters.Phong_BanTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_li_hoc_sinhDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_li_hoc_sinhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_li_hoc_sinhDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnADD);
            this.groupBox2.Controls.Add(this.txtMapb);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTpb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(72, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(656, 394);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(436, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 38);
            this.button3.TabIndex = 23;
            this.button3.Text = "Sữa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 38);
            this.button2.TabIndex = 23;
            this.button2.Text = "Xóa ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnADD
            // 
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnADD.Location = new System.Drawing.Point(16, 286);
            this.btnADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(193, 38);
            this.btnADD.TabIndex = 23;
            this.btnADD.Text = "Thêm";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtMapb
            // 
            this.txtMapb.Location = new System.Drawing.Point(218, 173);
            this.txtMapb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMapb.Name = "txtMapb";
            this.txtMapb.Size = new System.Drawing.Size(367, 35);
            this.txtMapb.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tên Phòng Ban";
            // 
            // txtTpb
            // 
            this.txtTpb.Location = new System.Drawing.Point(218, 112);
            this.txtTpb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTpb.Name = "txtTpb";
            this.txtTpb.Size = new System.Drawing.Size(367, 35);
            this.txtTpb.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã  Phòng Ban";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.Location = new System.Drawing.Point(16, 433);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 38);
            this.button4.TabIndex = 14;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView10
            // 
            this.dataGridView10.AutoGenerateColumns = false;
            this.dataGridView10.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView10.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhongBanDataGridViewTextBoxColumn,
            this.TenPhongBan});
            this.dataGridView10.DataSource = this.phongBanBindingSource1;
            this.dataGridView10.Location = new System.Drawing.Point(119, 461);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.ReadOnly = true;
            this.dataGridView10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView10.RowHeadersWidth = 82;
            this.dataGridView10.RowTemplate.Height = 33;
            this.dataGridView10.Size = new System.Drawing.Size(529, 118);
            this.dataGridView10.TabIndex = 25;
            this.dataGridView10.TabStop = false;
            this.dataGridView10.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maPhongBanDataGridViewTextBoxColumn
            // 
            this.maPhongBanDataGridViewTextBoxColumn.DataPropertyName = "MaPhongBan";
            this.maPhongBanDataGridViewTextBoxColumn.HeaderText = "MaPhongBan";
            this.maPhongBanDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.maPhongBanDataGridViewTextBoxColumn.Name = "maPhongBanDataGridViewTextBoxColumn";
            this.maPhongBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TenPhongBan
            // 
            this.TenPhongBan.DataPropertyName = "TenPhongBan";
            this.TenPhongBan.HeaderText = "TenPhongBan";
            this.TenPhongBan.MinimumWidth = 10;
            this.TenPhongBan.Name = "TenPhongBan";
            this.TenPhongBan.ReadOnly = true;
            // 
            // phongBanBindingSource1
            // 
            this.phongBanBindingSource1.DataMember = "Phong_Ban";
            this.phongBanBindingSource1.DataSource = this.quan_li_hoc_sinhDataSet4;
            // 
            // quan_li_hoc_sinhDataSet4
            // 
            this.quan_li_hoc_sinhDataSet4.DataSetName = "Quan_li_hoc_sinhDataSet4";
            this.quan_li_hoc_sinhDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quan_li_hoc_sinhDataSet1
            // 
            this.quan_li_hoc_sinhDataSet1.DataSetName = "Quan_li_hoc_sinhDataSet1";
            this.quan_li_hoc_sinhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quan_li_hoc_sinhDataSet1;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // quan_li_hoc_sinhDataSet3
            // 
            this.quan_li_hoc_sinhDataSet3.DataSetName = "Quan_li_hoc_sinhDataSet3";
            this.quan_li_hoc_sinhDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "Phong_Ban";
            this.phongBanBindingSource.DataSource = this.quan_li_hoc_sinhDataSet3;
            // 
            // phong_BanTableAdapter
            // 
            this.phong_BanTableAdapter.ClearBeforeFill = true;
            // 
            // phong_BanTableAdapter1
            // 
            this.phong_BanTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1050, 790);
            this.Controls.Add(this.dataGridView10);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_li_hoc_sinhDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_li_hoc_sinhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_li_hoc_sinhDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txtMapb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTpb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView10;
        private Quan_li_hoc_sinhDataSet1 quan_li_hoc_sinhDataSet1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private Quan_li_hoc_sinhDataSet1TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongBanDataGridViewTextBoxColumn;
        private Quan_li_hoc_sinhDataSet3 quan_li_hoc_sinhDataSet3;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private Quan_li_hoc_sinhDataSet3TableAdapters.Phong_BanTableAdapter phong_BanTableAdapter;
        private Quan_li_hoc_sinhDataSet4 quan_li_hoc_sinhDataSet4;
        private System.Windows.Forms.BindingSource phongBanBindingSource1;
        private Quan_li_hoc_sinhDataSet4TableAdapters.Phong_BanTableAdapter phong_BanTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongBan;
    }
}