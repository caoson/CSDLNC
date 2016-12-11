using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class NhiemVuController : ApiController
    {
        #region nhiem vu
        //them nhiem vu
        [HttpGet]
        public IEnumerable<string> insertMission(int manhiemvu, int maphancong, string tieude, string noidung, int tailieudinhkem, string thoigianbatdau, string thoigianketthuc, string trangthai, int tiendo, int thoigianthuchien, int tansuatnhacnho, int mucdouutien, int danhgianhiemvu)
        {
            return db.InsertNVu(manhiemvu, maphancong, tieude, noidung, tailieudinhkem, thoigianbatdau, thoigianketthuc, trangthai, tiendo, thoigianthuchien, tansuatnhacnho, mucdouutien, danhgianhiemvu).AsEnumerable();
        }
        //sua nhiem vu
        [HttpGet]
        public IEnumerable<string> updateMission(int manhiemvu, int maphancong, string tieude, string noidung, int tailieudinhkem, string thoigianbatdau, string thoigianketthuc, string trangthai, int tiendo, int thoigianthuchien, int tansuatnhacnho, int mucdouutien, int danhgianhiemvu)
        {
            return db.UpdateNVu(manhiemvu, maphancong, tieude, noidung, tailieudinhkem, thoigianbatdau, thoigianketthuc, trangthai, tiendo, thoigianthuchien, tansuatnhacnho, mucdouutien, danhgianhiemvu).AsEnumerable();
        }
        // xoa nhiem vu
        [HttpGet]
        public string deleteMission(int manhiemvu)
        {
            return db.DeleteNVu(manhiemvu).AsEnumerable();
        }
        #endregion
    }
}
