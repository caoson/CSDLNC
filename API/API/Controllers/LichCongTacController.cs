using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class LichCongTacController : ApiController
    {
        #region lich cong tac
        // lay danh sach nhan vien theo id
        [HttpGet]
        public List<LICHCONGTAC> getListCalendar(int macongtac)
        {
            if (macongtac != null)
                return bd.GetlistByIdLCT(macongtac).AsEnumerable();
        }
        // lay all danh sach lich cong tac
        [HttpGet]
        public List<LICHCONGTAC> getAllListCalendar()
        {
            return bd.GetListAllLCT().AsEnumerable();
        }
        //them lich cong tac
        [HttpGet]
        public IEnumerable<string> insertCalendar(int macongtac, string tieude, string noidung, string tailieudinhkem, int thoigianbangiao, int thoigianphanhoi, int hancuoiphanhoi, string trangthai, string nhan, string ghichu, int nguoitao, int nguoinhan)
        {
            return db.InsertLCT(macongtac, tieude, noidung, tailieudinhkem, thoigianbangiao, thoigianphanhoi, hancuoiphanhoi, trangthai, nhan, ghichu, nguoitao, nguoinhan).AsEnumerable();
        }
        //sua lich cong tac
        [HttpGet]
        public IEnumerable<string> updateCalendar(int macongtac, string tieude, string noidung, string tailieudinhkem, int thoigianbangiao, int thoigianphanhoi, int hancuoiphanhoi, string trangthai, string nhan, string ghichu, int nguoitao, int nguoinhan)
        {
            return db.UpdateLCT(macongtac, tieude, noidung, tailieudinhkem, thoigianbangiao, thoigianphanhoi, hancuoiphanhoi, trangthai, nhan, ghichu, nguoitao, nguoinhan).AsEnumerable();
        }
        // xoa lich cong tac
        [HttpGet]
        public string deleteCalendar(int macongtac)
        {
            return db.DeleteLCT(macongtac).AsEnumerable();
        }
        #endregion
    }
}
