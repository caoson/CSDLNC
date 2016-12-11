using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PhanAnhController : ApiController
    {
        #region phan anh
        // lay danh sach nhiem vu theo id
        [HttpGet]
        public List<PHANANH> getListFeedback(int maphananh)
        {
            if (maphananh != null)
                return bd.GetlistByIdPA(maphananh).AsEnumerable();
        }
        // lay all danh sach nhiem vu
        [HttpGet]
        public List<PHANANH> getAllListFeedback()
        {
            return bd.GetListAllPA().AsEnumerable();
        }
        //them phan anh
        [HttpGet]
        public IEnumerable<string> insertFeedback(int maphananh, int nguoitao, string tieude, string noidung, int thoigiantao, string tailieudinhkem, int nguoinhan, string capdo, int macongtac)
        {
            return db.InsertPA(maphananh, nguoitao, tieude, noidung, thoigiantao, tailieudinhkem, nguoinhan, capdo, macongtac).AsEnumerable();
        }
        //sua phan anh
        [HttpGet]
        public IEnumerable<string> updateFeedback(int maphananh, int nguoitao, string tieude, string noidung, int thoigiantao, string tailieudinhkem, int nguoinhan, string capdo, int macongtac)
        {
            return db.UpdatePA(maphananh, nguoitao, tieude, noidung, thoigiantao, tailieudinhkem, nguoinhan, capdo, macongtac).AsEnumerable();
        }
        // xoa phan anh
        [HttpGet]
        public string deleteFeedback(int maphananh)
        {
            return db.DeletePA(maphananh).AsEnumerable();
        }
        #endregion
    }
}
