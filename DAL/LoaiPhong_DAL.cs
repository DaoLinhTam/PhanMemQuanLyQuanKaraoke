using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class LoaiPhong_DAL:Database
    {
        public List<LOAIPHONG> LoadDaTa()
        {
            return db.LOAIPHONGs.Select(t => t).ToList();
        }
    }
}
