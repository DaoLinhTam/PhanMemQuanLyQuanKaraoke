using DAL_DATASET.QLKARAOKETableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DATASET
{
   public class MatHang_DAL
    {
       MATHANGTableAdapter adapter = new MATHANGTableAdapter();
       public DataTable getData()
       {
          return adapter.GetData();
       }

    }
}
