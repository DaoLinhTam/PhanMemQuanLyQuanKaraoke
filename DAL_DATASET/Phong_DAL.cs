using DAL_DATASET.QLKARAOKETableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DATASET
{
   public class Phong_DAL
    {
       PHONGTableAdapter apdapter=new PHONGTableAdapter();
       public DataTable getData()
       {
           return apdapter.GetData();
       }

      

      
    }
}
