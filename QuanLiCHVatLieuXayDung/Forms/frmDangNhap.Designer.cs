namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmDangNhap
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
            label1 = new Label();
            label2 = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            label3 = new Label();
            btnDangNhap = new Button();
            txtGhiNho = new CheckBox();
            btnThoát = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 66);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 102);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(125, 59);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(213, 27);
            txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(125, 95);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(213, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(125, 9);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 4;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(125, 165);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(103, 29);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // txtGhiNho
            // 
            txtGhiNho.AutoSize = true;
            txtGhiNho.Location = new Point(125, 129);
            txtGhiNho.Name = "txtGhiNho";
            txtGhiNho.Size = new Size(85, 24);
            txtGhiNho.TabIndex = 6;
            txtGhiNho.Text = "Ghi Nhớ";
            txtGhiNho.UseVisualStyleBackColor = true;
            // 
            // btnThoát
            // 
            btnThoát.Location = new Point(232, 165);
            btnThoát.Name = "btnThoát";
            btnThoát.Size = new Size(106, 29);
            btnThoát.TabIndex = 7;
            btnThoát.Text = "Thoát";
            btnThoát.UseVisualStyleBackColor = true;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 236);
            Controls.Add(btnThoát);
            Controls.Add(txtGhiNho);
            Controls.Add(btnDangNhap);
            Controls.Add(label3);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Label label3;
        private Button btnDangNhap;
        private CheckBox txtGhiNho;
        private Button btnThoát;
    }
}