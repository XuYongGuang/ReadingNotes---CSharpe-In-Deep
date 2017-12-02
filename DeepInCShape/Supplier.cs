using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 深入理解CShape
{
    public class Supplier
    {
        public string Name { get; set; }

        public  int SupplierID { get; set; }

        public static List<Supplier> GetSampleSuppliers()
        {
            return new List<Supplier>();
        }
    }
}
