using Microsoft.EntityFrameworkCore;
using QuanLiCHVatLieuXayDung.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        bool xuLyThem = false;
        int idHienTai;

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadComboBox();
            LoadData();
        }

        private void LoadComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.DisplayMember = "TenKhachHang";
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.SelectedIndex = -1;

            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.SelectedIndex = -1;
        }

        private void LoadData()
        {
            var list = context.HoaDon
                              .Include(h => h.KhachHang)
                              .Include(h => h.NhanVien)
                              .ToList();
            dataGridView.DataSource = list;
        }

        public void BatTatChucNang(bool isEditing)
        {
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;
            btnHuyBo.Enabled = isEditing;

            cboKhachHang.Enabled = isEditing;
            cboNhanVien.Enabled = isEditing;
            dtpNgayLap.Enabled = isEditing;
            txtGhiChu.Enabled = isEditing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            ResetInput();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idHienTai == 0) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (idHienTai == 0) return;
            if (MessageBox.Show("Xác nhận xóa hóa đơn này?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var obj = context.HoaDon.Find(idHienTai);
                if (obj != null)
                {
                    context.HoaDon.Remove(obj);
                    context.SaveChanges();
                    LoadData();
                    ResetInput();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedIndex < 0 || cboNhanVien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng và nhân viên.");
                return;
            }

            if (xuLyThem)
            {
                HoaDon hd = new HoaDon();
                hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                hd.NgayLap = dtpNgayLap.Value;
                hd.GhiChuHoaDon = txtGhiChu.Text;
                context.HoaDon.Add(hd);
            }
            else
            {
                HoaDon hd = context.HoaDon.Find(idHienTai);
                if (hd != null)
                {
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                    hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                    hd.NgayLap = dtpNgayLap.Value;
                    hd.GhiChuHoaDon = txtGhiChu.Text;
                    context.HoaDon.Update(hd);
                }
            }
            context.SaveChanges();
            LoadData();
            BatTatChucNang(false);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                idHienTai = Convert.ToInt32(row.Cells["HDID"].Value);

                // Lưu ý: Dùng try-catch hoặc check null nếu dữ liệu trên grid chưa load xong
                var hd = context.HoaDon.Find(idHienTai);
                if (hd != null)
                {
                    cboKhachHang.SelectedValue = hd.KhachHangID;
                    cboNhanVien.SelectedValue = hd.NhanVienID;
                    dtpNgayLap.Value = hd.NgayLap;
                    txtGhiChu.Text = hd.GhiChuHoaDon;
                }
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "KhachHang")
            {
                var item = dataGridView.Rows[e.RowIndex].DataBoundItem as HoaDon;
                if (item != null && item.KhachHang != null)
                    e.Value = item.KhachHang.TenKhachHang;
            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "NhanVien")
            {
                var item = dataGridView.Rows[e.RowIndex].DataBoundItem as HoaDon;
                if (item != null && item.NhanVien != null)
                    e.Value = item.NhanVien.HoVaTen;
            }
        }

        private void ResetInput()
        {
            cboKhachHang.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            txtGhiChu.Clear();
            dtpNgayLap.Value = DateTime.Now;
        }
    }
}