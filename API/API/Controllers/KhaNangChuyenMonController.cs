using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class KhaNangChuyenMonController : ApiController
    {
        #region kha nang chuyen mon
        // them kha nang chuyen mon
        [HttpGet]
        public IEnumerable<string> insertSpecialize(int makhanang, string tenkhanang, string mota)
        {
            return db.InsertKNCM(makhanang, tenkhanang, mota).AsEnumerable();
        }
        //sua kha nang chuyen mon
        [HttpGet]
        public IEnumerable<string> updateSpecialize(int makhanang, string tenkhanang, string mota)
        {
            return db.UpdateKNCM(makhanang, tenkhanang, mota).AsEnumerable();
        }
        // xoa kha nang chuyen mon
        [HttpGet]
        public string deleteSpecialize(int makhanang)
        {
            return db.DeleteKNCM(makhanang).AsEnumerable();
        }
        #endregion
    }
}
