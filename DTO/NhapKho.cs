using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapKho
    {
        public int MaNhapKho { get; set; }
        public int MaNhanVien { get; set; }
        public int MaNguyenLieu { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuong { get; set; }
        public float TongTien { get; set; }
        public int SoNgayHetHan { get; set; }
    }
}
