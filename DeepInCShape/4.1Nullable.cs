using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCShape
{
    class Nullable
    {
        static void Display(Nullable<int> x)
        {
            Console.WriteLine("HasValue:{0}",x.HasValue);
            if (x.HasValue)
            {
                Console.WriteLine("Value:{0}",x.Value);
                Console.WriteLine("显式转换:{0}", (int)x);
            }
            Console.WriteLine("GetValueOrDefault():{0}",x.GetValueOrDefault());
            Console.WriteLine("GetValueOrDefault(10):{0}",x.GetValueOrDefault(10));

            Console.WriteLine("ToString():{0}",x.ToString());
            Console.WriteLine("GetHashCode():{0}",x.GetHashCode());
            Console.ReadKey();
        }

        //public static void Main(string[] args)
        //{
        //    //Nullable<int> x = 5;
        //    //x = new Nullable<int>(5);
        //    //Console.WriteLine("有值的可空类型：");
        //    //Display(x);

        //    //x = new Nullable<int>();
        //    //Console.WriteLine("没有值的可空类型：");
        //    //Display(x);


        //    //可空类型的装箱和拆箱
        //    Nullable<int> nullable = 5;

        //    object boxed = nullable;  //装箱成“有值的可空类型的实例”
        //    Console.WriteLine(boxed.GetType());

        //    int normal = (int) boxed; //拆箱成非可空变量
        //    Console.WriteLine(normal);

        //    nullable = (Nullable<int>) boxed;  //拆箱成可空变量
        //    Console.WriteLine(nullable);

        //    nullable = new Nullable<int>();  //装箱成“没有值的可空类型的实例”
        //    boxed = nullable;

        //    Console.WriteLine(boxed == null);

        //    nullable = (Nullable<int>) boxed;  //拆箱成可空变量
        //    Console.WriteLine(nullable.HasValue);

        //    Console.ReadKey();
        //}


    }
}
