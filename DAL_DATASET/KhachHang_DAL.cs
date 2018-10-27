using DAL_DATASET.QLKARAOKETableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DATASET
{
   public class KhachHang_DAL
    {
       KHACHHANGTableAdapter adapter = new KHACHHANGTableAdapter();
       public DataTable getData()
       {
           return adapter.GetData();
       }
    }
}
