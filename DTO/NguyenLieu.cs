using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieu
    {
        public int MaNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public string DonViTinh { get; set; }
        public float Gia { get; set; }
        public int MaNhaCungCap { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
    }
}
