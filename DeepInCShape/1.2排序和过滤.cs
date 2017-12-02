using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 深入理解CShape
{
    public class 排序和过滤
    {
       

        //C# 1.0:  实现IComparer接口,没有泛型强制类型，需要强转
        class ProductNameComparer01 : IComparer
        {
            public int Compare(object x, object y)
            {
                Product first = (Product) x;
                Product second = (Product) y;
                return first.Name.CompareTo(second.Name);
            }
        }
        void Sort01()
        {
            ArrayList productList = Product.GetSampleProducts();
            productList.Sort(new ProductNameComparer01());
            foreach (var product in productList)
            {
                Console.WriteLine(product);
            }
        }

        //C# 2.0：实现泛型IComparer接口
        class ProductNameComparer02 : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return x.Name.CompareTo(y.Name);
            }

        }
        void Sort02()
        {
            List<Product> products = Product.GetSampleProductList();
            products.Sort(new ProductNameComparer02());

            //传递委托
            products.Sort(delegate (Product x, Product y)
            {
                return x.Name.CompareTo(y.Name);
            });

            foreach (var product in products)
            {
                Console.WriteLine(products);
            }

        }



        //C# 3.0：利用lambda
        void Sort03()
        {
            List<Product> products = Product.GetSampleProductList();
            products.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (var product in products)
            {
                Console.WriteLine(products);
            }

            //利用扩展方法，扩展列表
            foreach (var product in products.OrderBy(p => p.Name))
            {
                Console.WriteLine(products);
            }
        }


        //------查询------
        //C# 1.0  测试和打印在一起，不灵活
        void Test01()
        {
            ArrayList products = Product.GetSampleProducts();
            foreach (Product product in products)
            {
                if (product.Price > 10m)
                {
                    Console.WriteLine(product);
                }
            }
        }


        //C# 2.0  测试与打印分开
        void Test02()
        {
            List<Product> products = Product.GetSampleProductList();

            Predicate<Product> test = delegate(Product p) { return p.Price > 10m; };
            List<Product> matches = products.FindAll(test);

            Action<Product> print = Console.WriteLine;
            matches.ForEach(print);

            //简写：
            products.FindAll(delegate(Product p) { return p.Price > 10; }).ForEach(Console.WriteLine);
        }

        //C# 3.0  利用lambada
        void Test03()
        {
            List<Product> products = Product.GetSampleProductList();

            foreach (var product in products.Where(p => p.Price > 10))
            {
                Console.WriteLine(product);
            }
        }
    }


}
