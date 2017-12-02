using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeepInCShape
{
    class 忽略委托参数
    {
        public delegate void ThreadStart();

        public delegate void ParamThreadStart(object o);

        //static void Main(string[] args)
        //{
        //    new Thread(delegate() { Console.WriteLine("t1"); });
        //    new Thread(delegate(object o) { Console.WriteLine("t2"); });
            
        //    //编译无法通过，因为编译器无法知道使用哪个委托，上面两个委托都可以
        //  // new Thread(delegate { Console.WriteLine("t3"); }); 
        //}
    }
}
