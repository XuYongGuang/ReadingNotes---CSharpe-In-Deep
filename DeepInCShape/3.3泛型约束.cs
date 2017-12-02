using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCShape
{
    public class 泛型约束
    {
        struct RefSample<T> where T : class
        {
            public T Data;
        }

        class ValSamplpe<T> where T :struct
        {
            public T Data = new T();
        }

        class MyClass<T> where T : new()  //约束构造函数
        {
             
        }

        //转换类型约束
        class Sample01<T> where T : Stream{}
        class Sample02<T> where T : IDisposable{}
        class Sample03<T> where T : IComparable<T>{}
        class Sample04<T,U> where T : U {}


        //static void Main(string[] args)
        //{
        //    //有效类型，refsample实际上还是属于stuct结构，只是制定T类型要是引用类型
        //    RefSample<string> a = new RefSample<string>();
        //    a.Data = "string";
        //    Console.WriteLine(a.Data.GetType());
        //   // RefSample<int> d;   //无效类型

        //    ValSamplpe<int> f = new ValSamplpe<int>();
        //    Console.WriteLine(f.Data.GetType());
        //    //ValSamplpe<object> o;  无效类型


        //    Console.ReadKey();
        }

    
}
