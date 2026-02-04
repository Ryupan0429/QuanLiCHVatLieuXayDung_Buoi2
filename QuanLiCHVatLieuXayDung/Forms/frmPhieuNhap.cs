using Microsoft.EntityFrameworkCore;
using QuanLiCHVatLieuXayDung.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        bool xuLyThem = false;
        int idHienTai;

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadComboBox();
            LoadData();
        }

        private void LoadComboBox()
        {
            cboNhaCungCap.DataSource = context.NhaCungCap.ToList();
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "ID";
            cboNhaCungCap.SelectedIndex = -1;

            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.SelectedIndex = -1;
        }

        private void LoadData()
        {
            var list = context.PhieuNhap
                              .Include(p => p.NhaCungCap)
                              .Include(p => p.NhanVien)
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

            cboNhaCungCap.Enabled = isEditing;
            cboNhanVien.Enabled = isEditing;
            dtpNgayNhap.Enabled = isEditing;
            txtGhiChu.Enabled = isEditing;
            txtTongTien.Enabled = isEditing;
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
            if (MessageBox.Show("Xác nhận xóa phiếu nhập?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var obj = context.PhieuNhap.Find(idHienTai);
                if (obj != null)
                {
                    context.PhieuNhap.Remove(obj);
                    context.SaveChanges();
                    LoadData();
                    ResetInput();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNhaCungCap.SelectedIndex < 0 || cboNhanVien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp và nhân viên."); return;
            }

            if (xuLyThem)
            {
                PhieuNhap pn = new PhieuNhap();
                pn.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                pn.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                pn.NgayNhap = dtpNgayNhap.Value;
                pn.GhiChu = txtGhiChu.Text;
                pn.TongTien = decimal.TryParse(txtTongTien.Text, out decimal t) ? t : 0;
                context.PhieuNhap.Add(pn);
            }
            else
            {
                PhieuNhap pn = context.PhieuNhap.Find(idHienTai);
                if (pn != null)
                {
                    pn.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                    pn.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                    pn.NgayNhap = dtpNgayNhap.Value;
                    pn.GhiChu = txtGhiChu.Text;
                    pn.TongTien = decimal.TryParse(txtTongTien.Text, out decimal t) ? t : 0;
                    context.PhieuNhap.Update(pn);
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
                idHienTai = Convert.ToInt32(row.Cells["PNID"].Value);

                var pn = context.PhieuNhap.Find(idHienTai);
                if (pn != null)
                {
                    cboNhaCungCap.SelectedValue = pn.NhaCungCapID;
                    cboNhanVien.SelectedValue = pn.NhanVienID;
                    dtpNgayNhap.Value = pn.NgayNhap;
                    txtGhiChu.Text = pn.GhiChu;
                    txtTongTien.Text = pn.TongTien.ToString();
                }
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "NhaCungCap")
            {
                var item = dataGridView.Rows[e.RowIndex].DataBoundItem as PhieuNhap;
                if (item != null && item.NhaCungCap != null)
                    e.Value = item.NhaCungCap.TenNhaCungCap;
            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "NhanVien")
            {
                var item = dataGridView.Rows[e.RowIndex].DataBoundItem as PhieuNhap;
                if (item != null && item.NhanVien != null)
                    e.Value = item.NhanVien.HoVaTen;
            }
        }

        private void ResetInput()
        {
            cboNhaCungCap.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            txtGhiChu.Clear();
            txtTongTien.Text = "0";
            dtpNgayNhap.Value = DateTime.Now;
        }
    }
}