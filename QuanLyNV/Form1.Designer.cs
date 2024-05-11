namespace QuanLyNV
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.cboMa = new System.Windows.Forms.ComboBox();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quan_li_hoc_sinhDataSet2 = new QuanLyNV.Quan_li_hoc_sinhDataSet2();
            this.cbogt = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtque = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtDc = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhongBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quan_li_hoc_sinhDataSet1 = new QuanLyNV.Quan_li_hoc_sinhDataSet1();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quan_li_hoc_sinhDataSet = new QuanLyNV.Quan_li_hoc_sinhDataSet();
            this.nhanVienTableAdapter = new QuanLyNV.Quan_li_hoc_sinhDataSetTableAdapters.NhanVienTableAdapter();
            this.quanlihocsinhDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter1 = new QuanLyNV.Quan_li_hoc_sinhDataSet1TableAdapters.NhanVienTableAdapter();
            this.nhanVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.phong_BanTableAdapter = new QuanLyNV.Quan_li_hoc_sinhDataSet2TableAdapters.Phong_BanTableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_li_hoc_sinhDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_li_hoc_sinhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_li_hoc_sinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlihocsinhDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.DELETE);
            this.groupBox1.Controls.Add(this.cboMa);
            this.groupBox1.Controls.Add(this.cbogt);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtque);
            this.groupBox1.Controls.Add(this.txtluong);
            this.groupBox1.Controls.Add(this.txtDc);
            this.groupBox1.Controls.Add(this.txtTennv);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(748, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(703, 493);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(495, 433);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(186, 38);
            this.btnsua.TabIndex = 22;
            this.btnsua.Text = "Sữa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(251, 433);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(192, 38);
            this.DELETE.TabIndex = 21;
            this.DELETE.Text = "Xóa ";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // cboMa
            // 
            this.cboMa.AllowDrop = true;
            this.cboMa.DataSource = this.phongBanBindingSource;
            this.cboMa.DisplayMember = "MaPhongBan";
            this.cboMa.FormattingEnabled = true;
            this.cboMa.Location = new System.Drawing.Point(223, 367);
            this.cboMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMa.Name = "cboMa";
            this.cboMa.Size = new System.Drawing.Size(121, 37);
            this.cboMa.TabIndex = 19;
            this.cboMa.ValueMember = "MaPhongBan";
            this.cboMa.SelectedIndexChanged += new System.EventHandler(this.cboMa_SelectedIndexChanged);
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "Phong_Ban";
            this.phongBanBindingSource.DataSource = this.quan_li_hoc_sinhDataSet2;
            // 
            // quan_li_hoc_sinhDataSet2
            // 
            this.quan_li_hoc_sinhDataSet2.DataSetName = "Quan_li_hoc_sinhDataSet2";
            this.quan_li_hoc_sinhDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbogt
            // 
            this.cbogt.FormattingEnabled = true;
            this.cbogt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbogt.Location = new System.Drawing.Point(223, 185);
            this.cbogt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbogt.Name = "cbogt";
            this.cbogt.Size = new System.Drawing.Size(121, 37);
            this.cbogt.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.Location = new System.Drawing.Point(16, 433);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 38);
            this.button2.TabIndex = 14;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtque
            // 
            this.txtque.Location = new System.Drawing.Point(223, 306);
            this.txtque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtque.Name = "txtque";
            this.txtque.Size = new System.Drawing.Size(326, 35);
            this.txtque.TabIndex = 9;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(223, 247);
            this.txtluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(326, 35);
            this.txtluong.TabIndex = 8;
            // 
            // txtDc
            // 
            this.txtDc.Location = new System.Drawing.Point(223, 126);
            this.txtDc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDc.Name = "txtDc";
            this.txtDc.Size = new System.Drawing.Size(326, 35);
            this.txtDc.TabIndex = 6;
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(223, 72);
            this.txtTennv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(326, 35);
            this.txtTennv.TabIndex = 5;
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(223, 14);
            this.txtManv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(326, 35);
            this.txtManv.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quê Quán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Phòng Ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.gTDataGridViewTextBoxColumn,
            this.luongDataGridViewTextBoxColumn,
            this.queQuanDataGridViewTextBoxColumn,
            this.maPhongBanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhanVienBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(3, 517);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1414, 444);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Diachi";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            this.diachiDataGridViewTextBoxColumn.Width = 200;
            // 
            // gTDataGridViewTextBoxColumn
            // 
            this.gTDataGridViewTextBoxColumn.DataPropertyName = "GT";
            this.gTDataGridViewTextBoxColumn.HeaderText = "GT";
            this.gTDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.gTDataGridViewTextBoxColumn.Name = "gTDataGridViewTextBoxColumn";
            this.gTDataGridViewTextBoxColumn.Width = 200;
            // 
            // luongDataGridViewTextBoxColumn
            // 
            this.luongDataGridViewTextBoxColumn.DataPropertyName = "Luong";
            this.luongDataGridViewTextBoxColumn.HeaderText = "Luong";
            this.luongDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.luongDataGridViewTextBoxColumn.Name = "luongDataGridViewTextBoxColumn";
            this.luongDataGridViewTextBoxColumn.Width = 200;
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            this.queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.HeaderText = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
            this.queQuanDataGridViewTextBoxColumn.Width = 200;
            // 
            // maPhongBanDataGridViewTextBoxColumn
            // 
            this.maPhongBanDataGridViewTextBoxColumn.DataPropertyName = "MaPhongBan";
            this.maPhongBanDataGridViewTextBoxColumn.HeaderText = "MaPhongBan";
            this.maPhongBanDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.maPhongBanDataGridViewTextBoxColumn.Name = "maPhongBanDataGridViewTextBoxColumn";
            this.maPhongBanDataGridViewTextBoxColumn.Width = 200;
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this.quan_li_hoc_sinhDataSet1;
            // 
            // quan_li_hoc_sinhDataSet1
            // 
            this.quan_li_hoc_sinhDataSet1.DataSetName = "Quan_li_hoc_sinhDataSet1";
            this.quan_li_hoc_sinhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quan_li_hoc_sinhDataSet;
            // 
            // quan_li_hoc_sinhDataSet
            // 
            this.quan_li_hoc_sinhDataSet.DataSetName = "Quan_li_hoc_sinhDataSet";
            this.quan_li_hoc_sinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // quanlihocsinhDataSetBindingSource
            // 
            this.quanlihocsinhDataSetBindingSource.DataSource = this.quan_li_hoc_sinhDataSet;
            this.quanlihocsinhDataSetBindingSource.Position = 0;
            // 
            // nhanVienTableAdapter1
            // 
            this.nhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // nhanVienBindingSource2
            // 
            this.nhanVienBindingSource2.DataMember = "NhanVien";
            this.nhanVienBindingSource2.DataSource = this.quanlihocsinhDataSetBindingSource;
            // 
            // phong_BanTableAdapter
            // 
            this.phong_BanTableAdapter.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.Location = new System.Drawing.Point(3, -11);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1658, 1188);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 47);
            this.button1.TabIndex = 14;
            this.button1.Text = "Chỉnh bảng phòng ban";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 1189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BẢNG QUẢN LÍ NHÂN VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_li_hoc_sinhDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_li_hoc_sinhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_li_hoc_sinhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlihocsinhDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtque;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtDc;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Quan_li_hoc_sinhDataSet quan_li_hoc_sinhDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private Quan_li_hoc_sinhDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource quanlihocsinhDataSetBindingSource;
        private Quan_li_hoc_sinhDataSet1 quan_li_hoc_sinhDataSet1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private Quan_li_hoc_sinhDataSet1TableAdapters.NhanVienTableAdapter nhanVienTableAdapter1;
        private System.Windows.Forms.ComboBox cboMa;
        private System.Windows.Forms.ComboBox cbogt;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.BindingSource nhanVienBindingSource2;
        private Quan_li_hoc_sinhDataSet2 quan_li_hoc_sinhDataSet2;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private Quan_li_hoc_sinhDataSet2TableAdapters.Phong_BanTableAdapter phong_BanTableAdapter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
    }
}

