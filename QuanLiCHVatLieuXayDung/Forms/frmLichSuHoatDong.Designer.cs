namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmLichSuHoatDong
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
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            HanhDong = new DataGridViewTextBoxColumn();
            DoiTuong = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, NhanVien, ThoiGian, HanhDong, DoiTuong, MoTa });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(800, 450);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // NhanVien
            // 
            NhanVien.HeaderText = "Nhân Viên";
            NhanVien.MinimumWidth = 6;
            NhanVien.Name = "NhanVien";
            NhanVien.ReadOnly = true;
            NhanVien.Width = 125;
            // 
            // ThoiGian
            // 
            ThoiGian.DataPropertyName = "ThoiGian";
            ThoiGian.HeaderText = "Thời gian";
            ThoiGian.MinimumWidth = 6;
            ThoiGian.Name = "ThoiGian";
            ThoiGian.ReadOnly = true;
            ThoiGian.Width = 125;
            // 
            // HanhDong
            // 
            HanhDong.DataPropertyName = "HanhDong";
            HanhDong.HeaderText = "Hành động";
            HanhDong.MinimumWidth = 6;
            HanhDong.Name = "HanhDong";
            HanhDong.ReadOnly = true;
            HanhDong.Width = 125;
            // 
            // DoiTuong
            // 
            DoiTuong.DataPropertyName = "DoiTuong";
            DoiTuong.HeaderText = "Đối tượng";
            DoiTuong.MinimumWidth = 6;
            DoiTuong.Name = "DoiTuong";
            DoiTuong.ReadOnly = true;
            DoiTuong.Width = 125;
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Mô tả";
            MoTa.MinimumWidth = 6;
            MoTa.Name = "MoTa";
            MoTa.ReadOnly = true;
            MoTa.Width = 125;
            // 
            // frmLichSuHoatDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Name = "frmLichSuHoatDong";
            Text = "Lịch sử hoạt động";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn ThoiGian;
        private DataGridViewTextBoxColumn HanhDong;
        private DataGridViewTextBoxColumn DoiTuong;
        private DataGridViewTextBoxColumn MoTa;
    }
}