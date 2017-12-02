using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 深入理解CShape;

namespace DeepInCShape
{
    class 空合并操作符
    {

        //合并操作符用于多级比较
        public int Compare(Product first, Product second)
        {
            return PartialComparer.Compare(first, second) ??
                   PartialComparer.Compare(first.Price, second.Price) ??
                   PartialComparer.Compare(first.SupplierID, second.SupplierID) ??
                   PartialComparer.Compare(first.Name, second.Name) ?? 0;
        }

        public static class PartialComparer
        {
            public static int? Compare<T>(T first, T second)
            {
                return Compare(Comparer<T>.Default, first, second);
            }

            public static int? Compare<T>(IComparer<T> comparer, T first, T second)
            {
                int ret = comparer.Compare(first, second);
                return ret == 0 ? new int?() : ret;
            }

            public static int? ReferenceCompare<T>(T first, T second) where T : class
            {
                return first == second
                    ? 0
                    : first == null
                        ? -1
                        : second == null
                            ? 1
                            : new int?();
            }

        }
    }
}
