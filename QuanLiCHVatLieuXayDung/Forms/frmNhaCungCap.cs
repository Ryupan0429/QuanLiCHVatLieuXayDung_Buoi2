using QuanLiCHVatLieuXayDung.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        bool xuLyThem = false;
        int id;

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<NhaCungCap> ncc = new List<NhaCungCap>();
            ncc = context.NhaCungCap.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ncc;
            txtTenNhaCungCap.DataBindings.Clear();
            txtTenNhaCungCap.DataBindings.Add("Text", bindingSource, "TenNhaCungCap", false, DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        public void BatTatChucNang(bool isEditing)
        {
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnHuyBo.Enabled = isEditing;
            btnLuu.Enabled = isEditing;
            txtTenNhaCungCap.Enabled = isEditing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenNhaCungCap.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private bool validateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenNhaCungCap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(!long.TryParse(txtSDT.Text, out _) || txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                {
                    if (xuLyThem)
                    {
                        NhaCungCap ncc = new NhaCungCap();
                        ncc.TenNhaCungCap = txtTenNhaCungCap.Text;
                        ncc.SoDienThoai = txtSDT.Text;
                        ncc.DiaChi = txtDiaChi.Text;
                        context.NhaCungCap.Add(ncc);
                        context.SaveChanges();
                    }
                    else
                    {
                        NhaCungCap ncc = context.NhaCungCap.Find(id);
                        if (ncc != null)
                        {
                            ncc.TenNhaCungCap = txtTenNhaCungCap.Text;
                            ncc.SoDienThoai = txtSDT.Text;
                            ncc.DiaChi = txtDiaChi.Text;
                            context.NhaCungCap.Update(ncc);
                            context.SaveChanges();
                        }
                    }
                    frmNhaCungCap_Load(sender, e);
                } }
            else 
            {
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhà cung cấp ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                NhaCungCap ncc = context.NhaCungCap.Find(id);
                if (ncc != null)
                {
                    context.NhaCungCap.Remove(ncc);
                }
                context.SaveChanges();
                frmNhaCungCap_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhaCungCap_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNhaCungCap.Text = dataGridView.CurrentRow.Cells["TenNhaCungCap"].Value.ToString();
            txtSDT.Text = dataGridView.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            txtDiaChi.Text = dataGridView.CurrentRow.Cells["DiaChi"].Value.ToString();
        }

    }
}
