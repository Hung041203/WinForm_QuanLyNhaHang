using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaNhanVien { get; set; }
        public int MaKhachHang { get; set; }
        public DateTime NgayLap { get; set; }
        public float TongTien { get; set; }

        public NhanVien NhanVien { get; set; }
        public KhachHang KhachHang { get; set; }
    }
}
