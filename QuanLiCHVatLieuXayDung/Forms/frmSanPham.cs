using Microsoft.EntityFrameworkCore;
using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        bool xuLyThem = false;
        int idSanPhamHienTai;

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadComboBoxData(); 
            LoadDataGrid(); 
        }

        private void LoadComboBoxData()
        {
            cboNhaCungCap.DataSource = context.NhaCungCap.ToList();
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "ID";

            cboTenLoai.DataSource = context.LoaiSanPham.ToList();
            cboTenLoai.DisplayMember = "TenLoaiSanPham";
            cboTenLoai.ValueMember = "ID";

            cboNhaCungCap.SelectedIndex = -1;
            cboTenLoai.SelectedIndex = -1;
        }

        private void LoadDataGrid()
        {
            var listSP = context.SanPham
                                .Where(s => s.DaXoa == false)
                                .Include(s => s.NhaCungCap)
                                .Include(s => s.LoaiSanPham)
                                .ToList();

            dataGridView.DataSource = listSP;
        }

        public void BatTatChucNang(bool isEditing)
        {
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;

            btnLuu.Enabled = isEditing;
            btnHuyBo.Enabled = isEditing;

            txtTenSanPham.Enabled = isEditing;
            cboNhaCungCap.Enabled = isEditing;
            cboTenLoai.Enabled = isEditing;
            txtDonGia.Enabled = isEditing;
            txtGiaNhap.Enabled = isEditing;
            txtSoLuong.Enabled = isEditing;
            txtDonViTinh.Enabled = isEditing;
            txtMoTa.Enabled = isEditing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            ResetInput(); 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idSanPhamHienTai == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var sp = context.SanPham.Find(idSanPhamHienTai);
                if (sp != null)
                {
                    sp.DaXoa = true;
                    context.SanPham.Update(sp);
                    context.SaveChanges();

                    MessageBox.Show("Đã xóa thành công!");
                    NhatKyHeThong.GhiNhatKy("Xóa", "SanPham", $"Xóa sản phẩm ID: {idSanPhamHienTai}");
                    LoadDataGrid(); 
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var spTrung = context.SanPham
                .FirstOrDefault(s => s.TenSanPham.ToLower() == txtTenSanPham.Text.Trim().ToLower());
            if (xuLyThem)
            {
                if (spTrung != null)
                {
                    if (spTrung.DaXoa == false)
                    {
                        MessageBox.Show("Tên sản phẩm này đã tồn tại! Vui lòng chọn tên khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show(
                            "Sản phẩm này đã từng tồn tại nhưng đang bị xóa.\nBạn có muốn KHÔI PHỤC lại sản phẩm này không?",
                            "Phát hiện trùng lặp",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            spTrung.DaXoa = false;
                            GanDuLieuVaoObject(spTrung);
                            context.SanPham.Update(spTrung);
                            context.SaveChanges();

                            MessageBox.Show("Đã khôi phục sản phẩm thành công!");
                            LoadDataGrid();
                            ResetInput();
                            BatTatChucNang(false);
                            return; 
                        }
                        else
                        {
                            return; 
                        }
                    }
                }

                SanPham sp = new SanPham();
                GanDuLieuVaoObject(sp);
                sp.DaXoa = false;
                context.SanPham.Add(sp);
                NhatKyHeThong.GhiNhatKy("Thêm mới", "SanPham", $"Thêm sản phẩm: {txtTenSanPham.Text}");
            }
            else
            {
                if (spTrung != null && spTrung.ID != idSanPhamHienTai)
                {
                    MessageBox.Show("Tên sản phẩm mới trùng với một sản phẩm khác!", "Cảnh báo");
                    return;
                }

                SanPham sp = context.SanPham.Find(idSanPhamHienTai);
                if (sp != null)
                {
                    GanDuLieuVaoObject(sp);
                    context.SanPham.Update(sp);
                    NhatKyHeThong.GhiNhatKy("Cập nhật", "SanPham", $"Cập nhật sản phẩm ID: {idSanPhamHienTai}");
                }
            }
            try
            {
                context.SaveChanges();
                MessageBox.Show("Lưu thành công!");
                frmSanPham_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            if (dataGridView.CurrentRow != null)
            {
                dataGridView_CellClick(sender, new DataGridViewCellEventArgs(0, dataGridView.CurrentRow.Index));
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                idSanPhamHienTai = Convert.ToInt32(row.Cells["SPID"].Value);

                txtTenSanPham.Text = row.Cells["TenSanPham"].Value?.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();
                txtGiaNhap.Text = row.Cells["GiaNhap"].Value?.ToString();
                txtSoLuong.Text = row.Cells["DonViTinh"].Value?.ToString();
                txtDonViTinh.Text = row.Cells["DonViTinh"].Value?.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();

                var sp = context.SanPham.Find(idSanPhamHienTai);
                if (sp != null)
                {
                    cboNhaCungCap.SelectedValue = sp.NhaCungCapID;
                    cboTenLoai.SelectedValue = sp.LoaiSanPhamID;
                    txtSoLuong.Text = sp.SoLuong.ToString(); 
                }
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "TenNhaCungCap")
            {
                var sp = dataGridView.Rows[e.RowIndex].DataBoundItem as SanPham;
                if (sp != null && sp.NhaCungCap != null)
                {
                    e.Value = sp.NhaCungCap.TenNhaCungCap;
                }
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "LoaiSanPham")
            {
                var sp = dataGridView.Rows[e.RowIndex].DataBoundItem as SanPham;
                if (sp != null && sp.LoaiSanPham != null)
                {
                    e.Value = sp.LoaiSanPham.TenLoai;
                }
            }
        }

        private void ResetInput()
        {
            txtTenSanPham.Clear();
            txtDonGia.Clear();
            txtGiaNhap.Clear();
            txtSoLuong.Clear();
            txtDonViTinh.Clear();
            txtMoTa.Clear();
            cboNhaCungCap.SelectedIndex = -1;
            cboTenLoai.SelectedIndex = -1;
            txtTenSanPham.Focus();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm."); return false;
            }
            if (cboNhaCungCap.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp."); return false;
            }
            if (cboTenLoai.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Loại sản phẩm."); return false;
            }
            if (!int.TryParse(txtDonGia.Text, out _) || !int.TryParse(txtGiaNhap.Text, out _))
            {
                MessageBox.Show("Giá phải là số."); return false;
            }
            return true;
        }

        private void GanDuLieuVaoObject(SanPham sp)
        {
            sp.TenSanPham = txtTenSanPham.Text;
            sp.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue);
            sp.LoaiSanPhamID = Convert.ToInt32(cboTenLoai.SelectedValue);
            sp.DonGia = int.Parse(txtDonGia.Text);
            sp.GiaNhap = int.Parse(txtGiaNhap.Text);
            sp.SoLuong = int.TryParse(txtSoLuong.Text, out int sl) ? sl : 0;
            sp.DonViTinh = txtDonViTinh.Text;
            sp.MoTa = txtMoTa.Text;
        }
    }
}