using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        public int MaChiTietHoaDon { get; set; }
        public int MaHoaDon { get; set; }
        public int MaMonAn { get; set; }
        public int SoLuong { get; set; }
        public float ThanhTien { get; set; }
        public HoaDon HoaDon { get; set; }
        public MonAn MonAn { get; set; }
    }
}
