using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DSNguyenLieuBLL
    {
        public DataTable Get_ListNguyenLieu()
        {
            DataTable dt = DSNguyenLieuDAL.Get_ListNguyenLieuDTO();
            return dt;
        }
        public void Add_NguyenLieu(NguyenLieu nguyenLieu)
        {
            DSNguyenLieuDAL.Add_NguyenLieuDTO(nguyenLieu);
        }
        public void Update_InfoNguyenLieu(NguyenLieu nguyenLieu)
        {
            DSNguyenLieuDAL.Update_InfoNguyenLieuDTO(nguyenLieu);
        }
        public void Delete_NguyenLieu(int maNL)
        {
            DSNguyenLieuDAL.Delete_NguyenLieuDTO(maNL);
        }
    }
}
