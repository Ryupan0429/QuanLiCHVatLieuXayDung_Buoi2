namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dtpNgayLap = new DateTimePicker();
            cboNhanVien = new ComboBox();
            cboKhachHang = new ComboBox();
            txtGhiChu = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            HDID = new DataGridViewTextBoxColumn();
            KhachHang = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(dtpNgayLap);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(820, 200);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Short;
            dtpNgayLap.Location = new Point(130, 67);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(200, 27);
            dtpNgayLap.TabIndex = 0;
            // 
            // cboNhanVien
            // 
            cboNhanVien.Location = new Point(550, 27);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(250, 28);
            cboNhanVien.TabIndex = 1;
            // 
            // cboKhachHang
            // 
            cboKhachHang.Location = new Point(130, 27);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(250, 28);
            cboKhachHang.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(550, 67);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(250, 27);
            txtGhiChu.TabIndex = 3;
            // 
            // label4
            // 
            label4.Location = new Point(450, 70);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 4;
            label4.Text = "Ghi chú:";
            // 
            // label3
            // 
            label3.Location = new Point(30, 70);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 5;
            label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            label2.Location = new Point(450, 30);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 6;
            label2.Text = "Nhân viên:";
            // 
            // label1
            // 
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 7;
            label1.Text = "Khách hàng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(820, 400);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { HDID, KhachHang, NhanVien, NgayLap, GhiChu });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(814, 374);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ControlLight;
            btnThoat.Location = new Point(708, 140);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = SystemColors.ControlLight;
            btnHuyBo.Location = new Point(608, 140);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 10;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.ControlLight;
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(506, 140);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ControlLight;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(406, 140);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ControlLight;
            btnSua.Location = new Point(305, 140);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ControlLight;
            btnThem.Location = new Point(205, 140);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // HDID
            // 
            HDID.DataPropertyName = "ID";
            HDID.HeaderText = "ID";
            HDID.MinimumWidth = 6;
            HDID.Name = "HDID";
            HDID.ReadOnly = true;
            // 
            // KhachHang
            // 
            KhachHang.DataPropertyName = "KhachHang";
            KhachHang.HeaderText = "Khách hàng";
            KhachHang.MinimumWidth = 6;
            KhachHang.Name = "KhachHang";
            KhachHang.ReadOnly = true;
            // 
            // NhanVien
            // 
            NhanVien.DataPropertyName = "NhanVien";
            NhanVien.HeaderText = "Nhân viên";
            NhanVien.MinimumWidth = 6;
            NhanVien.Name = "NhanVien";
            NhanVien.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChuHoaDon";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            GhiChu.ReadOnly = true;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 600);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmHoaDon";
            Text = "Hóa đơn";
            Load += frmHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4, label3, label2, label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn HDID;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn GhiChu;
    }
}