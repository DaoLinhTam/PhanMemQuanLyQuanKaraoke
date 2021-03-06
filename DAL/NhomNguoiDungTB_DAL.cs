﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class NhomNguoiDungTB_DAL:Database
    {

       //public dynamic load_NhomND()
       //{
       //    var c = (from mh in db.MANHINHs join pq in db.PHANQUYENs
       //             on mh.MAMANHINH equals pq.MAMANHINH
                    
       //             select new { mh.MAMANHINH, mh.TENMANHINH, pq.COQUYEN });
       //    return c;      
       //}
       
        //public bool themNhomNguoiDung(string manhom, string  tennhom)
        //{
        //    try
        //    {
        //        NHOMNGUOIDUNG nhomND = new NHOMNGUOIDUNG();
        //        nhomND.MANHOM = manhom;
        //        nhomND.TENNHOM = tennhom;
        //        db.NHOMNGUOIDUNGs.InsertOnSubmit(nhomND);
        //        db.SubmitChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    

        public bool xoaNhomNguoiDung(string manhom)
        {
            try
            {
                NHOMNGUOIDUNG nhomND = (from nd in db.NHOMNGUOIDUNGs
                                       where nd.MANHOM == manhom
                                       select nd).First();
                db.NHOMNGUOIDUNGs.DeleteOnSubmit(nhomND);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool capnhatNhomNguoiDung(string manhom,string tennhom)
        {
            try
            {
                NHOMNGUOIDUNG nhomND = (from nd in db.NHOMNGUOIDUNGs
                                        where nd.MANHOM == manhom
                                        select nd).First();
                nhomND.TENNHOM = tennhom;
                db.NHOMNGUOIDUNGs.DeleteOnSubmit(nhomND);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
