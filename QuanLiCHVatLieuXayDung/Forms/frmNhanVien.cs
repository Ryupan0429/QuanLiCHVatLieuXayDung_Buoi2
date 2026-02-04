using Microsoft.EntityFrameworkCore;
using QuanLiCHVatLieuXayDung.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        bool xuLyThem = false;
        int idHienTai;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.DataSource = context.NhanVien.ToList();
        }

        public void BatTatChucNang(bool isEditing)
        {
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnHuyBo.Enabled = isEditing;
            btnLuu.Enabled = isEditing;

            txtHoTen.Enabled = isEditing;
            txtDienThoai.Enabled = isEditing;
            txtDiaChi.Enabled = isEditing;
            txtTenDangNhap.Enabled = isEditing;
            txtMatKhau.Enabled = isEditing;
            chkQuyenHan.Enabled = isEditing;
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
            if (MessageBox.Show("Xác nhận xóa nhân viên?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var obj = context.NhanVien.Find(idHienTai);
                if (obj != null)
                {
                    context.NhanVien.Remove(obj);
                    context.SaveChanges();
                    LoadData();
                    ResetInput();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (xuLyThem)
            {
                NhanVien nv = new NhanVien();
                nv.HoVaTen = txtHoTen.Text;
                nv.DienThoai = txtDienThoai.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.TenDangNhap = txtTenDangNhap.Text;
                nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                nv.QuyenHan = chkQuyenHan.Checked;
                context.NhanVien.Add(nv);
            }
            else
            {
                NhanVien nv = context.NhanVien.Find(idHienTai);
                if (nv != null)
                {
                    nv.HoVaTen = txtHoTen.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    if (string.IsNullOrEmpty(txtMatKhau.Text))
                        context.Entry(nv).Property(x => x.MatKhau).IsModified = false;
                    else
                        nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                    nv.QuyenHan = chkQuyenHan.Checked;
                    context.NhanVien.Update(nv);
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
            if (MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                idHienTai = Convert.ToInt32(row.Cells["ID"].Value);
                txtHoTen.Text = row.Cells["HoVaTen"].Value?.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value?.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();
                chkQuyenHan.Checked = Convert.ToBoolean(row.Cells["QuyenHan"].Value);
            }
        }

        private void ResetInput()
        {
            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            chkQuyenHan.Checked = false;
        }

        private bool ValidateInput()
        {
            // validate từng input
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ và tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Tên đăng nhập không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if( xuLyThem && string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống khi thêm mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}