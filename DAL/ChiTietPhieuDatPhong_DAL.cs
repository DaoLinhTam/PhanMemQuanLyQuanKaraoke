using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ChiTietPhieuDatPhong_DAL:Database
    {

       public string LoadPhongDuocDat(string maphieudatphong)
       {
           string maphong = (from ctdp in db.CHITIET_PHIEUDATPHONGs
                                       where ctdp.MAPHIEUDH == maphieudatphong
                                       select ctdp.MAPH).First();
                                     
          return maphong;
       }

        public bool Them(string mapd,string maph,DateTime gioVaoPhong)
        {
            try
            {
            CHITIET_PHIEUDATPHONG ctdp=new CHITIET_PHIEUDATPHONG();
            ctdp.MAPH=maph;
            ctdp.MAPHIEUDH=mapd;
            ctdp.GIOVAOPHONG=gioVaoPhong;
            db.CHITIET_PHIEUDATPHONGs.InsertOnSubmit(ctdp);
            db.SubmitChanges();
                return true;
            }catch
            {
              return false;
            }
            
        }
           
                   


    }
}
