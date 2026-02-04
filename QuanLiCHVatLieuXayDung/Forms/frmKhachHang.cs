using Microsoft.EntityFrameworkCore;
using QuanLiCHVatLieuXayDung.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        bool xuLyThem = false;
        int idHienTai;

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void LoadData()
        {
            var list = context.KhachHang.ToList();
            dataGridView.DataSource = list;
        }

        public void BatTatChucNang(bool isEditing)
        {
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnHuyBo.Enabled = isEditing;
            btnLuu.Enabled = isEditing;

            txtTenKhachHang.Enabled = isEditing;
            txtSoDienThoai.Enabled = isEditing;
            txtDiaChi.Enabled = isEditing;
            txtLoaiKhach.Enabled = isEditing;
            txtTongNo.Enabled = isEditing;
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
            if (MessageBox.Show("Xác nhận xóa khách hàng?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var obj = context.KhachHang.Find(idHienTai);
                if (obj != null)
                {
                    context.KhachHang.Remove(obj);
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
                KhachHang kh = new KhachHang();
                kh.TenKhachHang = txtTenKhachHang.Text;
                kh.SoDienThoai = txtSoDienThoai.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.LoaiKhachHang = txtLoaiKhach.Text;
                kh.TongNo = decimal.TryParse(txtTongNo.Text, out decimal no) ? no : 0;

                context.KhachHang.Add(kh);
            }
            else
            {
                KhachHang kh = context.KhachHang.Find(idHienTai);
                if (kh != null)
                {
                    kh.TenKhachHang = txtTenKhachHang.Text;
                    kh.SoDienThoai = txtSoDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.LoaiKhachHang = txtLoaiKhach.Text;
                    kh.TongNo = decimal.TryParse(txtTongNo.Text, out decimal no) ? no : 0;

                    context.KhachHang.Update(kh);
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
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtLoaiKhach.Text = row.Cells["LoaiKhachHang"].Value?.ToString();
                txtTongNo.Text = row.Cells["TongNo"].Value?.ToString();
            }
        }

        private void ResetInput()
        {
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtLoaiKhach.Clear();
            txtTongNo.Text = "0";
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.");
                return false;
            }
            return true;
        }
    }
}