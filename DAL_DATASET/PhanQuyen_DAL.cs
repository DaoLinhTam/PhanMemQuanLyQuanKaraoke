using DAL_DATASET.QLKARAOKETableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DATASET
{
   public class PhanQuyen_DAL
    {
       PHANQUYENTableAdapter adapter=new PHANQUYENTableAdapter();
       public DataTable getData_TheoMaNhom(String MANHOM)
       {
           return adapter.GetData_TheoMaNhom(MANHOM);
       }
    }
}
