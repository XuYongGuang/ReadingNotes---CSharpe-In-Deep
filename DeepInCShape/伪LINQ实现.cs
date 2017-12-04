using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCShape
{
    class 伪LINQ实现
    {
        //static void Main(string[] args)
        //{
        //    //var source = new Dummy<string>();
        //    //var query = from dummy in source
        //    //            where dummy.ToString() == "Ignored"
        //    //            select "Anything";

        //    //Cast和OfType操作符
        //    //ArrayList list = new ArrayList { "First", "Second", "Third" };
        //    //IEnumerable<string> strings = list.Cast<string>();
        //    ////同等于：
        //    ////var strings = from string entry in list
        //    ////    select entry.Substring(0, 3);
        //    //foreach (var s in strings)
        //    //{
        //    //    Console.WriteLine(s);
        //    //}

        //    //list = new ArrayList() {1, "not an int", 2, 3};
        //    //IEnumerable<int> ints = list.OfType<int>();
        //    //foreach (var s in ints)
        //    //{
        //    //    Console.WriteLine(s);
        //    //}



        //    Console.ReadKey();
        //}        

    }

    public class Dummy<T>
    {
        public Dummy<U> Select<U>(Func<T, U> selector)
        {
            Console.WriteLine("Select called");
            return new Dummy<U>();
        }
    }

    static class Extensions
    {
        public static Dummy<T> Where<T>(this Dummy<T> dummy, Func<T, bool> predicate)
        {
            Console.WriteLine("Where called");
            return dummy;
        }
    }

}
