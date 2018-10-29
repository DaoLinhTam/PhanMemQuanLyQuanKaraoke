using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiPhong_DAL : Database
    {
        public LoaiPhong_DAL()
        {
        }
        public dynamic loadTable_LoaiPhong()
        {
            return from lph in db.LOAIPHONGs
                   select lph;
        }
        public bool themLoaiPhong(string maloai, string tenloai)
        {
            LOAIPHONG loaiph = new LOAIPHONG();
            loaiph.MALOAIPH = maloai;
            loaiph.TENLOAI = tenloai;
            db.LOAIPHONGs.InsertOnSubmit(loaiph);
            db.SubmitChanges();

            return true;

        }
        public bool XoaLoaiPhong(string maloai)
        {
            LOAIPHONG loaiph = (from lp in db.LOAIPHONGs
                                where (lp.MALOAIPH == maloai)
                                select lp).First();

            db.LOAIPHONGs.DeleteOnSubmit(loaiph);
            db.SubmitChanges();

            return true;

        }

        public bool SuaLoaiPhong(string maloai, string tenloai)
        {
            LOAIPHONG loaiph = (from lp in db.LOAIPHONGs
                                where (lp.MALOAIPH == maloai)
                                select lp).First();

            loaiph.MALOAIPH = maloai;
            loaiph.TENLOAI = tenloai;
            db.SubmitChanges();

            return true;

        }
    }
}
