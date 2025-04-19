using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanNhanVien
    {
        public int MaTaiKhoan { get; set; }
        public int MaNhanVien { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
