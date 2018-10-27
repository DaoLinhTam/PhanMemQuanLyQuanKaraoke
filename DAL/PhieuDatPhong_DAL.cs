using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class PhieuDatPhong_DAL:Database
    {

      public dynamic getDataFilter()
      {
          var lst = from ph in db.PHIEUDATPHONGs
                    join kh in db.KHACHHANGs on ph.MAKH equals kh.MAKH
                    where ph.GIORA==null
                    select new { MaDat = ph.MAPHIEUDH, TenKH = kh.TENKH,NgayDat=ph.NGAYDATPH, NgayVao = ph.NGAYVAO, GioVao = ph.GIOVAO.ToString() };
          return lst;
      }

      public dynamic getDataFilter(DateTime dtngayVao,DateTime dtGioVao)

      {
          var lst = from ctpd in db.CHITIET_PHIEUDATPHONGs
                    join phdp in db.PHIEUDATPHONGs on ctpd.MAPHIEUDH equals phdp.MAPHIEUDH
                    join ph in db.PHONGs on ctpd.MAPH equals ph.MAPH
                    where phdp.GIORA == null && phdp.GIOVAO>=dtGioVao && phdp.NGAYVAO==dtngayVao
                    select ph.MAPH;
                    
          return lst;
      }
      

        public IEnumerable<PHIEUDATPHONG> getData()
        {
            IEnumerable<PHIEUDATPHONG> lst = db.PHIEUDATPHONGs.Select(t => t).ToList();                    
            return lst;
        }

        public bool Them(string madat,string makh,string manv,DateTime dtNgayDat,DateTime dtNgayVao,DateTime dtGioVao )
        {
           
                PHIEUDATPHONG pdp = new PHIEUDATPHONG();
                pdp.MAPHIEUDH = madat;
                pdp.MAKH = makh;
                pdp.MANV = manv;
                pdp.NGAYDATPH = dtNgayDat;
                pdp.NGAYVAO = dtNgayVao;
                pdp.GIOVAO = dtGioVao;
                db.PHIEUDATPHONGs.InsertOnSubmit(pdp);
                db.SubmitChanges();
                return true;
           

        }
        public bool Xoa(string MaPhieu)
        {
            try
            {
                PHIEUDATPHONG ph = db.PHIEUDATPHONGs.Where(t => t.MAPHIEUDH == MaPhieu).ToList().First();
                db.PHIEUDATPHONGs.DeleteOnSubmit(ph);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        
        }
        public bool Sua()
        {
            return true;
        }


        public string getMaTop(string strDate)
        {
           IEnumerable<PHIEUDATPHONG> lst = getData();
           lst = lst.OrderByDescending(t => t.MAPHIEUDH).ToList().Where(t=>t.MAPHIEUDH.Contains(strDate));

           if (lst.Count() > 0)
               return lst.First().MAPHIEUDH;

            return null;
        }
      
    }
}
