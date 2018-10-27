using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class KhachHang_DAL:Database
    {
        public IEnumerable<KHACHHANG> getData()
        {
            IEnumerable<KHACHHANG> lst = db.KHACHHANGs.Select(t => t).ToList();

            return lst;
        }
        public dynamic getDataFilter()
        {
            var lst = from kh in db.KHACHHANGs
                      select new { kh.MAKH, kh.TENKH, kh.SDT, kh.DIACHI };
            return lst;
        }

        public string getTopMa()
        {
            IEnumerable<KHACHHANG> lst = getData();
            lst = lst.OrderByDescending(t => t.MAKH).ToList();
            if (lst.Count() > 0)
            {
                return lst.First().MAKH;
            }
            return null;
        }

     

        public bool Them(string makh,string tenkh,string diachi,string sdt)
        {
            try
            {
                KHACHHANG kh = new KHACHHANG();
                kh.MAKH = makh;
                kh.TENKH = tenkh;
                kh.DIACHI = diachi;
                kh.SDT = sdt;
                kh.MALOAIKH = "LK001";
                db.KHACHHANGs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex){
               return false;
            }

        }
        public bool Xoa()
        {
            return true;
        }
        public bool Sua()
        {
            return true;
        }

    }
}
