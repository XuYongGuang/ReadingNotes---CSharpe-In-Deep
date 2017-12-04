using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCShape
{
    class 编译并执行一个表达式树
    {

        //static void Main(string[] args)
        //{
        //    //普通表达式树
        //    //Expression firstArg = Expression.Constant(2);
        //    //Expression secondArg = Expression.Constant(3);
        //    //Expression add = Expression.Add(firstArg,secondArg);

        //    //Func<int> compiled = Expression.Lambda<Func<int>>(add).Compile();
        //    //Console.WriteLine(compiled());

        //    //将lambda表达式转换成表达式树
        //    //Expression<Func<int>> return10 = () => 10;
        //    //Func<int> compiled = return10.Compile();
        //    //Console.WriteLine(compiled());


        //    //用代码来构造一个方法调用表达式树
        //    //MethodInfo method = typeof (string).GetMethod("StartWith", new[] {typeof (string)});
        //    //var target = Expression.Parameter(typeof (string), "x");
        //    //var methodArg = Expression.Parameter(typeof (string), "y");
        //    //Expression[] methodArgs = new[] {methodArg};

        //    //Expression call = Expression.Call(target,method,methodArgs);

        //    //var lambdaParamters = new[] {target, methodArg};
        //    //var lambda = Expression.Lambda<Func<string, string, bool>>(call, lambdaParamters);
        //    //var compiled = lambda.Compile();

        //    //Console.WriteLine(compiled("First", "Second"));
        //    //Console.WriteLine(compiled("First","Fir"));

        //    //var collection = Enumerable.Reverse(Enumerable.Where(Enumerable.Range(0, 10), x => x%2 != 0));
        //    //foreach (var item in collection)
        //    //{
        //    //      Console.WriteLine(item);      
        //    //}
       
        //    Console.ReadKey();
        //}


    }
}
