using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PhanCongController : ApiController
    {
        #region phan cong
        // lay danh sach phan cong theo id
        [HttpGet]
        public List<PHANCONG> getListDivision(int maphancong)
        {
            if (maphancong != null)
                return bd.GetlistByIdPA(maphancong).AsEnumerable();
        }
        // lay all danh sach phan cong
        [HttpGet]
        public List<PHANCONG> getAllListDivision()
        {
            return bd.GetListAllPA().AsEnumerable();
        }
        //them phan cong
        [HttpGet]
        public IEnumerable<string> insertDivision(int maphancong, int macongtac, int manhanvien, string vaitro, string tieude, string noidung, string tailieudinhkem, int thoigianbatdau, int thoigianketthuc, string trangthai, int tansuatnhacnho, int mucdouutien, string danhgiaphancong, int nguoitao)
        {
            return db.InsertPC(maphancong, macongtac, manhanvien, vaitro, tieude, noidung, tailieudinhkem, thoigianbatdau, thoigianketthuc, trangthai, tansuatnhacnho, mucdouutien, danhgiaphancong, nguoitao).AsEnumerable();
        }
        //sua phan cong
        [HttpGet]
        public IEnumerable<string> updateDivision(int maphancong, int macongtac, int manhanvien, string vaitro, string tieude, string noidung, string tailieudinhkem, int thoigianbatdau, int thoigianketthuc, string trangthai, int tansuatnhacnho, int mucdouutien, string danhgiaphancong, int nguoitao)
        {
            return db.UpdatePC(maphancong, macongtac, manhanvien, vaitro, tieude, noidung, tailieudinhkem, thoigianbatdau, thoigianketthuc, trangthai, tansuatnhacnho, mucdouutien, danhgiaphancong, nguoitao).AsEnumerable();
        }
        // xoa phan cong
        [HttpGet]
        public string deleteDivision(int maphancong)
        {
            return db.DeletePC(maphancong).AsEnumerable();
        }
        #endregion
    }
}
