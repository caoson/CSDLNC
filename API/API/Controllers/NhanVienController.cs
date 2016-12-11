using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class NhanVienController : ApiController
    {
        #region nhanvien
        //them nhan vien
        [HttpGet]
        public IEnumerable<string> insertPersonnes (int manhanvien,string hoten, string bidanh, string gioitinh, int ngaysinh,string quequan,string diachi,string email,int sodienthoai, string chucvu,int maphongban, int nguoiquanly)
        {
            return db.InsertNV(manhanvien, hoten, bidanh, gioitinh, ngaysinh, quequan, diachi, email, sodienthoai, chucvu, maphongban, nguoiquanly).AsEnumerable();
        }
        //sua nhan vien
        [HttpGet]
        public IEnumerable<string> updatePersonnes(int manhanvien, string hoten, string bidanh, string gioitinh, int ngaysinh, string quequan, string diachi, string email, int sodienthoai, string chucvu, int maphongban, int nguoiquanly)
        {
            return db.UpdateNV(manhanvien, hoten, bidanh, gioitinh, ngaysinh, quequan, diachi, email, sodienthoai, chucvu, maphongban, nguoiquanly).AsEnumerable();
        }
        // xoa nhan vien
        [HttpGet]
        public string deletePersonnes(int manhanvien)
        {
            return db.DeleteNV(manhanvien).AsEnumerable();
        }
        #endregion
    }
}
