using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCShape
{
    class 接口和委托的泛型可变性
    {
        //协变性：从api返回的值
        interface IFactory<T>
        {
            T CreateInstanace();
        }

        //逆变性：传人API的值
        interface IPrettyPrinter<T>
        {
            void Print(T document);
        }

        //不变性：双向传递的值
        interface IStorage<T>
        {
            byte[] Serialize(T value);
            T Deserialize(byte[] data);
        }

        interface IShape
        {
            
        }
        class Circles :IShape
        {
             
        }
        class Squares:IShape
        {
             
        }

        class AreaComparer : IComparer<IShape>
        {
            public int Compare(IShape x, IShape y)
            {
                throw new NotImplementedException();
            }
        }

        //委托的可变性
        delegate T Func<out T>();
        delegate void Action<in T>(T obj);
        delegate void Converter<in TInput, out TOutput>(TInput input);

        //static void Main(string[] args)
        //{
        //    List<Circles> circles = new List<Circles>()
        //    {
        //        new Circles(),
        //        new Circles()
        //    };
        //    List<Squares> squares = new List<Squares>()
        //    {
        //        new Squares(),
        //        new Squares()
        //    };

        //    //接口协变性：
        //    //List<IShape> shapeByAdding = new List<IShape>();
        //    //shapeByAdding.AddRange(circles);
        //    //shapeByAdding.AddRange(squares);
        //    //List<IShape> shapesByConcat = circles.Concat<IShape>(squares).ToList();
        //    //foreach (var s in shapesByConcat)
        //    //{
        //    //    Console.WriteLine(s);
        //    //}

        //    //接口的逆变性：
        //    //IComparer<IShape> areaComparer = new AreaComparer();
        //    //circles.Sort(areaComparer);  //使用逆变性排序


        //    //委托的可变性:
        //    //Func<Squares> squareFactory = () => new Squares();
        //    //Func<IShape> shapeFactory = squareFactory;
        //    //Action<IShape> shapePrinter = shape => Console.WriteLine(shape);
        //    //Action<Squares> squarePrinter = shapePrinter;

        //    //多播委托与可变性不能混用
        //    Func<string> stringFunc = () => "";
        //    Func<object> objectFunc = () => new object();
        //    Func<object> combined = objectFunc + stringFunc; //编译时会抛出ArgumentException异常

        //    Console.ReadKey();

        //}

    }
}
