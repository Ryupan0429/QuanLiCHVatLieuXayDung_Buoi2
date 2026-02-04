namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmPhieuNhap
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
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTongTien = new TextBox();
            label5 = new Label();
            dtpNgayNhap = new DateTimePicker();
            cboNhanVien = new ComboBox();
            cboNhaCungCap = new ComboBox();
            txtGhiChu = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            PNID = new DataGridViewTextBoxColumn();
            NhaCungCap = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
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
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpNgayNhap);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(820, 240);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ControlLight;
            btnThoat.Location = new Point(706, 175);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = SystemColors.ControlLight;
            btnHuyBo.Location = new Point(606, 175);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 14;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.ControlLight;
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(506, 175);
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
            btnXoa.Location = new Point(406, 175);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ControlLight;
            btnSua.Location = new Point(306, 175);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ControlLight;
            btnThem.Location = new Point(206, 175);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(130, 107);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(250, 27);
            txtTongTien.TabIndex = 0;
            txtTongTien.Text = "0";
            // 
            // label5
            // 
            label5.Location = new Point(30, 110);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 1;
            label5.Text = "Tổng tiền:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(130, 67);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(200, 27);
            dtpNgayNhap.TabIndex = 2;
            // 
            // cboNhanVien
            // 
            cboNhanVien.Location = new Point(550, 27);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(250, 28);
            cboNhanVien.TabIndex = 3;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.Location = new Point(130, 27);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(250, 28);
            cboNhaCungCap.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(550, 67);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(250, 27);
            txtGhiChu.TabIndex = 5;
            // 
            // label4
            // 
            label4.Location = new Point(450, 70);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 6;
            label4.Text = "Ghi chú:";
            // 
            // label3
            // 
            label3.Location = new Point(30, 70);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 7;
            label3.Text = "Ngày nhập:";
            // 
            // label2
            // 
            label2.Location = new Point(450, 30);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 8;
            label2.Text = "Nhân viên:";
            // 
            // label1
            // 
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 9;
            label1.Text = "Nhà cung cấp:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(820, 360);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phiếu nhập";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { PNID, NhaCungCap, NhanVien, NgayNhap, TongTien, GhiChu });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(814, 334);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // PNID
            // 
            PNID.DataPropertyName = "ID";
            PNID.HeaderText = "ID";
            PNID.MinimumWidth = 6;
            PNID.Name = "PNID";
            PNID.ReadOnly = true;
            // 
            // NhaCungCap
            // 
            NhaCungCap.DataPropertyName = "NhaCungCap";
            NhaCungCap.HeaderText = "Nhà cung cấp";
            NhaCungCap.MinimumWidth = 6;
            NhaCungCap.Name = "NhaCungCap";
            NhaCungCap.ReadOnly = true;
            // 
            // NhanVien
            // 
            NhanVien.DataPropertyName = "NhanVien";
            NhanVien.HeaderText = "Nhân viên";
            NhanVien.MinimumWidth = 6;
            NhanVien.Name = "NhanVien";
            NhanVien.ReadOnly = true;
            // 
            // NgayNhap
            // 
            NgayNhap.DataPropertyName = "NgayNhap";
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            GhiChu.ReadOnly = true;
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 600);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmPhieuNhap";
            Text = "Phiếu nhập";
            Load += frmPhieuNhap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.ComboBox cboNhanVien, cboNhaCungCap;
        private System.Windows.Forms.TextBox txtGhiChu, txtTongTien;
        private System.Windows.Forms.Label label5, label4, label3, label2, label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn PNID;
        private DataGridViewTextBoxColumn NhaCungCap;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn GhiChu;
    }
}