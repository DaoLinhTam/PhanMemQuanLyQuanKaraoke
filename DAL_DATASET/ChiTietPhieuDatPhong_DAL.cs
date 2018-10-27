using DAL_DATASET.QLKARAOKETableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DATASET
{
   public class ChiTietPhieuDatPhong_DAL
    {
        CHITIET_PHIEUDATPHONGTableAdapter adapter = new CHITIET_PHIEUDATPHONGTableAdapter();

        public int Them(string MAPHIEUDH, string MAPH)
        {
            return adapter.InsertQuery(MAPHIEUDH, MAPH);
        }
    }
}
