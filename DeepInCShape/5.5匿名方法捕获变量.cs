using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCShape
{
    class 匿名方法捕获变量
    {
        //static void Main(string[] args)
        //{
        //   // EnclosinMethod();
        //   //Methhod02();
        //   Method03();

        //    Console.ReadKey();
        //}


        static void EnclosinMethod()
        {
            int outVar = 5;       //外部变量
            string capturedVar = "captured";

            if (DateTime.Now.Hour == 23)
            {
                int normalLocalVar = DateTime.Now.Minute;  //普通方法的局部变量
                Console.WriteLine(normalLocalVar);
            }

            Action x = delegate()
            {
                string anonLocal = "匿名方法内的局部变量";
                Console.WriteLine("捕获外部变量:--"+capturedVar + anonLocal);  //捕获外部变量
            };

            x();
        }

        //测试局部变量实例化
        static void Methhod02()
        {
            List<Action> List = new List<Action>();

            for (int i = 0; i < 5; i++)  //for循环的的i只在匿名方法中实例一次
            {
                int counter = i*10;
                List.Add(delegate
                {
                    Console.WriteLine(counter + "----i:" + i);
                    counter++;
                });
            }

            foreach (var action in List)
            {
                action();  //执行全部5个委托实例
            }

            //此时会从实例counter变量停止的地方继续
            List[0]();  //第一个委托执行3次
            List[0]();
            List[0]();

            List[1]();  //第2个委托执行1次
        }

        //扑捉不同作用域的变量
        static void Method03()
        {
            Action[] actions = new Action[2];

            int outside = 0;

            for (int i = 0; i < 2; i++)
            {
                int inside = 0;

                actions[i] = delegate
                {
                    Console.WriteLine("(out:{0},in:{1})", outside, inside);
                    outside++;
                    inside++;
                };
            }

            Action first = actions[0];
            Action second = actions[1];

            first();
            first();
            first();

            second();
            second();
        }

    }
}
