using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 深入理解CShape
{
    public class 显式接口实现 : ICloneable
    {
        //public static void Main(string[] args)
        //{
        //    显式接口实现 xs = new 显式接口实现();
        //    xs.Clone();
        //    ICloneable ic = new 显式接口实现();
        //    ic.Clone();
        //    Console.ReadKey();
        //}

        public object Clone()
        {
            Console.WriteLine("实现接口方法");
            return new 显式接口实现();
        }

        //public 显式接口实现 Clone()
        //{
        //    Console.WriteLine("自身clone方法");
        //    return new 显式接口实现();
        //}

        //object ICloneable.Clone()
        //{
        //    Console.WriteLine("接口克隆方法");
        //    return null;
        //}
    }


}
