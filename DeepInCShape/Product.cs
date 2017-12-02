using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 深入理解CShape
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SupplierID { get; set; } //供货商id

        public static ArrayList GetSampleProducts()
        {
            return new ArrayList();
        }

        public static List<Product> GetSampleProductList()
        {
            return new List<Product>();
        }
    }
}
