using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PhongBanController : ApiController
    {
        #region phongban
        // them phong ban
        [HttpGet]
        public IEnumerable<string> insertDepartment(int maphongban, int matruongphong, string tenphongban, string vaitro, string mota)
        {
            return db.InsertPB(maphongban, matruongphong, tenphongban, vaitro, mota).AsEnumerable();
        }
        //sua phongnban
        [HttpGet]
        public IEnumerable<string> updateDepartment(int maphongban, int matruongphong, string tenphongban, string vaitro, string mota)
        {
            return db.UpdatePB(maphongban, matruongphong, tenphongban, vaitro, mota).AsEnumerable();
        }
        // xoa nhan vien
        [HttpGet]
        public string deleteDepartmen(int maphongban)
        {
            return db.DeletePB(maphongban).AsEnumerable();
        }
        #endregion
    }
}
