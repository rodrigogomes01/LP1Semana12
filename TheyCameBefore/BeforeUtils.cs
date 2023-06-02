using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> list, T limit)
        where T : struct, IComparable
        {
            foreach (T item in list)
            {
                if (limit.CompareTo(item) > 0)
                    yield return item;
            }
        }
    }
}