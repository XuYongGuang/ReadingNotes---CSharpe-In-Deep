using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeepInCShape
{
    class 手写迭代器的痛苦
    {
        static void Main(string[] args)
        {
            //object[] values = {"a", "b", "c", "d", "e"};
            //IterationSample collection = new IterationSample(values,3);
            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}
            DateTime stop = DateTime.Now.AddSeconds(2);
            foreach (var s in CountWithTimeLimit(stop))
            {
                Console.WriteLine("Received:" + s);
                Thread.Sleep(300);
            }


            Console.ReadKey();
        }


        public class IterationSample : IEnumerable
        {
            public object[] values;
            public int startingPoint;

            public IterationSample(object[] values, int startingPoint)
            {
                this.values = values;
                this.startingPoint = startingPoint;
            }

            //public IEnumerator GetEnumerator()
            //{
            //    return new IterationSampleEnumrator(this);
            //}

            //C#2:利用迭代块和yield return简化实现
            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < values.Length; i++)
                {
                    yield return values[(i + startingPoint)%values.Length];
                }
            } 

        }

        class IterationSampleEnumrator : IEnumerator
        {
            private IterationSample parent;
            private int pos;

            internal IterationSampleEnumrator(IterationSample parent)
            {
                this.parent = parent;
                pos = -1;
            }

            public object Current
            {
                get
                {
                    if (pos == -1 || pos == parent.values.Length)
                    {
                        throw new InvalidOperationException();
                    }
                    int index = pos + parent.startingPoint;
                    index = index%parent.values.Length;
                    return parent.values[index];
                }
            }

            public bool MoveNext()
            {
                if (pos != parent.values.Length)
                {
                    pos++;
                }
                return pos < parent.values.Length;
            }

            public void Reset()
            {
                pos = -1;
            }
        }


        //yield break结束迭代
        static IEnumerable<int> CountWithTimeLimit(DateTime limit)
        {
            try
            {
                for (int i = 1; i < 100; i++)
                {
                    if (DateTime.Now >= limit)
                    {
                        yield break;
                    }
                    yield return i;
                }
            }
            finally 
            {
                Console.WriteLine("finally：停止迭代");//停止迭代后也会执行
            }
        }

    }

}
