using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class XuatKho
    {
        public int MaXuatKho { get; set; }
        public int MaNhanVien { get; set; }
        public int MaNguyenLieu { get; set; }
        public DateTime NgayXuat { get; set; }
        public int SoLuong { get; set; }
        public string NguyenNhanXuatKho { get; set; }
        public int MaLuuTru { get; set; }
    }
}
