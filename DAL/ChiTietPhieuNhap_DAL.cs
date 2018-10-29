using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class ChiTietPhieuNhapTB_DAL:Database
    {
      public dynamic getDataQuery(string MaPN)
      {
          return from ct in db.CHITIETNHAPTHIETBIs
                 join tb in db.THIETBIs on ct.MATHIETBI equals tb.MATHIETBI
                 where ct.MAPHIEUNHAP ==MaPN
                 select new { tb.MATHIETBI,tb.TENTHIETBI, ct.DGIANHAP, ct.SLNHAP, ct.THANHTIEN };
      }

      public bool Them(string MAPHIEUNHAP,string MATHIETBI, int SLNHAP,float DGIANHAP)
      {
          try
          {
              
              CHITIETNHAPTHIETBI ct = new CHITIETNHAPTHIETBI();
              ct.MAPHIEUNHAP = MAPHIEUNHAP;
              ct.MATHIETBI = MATHIETBI;
              ct.SLNHAP = SLNHAP;
              ct.DGIANHAP = DGIANHAP;
              ct.THANHTIEN = SLNHAP * DGIANHAP;
              db.CHITIETNHAPTHIETBIs.InsertOnSubmit(ct);
              try
              {
                  db.SubmitChanges();
              }
              catch {
                 
              }
              return true;
          }
          catch { return false; } 
      }

      public bool CapNhatSoLuong(string MAPHIEUNHAP,string MATHIETBI,int SLNHAP, float DGIANHAP)
      {
          try
          {
              CHITIETNHAPTHIETBI ct =db.CHITIETNHAPTHIETBIs.FirstOrDefault(t=>t.MATHIETBI==MATHIETBI && t.MAPHIEUNHAP==MAPHIEUNHAP);
              ct.SLNHAP  +=SLNHAP;
              ct.DGIANHAP = DGIANHAP;
              ct.THANHTIEN = ct.SLNHAP * DGIANHAP;
              db.SubmitChanges();
              return true;
          }
          catch { return false; }
      }

      public bool XoaCTPhieuNHap(string MAPHIEUNHAP, string MATHIETBI)
      {
          try
          {
              CHITIETNHAPTHIETBI ct = db.CHITIETNHAPTHIETBIs.FirstOrDefault(t => t.MATHIETBI == MATHIETBI && t.MAPHIEUNHAP == MAPHIEUNHAP);
              db.CHITIETNHAPTHIETBIs.DeleteOnSubmit(ct);
              db.SubmitChanges();
             
              return true;
          }
          catch { return false; }
      }
    }
}
