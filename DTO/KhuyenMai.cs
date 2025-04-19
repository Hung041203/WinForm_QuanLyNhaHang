using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMai
    {
        public int MaKhuyenMai { get; set; }
        public string TenKhuyenMai { get; set; }
        public int MaKhachHang { get; set; }
        public bool DaDung { get; set; }
        public DateTime NgayHetHan { get; set; }
        public KhachHang KhachHang { get; set; }

    }
}
