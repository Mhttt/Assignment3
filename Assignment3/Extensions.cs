using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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

        public static bool IsSecure(this Uri uri)
        {
            return uri.Scheme == "https";
        }

        public static int WordCount(this string s)
        {
            return (Regex.Split(s,@"\P{L}+")).Count();

        }

        public static void Print(this char[] c)
        {
            foreach (var item in c)
            {
                System.Console.WriteLine(c);
            }
        }
    }
}
