using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCShape
{
    class 泛型枚举
    {
        //static void Main(string[] args)
        //{
        //    CountingEnumerable counter = new CountingEnumerable();
        //    foreach (var x in counter)
        //    {
        //        Console.WriteLine(x);
        //    }
        //    Console.ReadKey();
        //}

       

    }

    class CountingEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()  //隐式实现IEnumberable<T>
        {
            return new CountingEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() //显示实现IEnumerable
        {
            return GetEnumerator();
        }
    }

    class CountingEnumerator : IEnumerator<int>
    {
        private int current = -1;
        public int Current  //隐式实现IEnumerator<T>.Current
        {
            get { return current; }
        }

        object IEnumerator.Current  //显示实现IEnumerator.Current
        {
            get { return current; }
        }

        public void Dispose(){}

        public bool MoveNext()
        {
            current++;
            return current < 10;
        }

        public void Reset()
        {
            current = -1;
        }
    }

}
