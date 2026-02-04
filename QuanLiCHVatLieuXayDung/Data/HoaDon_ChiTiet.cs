using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCHVatLieuXayDung.Data
{
    public class HoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SanPhamID { get; set; }
        public decimal SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual SanPham SanPham { get; set; } = null!;
    }
}
