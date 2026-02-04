namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmSanPham
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
            label4 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            dataGridView = new DataGridView();
            SPID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            LoaiSanPham = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            GiaNhap = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnSua = new Button();
            btnThem = new Button();
            txtTenSanPham = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtMoTa = new TextBox();
            label6 = new Label();
            txtDonViTinh = new TextBox();
            label5 = new Label();
            txtSoLuong = new TextBox();
            t = new Label();
            txtGiaNhap = new TextBox();
            label3 = new Label();
            txtDonGia = new TextBox();
            label2 = new Label();
            cboTenLoai = new ComboBox();
            cboLoaiSanPham = new Label();
            cboNhaCungCap = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 62);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 9;
            label4.Text = "Nhà cung cấp (*):";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ControlLight;
            btnThoat.Location = new Point(909, 201);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = SystemColors.ControlLight;
            btnHuyBo.Location = new Point(809, 201);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.ControlLight;
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(707, 201);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ControlLight;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(909, 165);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SPID, TenSanPham, LoaiSanPham, TenNhaCungCap, DonGia, GiaNhap, DonViTinh, MoTa });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1054, 251);
            dataGridView.TabIndex = 2;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // SPID
            // 
            SPID.DataPropertyName = "ID";
            SPID.HeaderText = "ID";
            SPID.MinimumWidth = 6;
            SPID.Name = "SPID";
            SPID.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // LoaiSanPham
            // 
            LoaiSanPham.HeaderText = "Loại sản phẩm";
            LoaiSanPham.MinimumWidth = 6;
            LoaiSanPham.Name = "LoaiSanPham";
            LoaiSanPham.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.HeaderText = "Tên nhà cung cấp";
            TenNhaCungCap.MinimumWidth = 6;
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // GiaNhap
            // 
            GiaNhap.DataPropertyName = "GiaNhap";
            GiaNhap.HeaderText = "Giá nhập";
            GiaNhap.MinimumWidth = 6;
            GiaNhap.Name = "GiaNhap";
            GiaNhap.ReadOnly = true;
            // 
            // DonViTinh
            // 
            DonViTinh.DataPropertyName = "DonViTinh";
            DonViTinh.HeaderText = "Đơn vị tính";
            DonViTinh.MinimumWidth = 6;
            DonViTinh.Name = "DonViTinh";
            DonViTinh.ReadOnly = true;
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Mô tả";
            MoTa.MinimumWidth = 6;
            MoTa.Name = "MoTa";
            MoTa.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(-11, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1060, 277);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ControlLight;
            btnSua.Location = new Point(808, 165);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ControlLight;
            btnThem.Location = new Point(708, 165);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(174, 22);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(829, 27);
            txtTenSanPham.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 29);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm (*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDonViTinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(t);
            groupBox1.Controls.Add(txtGiaNhap);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboTenLoai);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1040, 237);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(174, 166);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(326, 64);
            txtMoTa.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 166);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 21;
            label6.Text = "Mô tả:";
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Location = new Point(677, 124);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(326, 27);
            txtDonViTinh.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(556, 131);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 19;
            label5.Text = "Đơn vị tính (*):";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(174, 124);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(326, 27);
            txtSoLuong.TabIndex = 18;
            // 
            // t
            // 
            t.AutoSize = true;
            t.Location = new Point(66, 131);
            t.Name = "t";
            t.Size = new Size(92, 20);
            t.TabIndex = 17;
            t.Text = "Số lượng (*):";
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(677, 91);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(326, 27);
            txtGiaNhap.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(569, 98);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 15;
            label3.Text = "Giá nhập (*):";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(174, 91);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(326, 27);
            txtDonGia.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 98);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 13;
            label2.Text = "Đơn giá (*):";
            // 
            // cboTenLoai
            // 
            cboTenLoai.FormattingEnabled = true;
            cboTenLoai.Location = new Point(677, 55);
            cboTenLoai.Name = "cboTenLoai";
            cboTenLoai.Size = new Size(326, 28);
            cboTenLoai.TabIndex = 12;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.AutoSize = true;
            cboLoaiSanPham.Location = new Point(532, 58);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(128, 20);
            cboLoaiSanPham.TabIndex = 11;
            cboLoaiSanPham.Text = "Loại sản phẩm (*):";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(174, 55);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(326, 28);
            cboNhaCungCap.TabIndex = 10;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 566);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            Text = "Sản phẩm";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenSanPham;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cboTenLoai;
        private Label cboLoaiSanPham;
        private ComboBox cboNhaCungCap;
        private TextBox txtGiaNhap;
        private Label label3;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private Label t;
        private TextBox txtDonViTinh;
        private Label label5;
        private TextBox txtMoTa;
        private Label label6;
        private DataGridViewTextBoxColumn SPID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn LoaiSanPham;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn GiaNhap;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn MoTa;
    }
}