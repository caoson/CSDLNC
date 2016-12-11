using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class KhaNangNhanVienController : ApiController
    {
        #region kha nang nhan vien
        // lay danh sach kha nang nhan vien theo id
        [HttpGet]
        public List<KhaNangNhanVien> getListPersonnesSpecialize(int makhanang)
        {
            if (makhanang != null) makhanang = 0;
            return bd.GetlistByIdKNNV(makhanang).AsEnumerable();
        }
        // lay all danh sach kha nang nhan vien
        [HttpGet]
        public List<KhaNangNhanVien> getAllListPersonnesSpecialize()
        {
            return bd.GetListAllKNNV().AsEnumerable();
        }
        // them kha nang nhan vien
        [HttpGet]
        public IEnumerable<string> insertPersonnesSpecialize(int makhanang, int manhanvien)
        {
            return db.InsertKNNV(makhanang, manhanvien).AsEnumerable();
        }
        //sua kha nang nhan vien
        [HttpGet]
        public IEnumerable<string> updatePersonnesSpecialize(int makhanang, int manhanvien)
        {
            return db.UpdateKNNV(makhanang, manhanvien).AsEnumerable();
        }
        // xoa kha nang nhan vien
        [HttpGet]
        public string deletePersonnesSpecialize(int makhanang)
        {
            return db.DeleteKNNV(makhanang).AsEnumerable();
        }
        #endregion
    }
}
