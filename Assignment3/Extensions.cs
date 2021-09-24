using System;
using System.Collections.Generic;

namespace BDSA2021.Assignment03
{
    public static class Extensions
    {
        public static IEnumerable<int> Flatten(this IEnumerable<IEnumerable<int>> items)
        {
            foreach (var item in items)
            {
                foreach (var i in item)
                {
                    yield return i;
                }
            }
        }
        public static IEnumerable<int> Filter(this IEnumerable<int> items, Predicate<int> predicate)
        {
            foreach (var i in items)
            {
                if(predicate(i))
                {   
                    yield return i;
                }
            }
        }   
    }
}
