using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCShape
{
    class LINQtoObject
    {

        //static void Main(string[] args)
        //{
        //    List<int> list1 = new List<int>() {2, 5, 3, 2, 1, 4};
        //    List<int> list2 = new List<int>() { 2, 5, 3, 1 };
        //    List<int> list3 = new List<int>() { 5, 3, 2 };
        //    Dictionary<int,List<int>> dic = new Dictionary<int, List<int>>();
        //    dic.Add(1, list1);
        //    dic.Add(2, list2);
        //    dic.Add(3, list3);

        //    //用Letk来进行中间计算，避免冗余计算
        //    //var query = from item in dic
        //    //    let length = item.Value.Count
        //    //    orderby length
        //    //    select new {key = item, Length = length};
        //    //foreach (var q in query)
        //    //{
        //    //    Console.WriteLine(q.key + ":" + q.Length);
        //    //}

        //    //内联接（将小序列放在右边提高性能）
        //    //var result = from x in list3
        //    //    where x > 2
        //    //    //先查询再联接
        //    //    join y in list1
        //    //        on x equals y
        //    //    select new {X = x, Y = y};
        //    //foreach (var q in result)
        //    //{
        //    //    Console.WriteLine(q.X + ":" + q.Y);
        //    //}

        //    //join ...into进行分组连接
        //    //var result = from x in list3
        //    //    join y in list1
        //    //        on x equals y
        //    //        into groupValue
        //    //    select new {Value = groupValue};

        //    //foreach (var q in result)
        //    //{
        //    //    Console.WriteLine(q);
        //    //    foreach (var i in q.Value)
        //    //    {
        //    //        Console.WriteLine(i);
        //    //    }
        //    //}

        //    //使用多个from子句进行交叉连接和合并序列          
        //    //右边序列依赖于左边元素交叉连接
        //    //var result = from left in list3
        //    //    from right in list1
        //    //    select new {Left = left, Right = right};
        //    //foreach (var s in result)
        //    //{
        //    //    Console.WriteLine("Left:" + s.Left + "---" + "Right" + s.Right);
        //    //}

        //    //分组和延续
        //    //var result = from s in list1
        //    //    group s by 2;
        //    //foreach (var s in result)
        //    //{
        //    //    Console.WriteLine("key"+s.Key);
        //    //    foreach (var i in s)
        //    //    {
        //    //        Console.WriteLine(i);
        //    //    }
        //    //}



        //    Console.ReadKey();
        //}



    }
}
