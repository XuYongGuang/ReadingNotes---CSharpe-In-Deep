using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 深入理解CShape
{
    public class LINQ简介
    {
        //过滤集合
        void Test01()
        {
            List<Product> products = Product.GetSampleProductList();
            var filtered = from Product p in products
                where p.Price > 10
                select p;
            foreach (var product in filtered)
            {
                Console.WriteLine(product);
            }
        }

        //连接，过滤，排序，投影
        void Test02()
        {
            //找出产品对应的供应商，并且价格大于10的产品
            List<Product> products = Product.GetSampleProductList();
            List<Supplier> suppliers = Supplier.GetSampleSuppliers();
            var filtered = from p in products
                join s in suppliers on p.SupplierID equals s.SupplierID
                where p.Price > 10m
                orderby s.Name, p.Name
                select new {SupplierName = s.Name, ProductName = p.Name};
            foreach (var v in filtered)
            {
                 Console.WriteLine(v.ProductName + v.ProductName);
            }

        }

        //查询xml
        void Test03()
        {
            XDocument doc = XDocument.Load("data.xml");
            var filtered = from p in doc.Descendants("Product")
                           join s in doc.Descendants("Supplier")
                           on (int)p.Attribute("SupplierID")
                           equals (int)s.Attribute("SupplierID")
                           where (decimal)p.Attribute("Price") > 10
                           orderby (string)s.Attribute("Name"),
                                   (string)p.Attribute("Name")
                           select new
                           {
                               SupplierName = (string)s.Attribute("Name"),
                               ProductName = (string)p.Attribute("Name")
                           };
            foreach (var v in filtered)
            {
                Console.WriteLine(v.ProductName + v.ProductName);
            }
        }





    }
}
