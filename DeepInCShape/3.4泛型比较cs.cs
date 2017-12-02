using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCShape
{
    public class 泛型比较cs
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(CompareToDefault("x"));
        //    Console.WriteLine(CompareToDefault(10));
        //    Console.WriteLine(CompareToDefault(0));
        //    Console.WriteLine(CompareToDefault(-10));
        //    Console.WriteLine(CompareToDefault(DateTime.MinValue));

        //    string str = "xxx";
        //    string str1 = "string";
        //    string str2 = "string";
        //    string str3 = "string" + str;
        //    string str4 = "string" + str;
        //    Console.WriteLine(str1 == str2);
        //    Console.WriteLine(str3 == str4);
        //    Console.WriteLine(AreReferencesEqual(str1, str2));
        //    Console.WriteLine(AreReferencesEqual(str3, str4));

        //    Pair<int,string> p1 = new Pair<int, string>(1,"a");
        //    Pair<int, string> p2 = new Pair<int, string>(1, "a");
        //    Console.WriteLine(p1.Equals(p2));

        //    TypeWithField<int>.field = "int";
        //    TypeWithField<string>.field = "string";
        //    TypeWithField<DateTime>.field = "DateTime";
        //    TypeWithField<int>.PrintField();
        //    TypeWithField<string>.PrintField();
        //    TypeWithField<DateTime>.PrintField();

        //    Console.ReadKey();
        //}

        //泛型默认值
        static int CompareToDefault<T>(T value) where T : IComparable<T>
        {
            return value.CompareTo(default(T));
        }


        //泛型引用比较，不会使用实参的重载
        static bool AreReferencesEqual<T>(T first, T second) where T : class
        {
            return first == second;
        }
    }

    public sealed class Pair<T1, T2> : IEquatable<Pair<T1, T2>>
    {
        private static readonly IEqualityComparer<T1> FirstComparer = EqualityComparer<T1>.Default;
        private static readonly IEqualityComparer<T2> SecondComparer = EqualityComparer<T2>.Default;

        private readonly T1 first;
        private readonly T2 second;
        public T1 First { get { return first; } }
        public T2 Second { get { return second; } }

        public Pair(T1 first, T2 second)
        {
            this.first = first;
            this.second = second;
        } 


        public bool Equals(Pair<T1, T2> other)
        {
            return other != null
                   && FirstComparer.Equals(this.first, other.first)
                   && SecondComparer.Equals(this.second, other.second);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Pair<T1, T2>);
        }

        public override int GetHashCode()
        {
            return FirstComparer.GetHashCode(first) + SecondComparer.GetHashCode(second);
        }
    }

    //不同封闭类型具有不同的静态字段
    class TypeWithField<T>
    {
        public static string field;

        public static void PrintField()
        {
            Console.WriteLine(field + ": " + typeof(T).Name);
        }
    }

}
