using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 深入理解CShape;

namespace DeepInCShape
{
    public class 值类型和引用类型
    {
        //public static void Main(string[] args)
        //{
        //    Product p = new Product();
        //    p.Price = 10; //此时price是值类型，但是与product一起存在堆上
        //    int i = 10;
        //    Method01(p,i);
        //    Console.WriteLine(p.Price + "---" + i);
        //    Method02(p,ref i);
        //    Console.WriteLine(p.Price + "---" + i);
        //    Console.ReadKey();
        //}

        public static void Method01(Product p,int i)//此时传的是不是p对象，是p对象的引用,
        {
            p.Price = 100;
            i = 100;  //i是值类型，不会改变原来值     
        }

        public static void Method02(Product p,ref int i)
        {
            p.Price = 200;
            i = 200;  //使用ref关键值传了引用，会改变原来值
        }


    }
}
